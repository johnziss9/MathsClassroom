﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class practiceAdditionQuestion : Form
    {
        public int j = 0;
        public int number1, number2, score;
        Timer timer;
        TimeSpan time;

        public practiceAdditionQuestion()
        {
            InitializeComponent();

            timer = new Timer();
            timer.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTimer.Text = time.ToString("hh\\:mm\\:ss");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            int total = number1 + number2;

            if (answer.Text == total.ToString())
            {
                lblAnswer.Text = "Right answer";
                score = score + 1;
                activeScore.Text = score.ToString();
            }
            else
                lblAnswer.Text = "Wrong answer";

            // Show question number
            if (j < 15)
            {
                j++;
                count.Text = j.ToString();
            }

            if (j == 15)
            {
                // Stop the timer
                timer1.Stop();

                // Show "End Practice" button
                submit.Hide();
                btnEndPractice.Visible = true;
            }
            else
                NewQuestion();
        }

        private void practiceAdditionQuestion_Load(object sender, EventArgs e)
        {
            NewQuestion();
        }

        private void btnEndPractice_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                string query = @"INSERT INTO StudentPracticeResults (Username, Score, Time) VALUES (@Username, @Score, @Time)";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Username", "test");
                command.Parameters.AddWithValue("@Score", score.ToString());
                command.Parameters.AddWithValue("@Time", time.ToString());

                command.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Your score has been saved.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            Hide();
            practiceMenu ss = new practiceMenu();
            ss.Show();
        }

        private void NewQuestion()
        {
            Random rand = new Random();
            number1 = rand.Next(100, 999);
            number2 = rand.Next(10, 99);
            num1.Text = number1.ToString();
            num2.Text = number2.ToString();
        }
    }
}