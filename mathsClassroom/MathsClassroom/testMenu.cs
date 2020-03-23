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
    public partial class testMenu : Form
    {
        public testMenu()
        {
            InitializeComponent();
        }

        private void practiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceMenu pm = new practiceMenu();
            pm.Show();
        }

        private void testMenuBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            testMenu tm = new testMenu();
            tm.Show();
        }
    }
}
