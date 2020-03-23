using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MathsClassroom
{
    public partial class teacherLoginForm : Form
    {
        public teacherLoginForm()
        {
            InitializeComponent();
        }

        private void passwordTxt_Click(object sender, EventArgs e)
        {

        }

        private void usernameTxt_Click(object sender, EventArgs e)
        {

        }

        private void passwordEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameEntry_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=TeacherLoginDatabase;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from teacherLogin where Username = '" + usernameEntry.Text + "' and Password = '" + passwordEntry.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                practiceMenu ss = new practiceMenu();
                ss.Show();
            }
            else
                MessageBox.Show("please enter correct username and password");
        }

        private void goToStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentLoginForm SLF = new studentLoginForm();
            SLF.ShowDialog();
        }
    }
}
