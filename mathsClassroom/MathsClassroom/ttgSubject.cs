using System;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class ttgSubject : Form
    {
        string _username;

        public ttgSubject(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ttgNumQ nq = new ttgNumQ(_username);
            nq.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            practiceMenu practiceMenu = new practiceMenu(_username);
            practiceMenu.Show();
        }
    }
}
