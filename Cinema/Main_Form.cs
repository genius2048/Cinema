using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Main_Form : Form
    {
        DataBase database = new DataBase();
        DataTable table = new DataTable();
        WebClient webClient = new WebClient();

        private int currentY = 530;
        private int intervalY = 250;

        public int userId;
        public int sessionId;

        List<Control> panelsToRemove = new List<Control>();

        public Main_Form()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            InitializeButtons();
        }

        private void InitializeButtons()
        {
            Button[] buttons = { button2, button3, button4, button5, button6, button7, button8, enter, logIn, signUp };
            DateTime today = DateTime.Now;

            // Массив дней недели
            string[] dayNames = { "Воскресенье", "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота" };

            for (int i = 0; i < buttons.Length-3; i++)
            {
                DateTime targetDate = today.AddDays(i);
                string dayName = i == 0 ? "Сегодня" : i == 1 ? "Завтра" : dayNames[(int)targetDate.DayOfWeek];
                buttons[i].Text = $"{dayName}\n{targetDate:dd MMMM}";
                buttons[i].Click += (sender, e) =>
                {
                    currentY = 530;
                    foreach (Control panel in panelsToRemove)
                    {
                        MainPanel.Controls.Remove(panel);
                        panel.Dispose();
                    }
                    LoadMovies(dayNames[(int)targetDate.DayOfWeek]);
                };
            }
            foreach (Button btn in buttons)
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.FromArgb(0, 0, 0);
                btn.ForeColor = Color.White;
                btn.Font = new Font("Arial", 12, FontStyle.Bold);
                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.MouseEnter += (s, q) => { btn.BackColor = Color.FromArgb(255, 255, 255); btn.ForeColor = Color.FromArgb(0, 0, 0); };
                btn.MouseLeave += (s, q) => { btn.BackColor = Color.FromArgb(0, 0, 0); btn.ForeColor = Color.White; };
            }
        }

        private void enter_Click(object sender, EventArgs e)
        {
            SignPanel.Visible = false;
            LogPanel.Visible = true;
            passwordBoxL.UseSystemPasswordChar = true;
            passwordBoxL.MaxLength = 50;
            loginBoxL.MaxLength = 50;
        }

        private void logIn_Click(object sender, EventArgs e)
        {
            var loginUser = loginBoxL.Text;
            var passwordUser = passwordBoxL.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT UserID, Username, Password, Role FROM Users WHERE Username = '{loginUser}' AND Password = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                string role = table.Rows[0]["Role"].ToString();
                userId = Convert.ToInt32(table.Rows[0]["UserID"]);

                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                switch (role)
                {
                    case "admin":
                        Admin_Form adminForm = new Admin_Form();
                        adminForm.ShowDialog();
                        break;
                    case "user":
                        break;
                    default:
                        MessageBox.Show("Неизвестная роль пользователя!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            var loginUser = loginBoxS.Text;
            var passwordUser = passwordBoxS.Text;

            string querystring = $"insert into Users(Username, Password, Role) values('{loginUser}','{passwordUser}', 'user')";

            if (checkUser())
            {
                SqlCommand command = new SqlCommand(querystring, database.getConnection());

                database.openConnection();
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Вы успешно зарегистрировались!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    checkUser();
                }
                else
                {
                    MessageBox.Show("Ошибка регистрации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                database.openConnection();
            }
            else
            {
                MessageBox.Show("Такой аккаунт уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Boolean checkUser()
        {
            var loginUser = loginBoxS.Text;
            var passwordUser = passwordBoxS.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select UserID, Username, Password, Role from Users where Username = '{loginUser}' and Password = '{passwordUser}'";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                userId = Convert.ToInt32(table.Rows[0]["UserID"]);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void noAccount_Click(object sender, EventArgs e)
        {
            LogPanel.Visible = false;
            SignPanel.Visible = true;
            passwordBoxS.UseSystemPasswordChar = true;
            passwordBoxS.MaxLength = 50;
            loginBoxS.MaxLength = 50;
        }

        private void showPasswordL_Click(object sender, EventArgs e)
        {
            passwordBoxL.UseSystemPasswordChar = false;
            showPasswordL.Visible = false;
            hidePasswordL.Visible = true;
        }

        private void hidePasswordL_Click(object sender, EventArgs e)
        {
            passwordBoxL.UseSystemPasswordChar = true;
            showPasswordL.Visible = true;
            hidePasswordL.Visible = false;
        }

        private void showPasswordS_Click(object sender, EventArgs e)
        {
            passwordBoxS.UseSystemPasswordChar = false;
            showPasswordS.Visible = false;
            hidePasswordS.Visible = true;
        }

        private void hidePasswordS_Click(object sender, EventArgs e)
        {
            passwordBoxS.UseSystemPasswordChar = true;
            showPasswordS.Visible = true;
            hidePasswordS.Visible = false;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
            LoadMovies("Понедельник");
        }

        private void AddPanel(string Title, string About, string Other, string Poster, int SessionID)
        {
            Panel panel = new Panel();
            panel.Size = new Size(850, 240);

            Label other = new Label();
            panel.Controls.Add(other);
            other.Text = Other;
            other.Size = new Size(440, 13);
            other.Location = new Point(218, 6);
            other.Font = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);

            Label title = new Label();
            panel.Controls.Add(title);
            title.Text = Title;
            title.Size = new Size(440, 24);
            title.Location = new Point(218, 25);
            title.Font = new Font("Franklin Gothic Heavy", 14, FontStyle.Italic);

            Label about = new Label();
            panel.Controls.Add(about);
            about.Text = About;
            about.Size = new Size(440, 150);
            about.Location = new Point(218, 58);
            about.Font = new Font("Microsoft Sans Serif", 9, FontStyle.Regular);

            PictureBox poster = new PictureBox();
            panel.Controls.Add(poster);
            poster.Location = new Point(3, 3);
            poster.Size = new Size(175, 230);
            poster.SizeMode = PictureBoxSizeMode.StretchImage;
            byte[] imageBytes = webClient.DownloadData(Poster);
            if (imageBytes != null && imageBytes.Length > 0)
            {
                using (var stream = new System.IO.MemoryStream(imageBytes))
                {
                    poster.Image = Image.FromStream(stream);
                }
            }

            MainPanel.Controls.Add(panel);
            panel.Location = new Point(326, currentY);
            panel.Click += (sender, e) =>
            {
                if(userId == 0) { userId = 1004; }
                Form1 frm1 = new Form1(userId, SessionID);
                frm1.ShowDialog();
                this.Show();
            };
            panelsToRemove.Add(panel);

            currentY += intervalY;
        }

        private void LoadMovies(string dayOfWeekStr)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string querystring = $"SELECT Title, PosterURL, TrailerURL, Genre, Duration, AgeRestriction, About, Movies.MovieID, Sessions.MovieID, HallID, SessionTime, DayOfWeek, SessionID" +
                                 $" FROM Movies" +
                                 $" JOIN Sessions ON Movies.MovieID = Sessions.MovieID" +
                                 $" WHERE Sessions.DayOfWeek = '{dayOfWeekStr}'";

            if (IsToday(dayOfWeekStr))
            {
                querystring += $" ORDER BY CONVERT(time, SessionTime) DESC";
            }

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DateTime sessionTime = Convert.ToDateTime(table.Rows[i]["SessionTime"]);

                //if (sessionTime.TimeOfDay > DateTime.Now.TimeOfDay)
                string[] time = table.Rows[i]["Duration"].ToString().Split(':');
                string title = table.Rows[i]["Title"].ToString();
                string about = table.Rows[i]["About"].ToString();
                string other = $"{table.Rows[i]["AgeRestriction"].ToString()}+     {table.Rows[i]["Genre"].ToString()}     {time[0]} часов {time[1]} минут    {table.Rows[i]["HallID"].ToString()} зал";
                string poster = table.Rows[i]["PosterURL"].ToString();
                int sessionId = Convert.ToInt32(table.Rows[i]["SessionID"]);
                AddPanel(title, about, other, poster, sessionId);
            }
        }

        private bool IsToday(string dayOfWeekStr)
        {
            DayOfWeek today = DateTime.Today.DayOfWeek;
            return dayOfWeekStr.ToLower() == today.ToString().ToLower();
        }

    }
}
