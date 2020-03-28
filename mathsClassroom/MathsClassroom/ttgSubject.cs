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
    public partial class ttgSubject : Form
    {
        public ttgSubject()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //practiceMenu pm = new practiceMenu();
            //pm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {

        }

        private void choice7_Click(object sender, EventArgs e)
        {
            this.Hide();
            ttgNumQ nq = new ttgNumQ();
            nq.ShowDialog();

        }
    }
}
