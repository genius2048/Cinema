using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Cinema
{
    public partial class Form1 : Form
    {
        DataBase database = new DataBase();

        private List<Button> seatButtons;
        private List<Button> selectedSeats;
        private int userID;
        private int sessionID;

        public Form1(int userID, int sessionID)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.userID = userID;
            this.sessionID = sessionID;
            InitializeSeatButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string query = $"SELECT SeatNumber, Status FROM Tickets WHERE SessionID = {sessionID}";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int seatNumber = reader.GetInt32(0);
                    string status = reader.GetString(1);

                    if (seatNumber > 0 && seatNumber <= seatButtons.Count)
                    {
                        Button seatButton = seatButtons[seatNumber - 1];

                        if (status == "sold")
                        {
                            seatButton.BackColor = Color.Green;
                        }
                        else if (status == "booked")
                        {
                            seatButton.BackColor = Color.Yellow;
                        }
                    }
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки статусов мест: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }

        private void InitializeSeatButtons()
        {
            seatButtons = new List<Button>
            {
                button1, button2, button3, button4, button5, button6, button7, button8, button9, button10,
                button11, button12, button13, button14, button15, button16, button17, button18, button19, button20,
                button21, button22, button23, button24, button25, button26, button27, button28, button29, button30,
                button31, button32, button33, button34, button35, button36, button37, button38, button39, button40,
                button41, button42, button43, button44, button45, button46, button47, button48, button49, button50,
                button51, button52, button53, button54, button55, button56, button57, button58, button59, button60,
                button61, button62, button63, button64, button65, button66, button67, button68, button69, button70,
                button71, button72, button73, button74, button75, button76, button77, button78, button79, button80,
                button81, button82, button83, button84, button85, button86, button87, button88, button89, button90
            };

            selectedSeats = new List<Button>();

            foreach (Button button in seatButtons)
            {
                button.Click += SeatButton_Click;
                button.BackColor = SystemColors.Control;
            }
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = sender as Button;
            if (seatButton != null)
            {
                if (seatButton.BackColor == SystemColors.Control)
                {
                    seatButton.BackColor = Color.Blue;
                    selectedSeats.Add(seatButton);
                }
                else if (seatButton.BackColor == Color.Blue)
                {
                    seatButton.BackColor = SystemColors.Control;
                    selectedSeats.Remove(seatButton);
                }
            }
        }

        private void Buy_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                UpdateSeatStatus(seat, "sold", sessionID, userID);
                seat.BackColor = Color.Green;
            }
            selectedSeats.Clear();
        }

        private void Book_Click(object sender, EventArgs e)
        {
            foreach (Button seat in selectedSeats)
            {
                UpdateSeatStatus(seat, "booked", sessionID, userID);
                seat.BackColor = Color.Yellow;
            }
            selectedSeats.Clear();
        }

        private void UpdateSeatStatus(Button seat, string status, int sessionId, int userId)
        {
            try
            {
                int seatNumber = seatButtons.IndexOf(seat) + 1;

                string query = $"INSERT INTO Tickets (Status, UserID, SessionID, SeatNumber) VALUES ('{status}', {userId}, {sessionId}, {seatNumber})";
                SqlCommand command = new SqlCommand(query, database.getConnection());

                database.getConnection().Open();
                int rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка добавления: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                database.getConnection().Close();
            }
        }
    }
}
