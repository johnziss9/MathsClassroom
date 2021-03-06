﻿using System;
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
            passwordEntry.PasswordChar = '*';
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-I1C7SOR;Initial Catalog=mathClassroomDB;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from TeacherLogins where Username = '" + usernameEntry.Text + "' and Password = '" + passwordEntry.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                Hide();
                addStudentHomepage addStudent = new addStudentHomepage();
                addStudent.Show();
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
