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
    public partial class teacherSetHomework : Form
    {
        public teacherSetHomework()
        {
            InitializeComponent();
        }

        private void viewHomeworkBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherViewHomework tvh = new teacherViewHomework();
            tvh.ShowDialog();
        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentHomepage ash = new addStudentHomepage();
            ash.ShowDialog();
        }

        private void teacherSetHomework_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mathClassroomDBDataSet.StudentLogins' table. You can move, or remove it, as needed.
            this.studentLoginsTableAdapter.Fill(this.mathClassroomDBDataSet.StudentLogins);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void select_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherQuestionChoice tqc = new teacherQuestionChoice(comboStudents.Text);
            tqc.ShowDialog();
        }

        private void setHomeworkBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
