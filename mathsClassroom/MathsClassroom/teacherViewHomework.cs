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
    public partial class teacherViewHomework : Form
    {
        public teacherViewHomework()
        {
            InitializeComponent();
        }

        private void viewHomeworkBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void teacherViewHomework_Load(object sender, EventArgs e)
        {

        }

        private void addStudentBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            addStudentHomepage ash = new addStudentHomepage();
            ash.ShowDialog();
        }
    }
}
