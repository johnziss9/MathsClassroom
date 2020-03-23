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
    public partial class studentLoginForm : Form
    {
        public studentLoginForm()
        {
            InitializeComponent();
        }

        private void goToTeacherBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherLoginForm TLF = new teacherLoginForm();
            TLF.ShowDialog();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\Documents\studentLoginDatabase.mdf;Integrated Security=True;Connect Timeout=30");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from studentLogin where Username = '" + usernameEntry.Text + "' and Password = '" + passwordEntry.Text + "'", conn);
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
    }
}
