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
    public partial class teacherViewHomework : Form
    {
        public teacherViewHomework()
        {
            InitializeComponent();
            lblDate.Text = "Date: " + DateTime.Now.ToShortDateString();
        }

        private void teacherViewHomework_Load(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                // Fill in incompleted homeworks

                BindingSource bsCom = new BindingSource();

                dt = new DataTable();
                da = new SqlDataAdapter("SELECT Student, Subject, NoOfQuestions, DueDate FROM Homework WHERE Completed = 0", conn);

                da.Fill(dt);
                bsCom.DataSource = dt;
                dataGridCompleted.DataSource = bsCom;

                // Fill in completed homeworks

                BindingSource bsNotCom = new BindingSource();

                dt = new DataTable();
                da = new SqlDataAdapter("SELECT Student, Subject, Score, NoOfQuestions, DueDate, DateSubmitted FROM Homework WHERE Completed = 1", conn);

                da.Fill(dt);
                bsNotCom.DataSource = dt;
                dataGridNotCompleted.DataSource = bsNotCom;
            }
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentHomepage ash = new addStudentHomepage();
            ash.ShowDialog();
        }

        private void setHomeworkBtn_Click(object sender, EventArgs e)
        {
            Hide();
            teacherSetHomework setHomework = new teacherSetHomework();
            setHomework.Show();
        }
    }
}
