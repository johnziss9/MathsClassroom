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
    public partial class teacherQuestionChoice : Form
    {
        int _homeworkCount;
        string _studentName;
        string _subject;
        List<string> subjects = new List<string>();
        List<int> noOfQuestions = new List<int>();

        public teacherQuestionChoice(string studentName)
        {
            InitializeComponent();
            _studentName = studentName;
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            _subject = "Addition";

            radio5.Enabled = true;
            radio10.Enabled = true;
            radio15.Enabled = true;
            radio20.Enabled = true;
            dateTimeDueIn.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnSubstraction_Click(object sender, EventArgs e)
        {
            _subject = "Substraction";

            radio5.Enabled = true;
            radio10.Enabled = true;
            radio15.Enabled = true;
            radio20.Enabled = true;
            dateTimeDueIn.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            _subject = "Multiplication";

            radio5.Enabled = true;
            radio10.Enabled = true;
            radio15.Enabled = true;
            radio20.Enabled = true;
            dateTimeDueIn.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            _subject = "Division";

            radio5.Enabled = true;
            radio10.Enabled = true;
            radio15.Enabled = true;
            radio20.Enabled = true;
            dateTimeDueIn.Enabled = true;
            btnAdd.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int radioButtonValue = 0;

            // Get radio button value
            if (radio5.Checked)
                radioButtonValue = 5;
            else if (radio10.Checked)
                radioButtonValue = 10;
            else if (radio15.Checked)
                radioButtonValue = 15;
            else if (radio20.Checked)
                radioButtonValue = 20;
            else
            {
                MessageBox.Show("Please select a number of questions.", "Number of Questions", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Add homework in lists
            subjects.Add(_subject);
            noOfQuestions.Add(radioButtonValue);

            // Change homework label
            _homeworkCount++;
            lblHomeworksAdded.Text = "Homework Added: " + _homeworkCount;

            // Disable number of questions section
            radio5.Enabled = false;
            radio10.Enabled = false;
            radio15.Enabled = false;
            radio20.Enabled = false;
            dateTimeDueIn.Enabled = false;
            btnAdd.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherConfimationScreen teacherConfimation = new teacherConfimationScreen(_studentName, subjects, noOfQuestions, dateTimeDueIn.Value.ToShortDateString());
            teacherConfimation.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Hide();
            teacherSetHomework setHomework = new teacherSetHomework();
            setHomework.Show();
        }
    }
}
