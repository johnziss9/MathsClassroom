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
    public partial class testMenu : Form
    {
        string _username;

        public testMenu(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void practiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceMenu pm = new practiceMenu(_username);
            pm.Show();
        }

        private void testMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            testMenu tm = new testMenu(_username);
            tm.Show();
        }

        private void homeworkMenuBtn_Click(object sender, EventArgs e)
        {
            Hide();
            studentHomework sh = new studentHomework(_username);
            sh.Show();
        }
    }
}
