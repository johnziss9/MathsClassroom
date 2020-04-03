using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class homeworkQuestions : Form
    {
        int _id;
        int _noOfQuestions;
        string _username;
        string _subject;

        int number1, number2, score;
        int j;

        TimeSpan time;

        public homeworkQuestions(int id, string username, string subject, int noOfQuestions)
        {
            InitializeComponent();
            _id = id;
            _username = username;
            _subject = subject;
            _noOfQuestions = noOfQuestions;
        }

        private void homeworkQuestions_Load(object sender, EventArgs e)
        {
            label7.Text = "/ " + _noOfQuestions.ToString();

            // Generate questions
            NewQuestion();

            // Get subject
            label4.Text = GetSubject();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            // Checks answer and clears textbox
            int total = GetTotal();

            if (answer.Text == total.ToString())
            {
                lblAnswer.Text = "Right answer";
                score = score + 1;
                activeScore.Text = score.ToString();
                answer.Text = "";
            }
            else
            {
                lblAnswer.Text = "Wrong answer";
                answer.Text = "";
            }

            // Show question number
            if (j < _noOfQuestions)
            {
                j++;
                count.Text = j.ToString();
            }

            if (j == _noOfQuestions)
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

        private string GetSubject()
        {
            string symbol = "";

            switch(_subject)
            {
                case "Addition":
                    symbol = "+";
                    break;
                case "Substraction":
                    symbol = "-";
                    break;
                case "Multiplication":
                    symbol = "x";
                    break;
                case "Division":
                    symbol = "÷";
                    break;
                default:
                    break;
            }

            return symbol;
        }

        private void btnEndPractice_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                string query = @"UPDATE Homework SET Score = @Score, Completed = @Completed, DateSubmitted = @DateSubmitted, Time = @Time WHERE Id = @Id";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Score", score);
                command.Parameters.AddWithValue("@Completed", true);
                command.Parameters.AddWithValue("@DateSubmitted", DateTime.Now.ToShortDateString());
                command.Parameters.AddWithValue("@Time", lblTimer.Text);
                command.Parameters.AddWithValue("@Id", _id);

                command.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("Your score has been saved.", "Thank You", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hide();
            studentHomework sh = new studentHomework(_username);
            sh.Show();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            time = time.Add(new TimeSpan(0, 0, 1));
            lblTimer.Text = time.ToString("hh\\:mm\\:ss");
        }

        private int GetTotal()
        {
            int total = 0;

            switch (_subject)
            {
                case "Addition":
                    total = number1 + number2;
                    break;
                case "Substraction":
                    total = number1 - number2;
                    break;
                case "Multiplication":
                    total = number1 * number2;
                    break;
                case "Division":
                    total = number1 / number2;
                    break;
                default:
                    break;
            }

            return total;
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
