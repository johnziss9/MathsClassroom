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
        List<string> _subjects;

        public teacherConfimationScreen(string studentName, List<string> subjects)
        {
            InitializeComponent();
            _studentName = studentName;
            _subjects = subjects;
        }

        private void teacherConfimationScreen_Load(object sender, EventArgs e)
        {
            int additionCount = 0;
            int substractionCount = 0;
            int multiplicationCount = 0;
            int divisionCount = 0;

            foreach (var sub in _subjects)
            {
                switch (sub)
                {
                    case "Addition":
                        additionCount++;
                        break;
                    case "Substraction":
                        substractionCount++;
                        break;
                    case "Multiplication":
                        multiplicationCount++;
                        break;
                    case "Division":
                        divisionCount++;
                        break;
                    default:
                        break;
                }
            }

            additionQuestions.Text = additionCount.ToString();
            subtractionQuestions.Text = substractionCount.ToString();
            multiplicationQuestions.Text = multiplicationCount.ToString();
            divisionQuestions.Text = divisionCount.ToString();
            name.Text = _studentName;
        }
    }
}
