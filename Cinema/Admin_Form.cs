using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ScrollBar;

namespace Cinema
{
    public partial class Admin_Form : Form
    {
        DataBase database = new DataBase();
        DataTable table = new DataTable();
        DataTable sessionTable = new DataTable();
        public Admin_Form()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void FilmsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Update_table()
        {
            SqlDataAdapter adapter = new SqlDataAdapter();

            string querystring = $"SELECT MovieID, Title, Genre, Duration, AgeRestriction, TrailerURL, PosterURL, PremiereDate, MainActors, About, Dubbing, Director FROM Movies";

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            FilmsDataGridView.DataSource = table;

            FilmsComboBox.Items.Clear();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                FilmsComboBox.Items.Add(table.Rows[i]["Title"].ToString());
            }
        }


        private void Admin_Form_Load(object sender, EventArgs e)
        {
            Update_table();
        }

        private void FilmsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedTitle = FilmsComboBox.SelectedItem.ToString();
                string query = $"SELECT * FROM Movies WHERE Title = '{selectedTitle}'";

                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    TitleBox.Text = reader["Title"].ToString();
                    GenreBox.Text = reader["Genre"].ToString();
                    DurationBox.Text = reader["Duration"].ToString();
                    DirectorBox.Text = reader["Director"].ToString();
                    PremiereBox.Text = reader["PremiereDate"].ToString();
                    ActorsBox.Text = reader["MainActors"].ToString();
                    AboutBox.Text = reader["About"].ToString();
                    AgeBox.Text = reader["AgeRestriction"].ToString();
                    DubbingBox.Text = reader["Dubbing"].ToString();
                    TrailerBox.Text = reader["TrailerURL"].ToString();
                    PosterBox.Text = reader["PosterURL"].ToString();

                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки данных фильма: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTitle = FilmsComboBox.SelectedItem.ToString();

                string query = $"UPDATE Movies SET " +
                    $"Title = '{TitleBox.Text}', " +
                    $"Genre = '{GenreBox.Text}', " +
                    $"Duration = '{DurationBox.Text}', " +
                    $"Director = '{DirectorBox.Text}', " +
                    $"PremiereDate = '{PremiereBox.Text}', " +
                    $"MainActors = '{ActorsBox.Text}', " +
                    $"About = '{AboutBox.Text}', " +
                    $"AgeRestriction = '{AgeBox.Text}', " +
                    $"Dubbing = '{DubbingBox.Text}', " +
                    $"TrailerURL = '{TrailerBox.Text}', " +
                    $"PosterURL = '{PosterBox.Text}' " +
                    $"WHERE Title = '{selectedTitle}'";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Значение успешно сохранено!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_table();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить значение", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения данных: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT INTO Movies (Title, Genre, Duration, Director, PremiereDate, MainActors, About, AgeRestriction, Dubbing, TrailerURL, PosterURL) " +
                    $"VALUES ('{TitleBox.Text}', '{GenreBox.Text}', '{DurationBox.Text}', '{DirectorBox.Text}', '{PremiereBox.Text}', '{ActorsBox.Text}', '{AboutBox.Text}', '{AgeBox.Text}', '{DubbingBox.Text}', '{TrailerBox.Text}', '{PosterBox.Text}')";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Фильм успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_table();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить фильм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления фильма: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }


        private void Delete_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedTitle = FilmsComboBox.SelectedItem.ToString();

                string query = $"DELETE FROM Movies WHERE Title = '{selectedTitle}'";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Фильм успешно удален!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_table();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить фильм", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления фильма: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }


        private void Back_Click(object sender, EventArgs e)
        {
            Main_Form frm = new Main_Form();
            this.Hide();
            frm.ShowDialog();
        }

        private void Update_sessions(string dayOfWeek = null)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            string querystring = "SELECT * FROM Sessions";

            if (dayOfWeek != null)
            {
                querystring += $" WHERE DayOfWeek = '{dayOfWeek}'";
            }

            SqlCommand command = new SqlCommand(querystring, database.getConnection());

            adapter.SelectCommand = command;
            sessionTable.Clear();
            adapter.Fill(sessionTable);

            ScheduleDataGridView.DataSource = sessionTable;
        }

        private void AddS_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"INSERT INTO Sessions (MovieID, DayOfWeek, SessionTime, HallID) " +
                    $"VALUES ('{Convert.ToInt32(FilmIDBox.Text)}', '{DayOfWeekComboBox.SelectedItem}', '{TimeBox.Text}', '{Convert.ToInt32(HallBox.Text)}')";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сеанс успешно добавлен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_sessions();
                }
                else
                {
                    MessageBox.Show("Не удалось добавить сеанс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void SaveS_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"UPDATE Sessions SET " +
                    $"DayOfWeek = '{DayOfWeekComboBox.SelectedItem}', " +
                    $"SessionTime = '{TimeBox.Text}', " +
                    $"HallID = '{Convert.ToInt32(HallBox.Text)}' " +
                    $"WHERE SessionID = '{Convert.ToInt32(SessionIDBox.Text)}'";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сеанс успешно сохранен!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_sessions();
                }
                else
                {
                    MessageBox.Show("Не удалось сохранить сеанс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void DeleteS_Click(object sender, EventArgs e)
        {
            try
            {
                string query = $"DELETE FROM Sessions WHERE SessionID = '{SessionIDBox.Text}'";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Сеанс успешно удален!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Update_sessions();
                }
                else
                {
                    MessageBox.Show("Не удалось удалить сеанс", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка удаления сеанса: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void DayOfWeekComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDay = DayOfWeekComboBox.SelectedItem.ToString();
            Update_sessions(selectedDay);
        }
    }
}
