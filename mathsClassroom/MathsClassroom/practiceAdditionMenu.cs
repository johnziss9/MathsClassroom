using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace MathsClassroom
{
    public partial class practiceAdditionMenu : Form
    {
        public practiceAdditionMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceMenu pm = new practiceMenu();
            pm.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.youtube.com/watch?v=pxUY29LpMZE");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceAdditionChoice pac = new practiceAdditionChoice();
            pac.ShowDialog();

        }
    }
}
