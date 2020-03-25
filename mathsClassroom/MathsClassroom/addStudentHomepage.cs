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
    public partial class addStudentHomepage : Form
    {
        public addStudentHomepage()
        {
            InitializeComponent();
        }

        private void addStudentHomepage_Load(object sender, EventArgs e)
        {

        }

        private void viewHomeworkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherViewHomework tvh = new teacherViewHomework();
            tvh.ShowDialog();
        }

        private void setHomeworkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherSetHomework tsh = new teacherSetHomework();
            tsh.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
