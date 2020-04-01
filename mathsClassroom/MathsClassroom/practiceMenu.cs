using System;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class practiceMenu : Form
    {
        string _username;

        public practiceMenu(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void testMenuBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            testMenu tm = new testMenu(_username);
            tm.ShowDialog();
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceAdditionMenu pam = new practiceAdditionMenu(_username);
            pam.ShowDialog();
        }

        private void ttgBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            ttgSubject sub = new ttgSubject(_username);
            sub.ShowDialog();
        }
    }
}
