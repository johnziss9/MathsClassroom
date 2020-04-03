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
    public partial class addStudentHomepage : Form
    {
        public addStudentHomepage()
        {
            InitializeComponent();
        }

        private void viewHomeworkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherViewHomework tvh = new teacherViewHomework();
            tvh.ShowDialog();
        }

        private void setHomeworkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherSetHomework tsh = new teacherSetHomework();
            tsh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True"))
            {
                string query = @"INSERT INTO StudentLogins (Username, Password) VALUES (@Username, @Password)";

                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.AddWithValue("@Username", txtUsername.Text);
                command.Parameters.AddWithValue("@Password", txtPassword.Text);

                command.ExecuteNonQuery();

                conn.Close();
            }

            MessageBox.Show("The student userame and password have been saved.", "Student Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtUsername.Text = "";
            txtPassword.Text = "";
        }
    }
}
