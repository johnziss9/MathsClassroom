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
    public partial class ttgNumQ : Form
    {
        string _username;

        public ttgNumQ(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ttgSubject sub = new ttgSubject(_username);
            sub.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            ttgQuestions ttgQuestions = new ttgQuestions(_username);
            ttgQuestions.Show();
        }
    }
}
