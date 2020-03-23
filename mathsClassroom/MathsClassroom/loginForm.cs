using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void teacherLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherLoginForm TLF = new teacherLoginForm();
            TLF.ShowDialog();

        }

        private void studentLoginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentLoginForm SLF = new studentLoginForm();
            SLF.ShowDialog();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
