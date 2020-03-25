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
    public partial class teacherConfimationScreen : Form
    {
        string _studentName;

        public teacherConfimationScreen(string studentName)
        {
            InitializeComponent();
            _studentName = studentName;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
