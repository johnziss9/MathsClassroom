using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class studentHomework : Form
    {
        string _username;

        public studentHomework(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void studentHomework_Load(object sender, EventArgs e)
        {
            label1.Text = "Incomplete Homework for " + _username;

            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter();

                BindingSource bs = new BindingSource();

                dt = new DataTable();
                da = new SqlDataAdapter("SELECT Id, Subject, NoOfQuestions, DueDate FROM Homework WHERE Student = '" + _username + "' AND Completed = 0", conn);

                da.Fill(dt);
                bs.DataSource = dt;
                dataGridHomework.DataSource = bs;

                dataGridHomework.Columns[0].Visible = false;
            }
        }

        private void dataGridHomework_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var currentRow = Convert.ToInt32(dataGridHomework.CurrentRow.Cells[0].Value);
            var subject = dataGridHomework.CurrentRow.Cells[1].Value.ToString();
            var noOfQuestions = Convert.ToInt32(dataGridHomework.CurrentRow.Cells[2].Value);

            Hide();
            homeworkQuestions hq = new homeworkQuestions(currentRow, _username, subject, noOfQuestions);
            hq.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            practiceMenu pm = new practiceMenu(_username);
            pm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            testMenu testMenu = new testMenu(_username);
            testMenu.Show();
        }
    }
}
