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
    public partial class teacherNumberQuestions : Form
    {
        public teacherNumberQuestions()
        {
            InitializeComponent();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {

        }

        private void viewHomeworkBtn_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void addTopicBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherQuestionChoice tqc = new teacherQuestionChoice();
            tqc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherConfimationScreen tcs = new teacherConfimationScreen();
            tcs.ShowDialog();
        }
    }
}