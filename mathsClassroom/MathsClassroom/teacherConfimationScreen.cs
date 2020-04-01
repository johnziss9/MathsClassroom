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

namespace MathsClassroom
{
    public partial class teacherConfimationScreen : Form
    {
        string _dueDate;
        string _studentName;
        List<string> _subjects;
        List<int> _noOfQuestions;

        public teacherConfimationScreen(string studentName, List<string> subjects, List<int> noOfQuestions, string dueDate)
        {
            InitializeComponent();
            _studentName = studentName;
            _subjects = subjects;
            _noOfQuestions = noOfQuestions;
            _dueDate = dueDate;
        }

        private void teacherConfimationScreen_Load(object sender, EventArgs e)
        {
            int additionCount = 0;
            int substractionCount = 0;
            int multiplicationCount = 0;
            int divisionCount = 0;

            foreach (var sub in _subjects)
            {
                switch (sub)
                {
                    case "Addition":
                        additionCount++;
                        break;
                    case "Substraction":
                        substractionCount++;
                        break;
                    case "Multiplication":
                        multiplicationCount++;
                        break;
                    case "Division":
                        divisionCount++;
                        break;
                    default:
                        break;
                }
            }

            additionQuestions.Text = additionCount.ToString();
            subtractionQuestions.Text = substractionCount.ToString();
            multiplicationQuestions.Text = multiplicationCount.ToString();
            divisionQuestions.Text = divisionCount.ToString();
            name.Text = _studentName;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                int subjectPosition = 0;
                string query = @"INSERT INTO Homework (Student, Subject, NoOfQuestions, Score, Completed, DueDate, DateSubmitted) VALUES (@Student, @Subject, @NoOfQuestions, @Score, @Completed, @DueDate, @DateSubmitted)";

                foreach (var sub in _subjects)
                {
                    conn.Open();

                    SqlCommand command = new SqlCommand(query, conn);

                    command.Parameters.AddWithValue("@Student", _studentName);
                    command.Parameters.AddWithValue("@Subject", sub);
                    command.Parameters.AddWithValue("@NoOfQuestions", _noOfQuestions[subjectPosition]);
                    command.Parameters.AddWithValue("@Score", 0);
                    command.Parameters.AddWithValue("@Completed", false);
                    command.Parameters.AddWithValue("@DueDate", _dueDate);
                    command.Parameters.AddWithValue("@DateSubmitted", "");

                    command.ExecuteNonQuery();

                    subjectPosition++;

                    conn.Close();
                }

                MessageBox.Show("Homework for " + _studentName + " have been saved.", "Homework Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                addStudentHomepage addStudent = new addStudentHomepage();
                addStudent.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            teacherQuestionChoice qChoice = new teacherQuestionChoice(_studentName);
            qChoice.Show();
        }
    }
}
