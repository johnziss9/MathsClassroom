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
    public partial class teacherViewSingleHomework : Form
    {
        int _currentRow;

        public teacherViewSingleHomework(int currentRow)
        {
            InitializeComponent();
            _currentRow = currentRow;
        }

        private void teacherViewSingleHomework_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                SqlCommand command;
                SqlDataReader dr;

                string query = "SELECT * FROM Homework WHERE Id = " + _currentRow ;

                conn.Open();

                command = new SqlCommand(query, conn);

                dr = command.ExecuteReader();

                while (dr.Read())
                {
                    int percentage = (Convert.ToInt32(dr["Score"]) * 100) / Convert.ToInt32(dr["NoOfQuestions"]);
                    string outcome = percentage >= 60 ? "PASS" : "FAIL - " + dr["Student"].ToString() + " needs to practice " + dr["Subject"].ToString();

                    lblStudentmName.Text = dr["Student"].ToString();
                    lblSubjectName.Text = dr["Subject"].ToString();
                    lblHomeworkScore.Text = dr["Score"].ToString() + " out of " + dr["NoOfQuestions"].ToString();
                    lblHomeworkPercentage.Text = percentage + "%";
                    lblHomeworkOutcome.Text = outcome;
                }

                conn.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Hide();
            teacherViewHomework viewHomework = new teacherViewHomework();
            viewHomework.Show();
        }
    }
}