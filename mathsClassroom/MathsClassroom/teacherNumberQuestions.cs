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
        string _studentName;

        public teacherNumberQuestions(string studentName)
        {
            InitializeComponent();
            _studentName = studentName;
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
            teacherQuestionChoice tqc = new teacherQuestionChoice(_studentName);
            tqc.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherConfimationScreen tcs = new teacherConfimationScreen(_studentName);
            tcs.ShowDialog();
        }
    }
}