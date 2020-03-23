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
    public partial class practiceMenu : Form
    {
        public practiceMenu()
        {
            InitializeComponent();
        }

        private void practiceBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceMenu pm = new practiceMenu();
            pm.ShowDialog();
        }

        private void testMenuBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            testMenu tm = new testMenu();
            tm.ShowDialog();
        }

        private void additionBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            practiceAdditionMenu pam = new practiceAdditionMenu();
            pam.ShowDialog();
        }
    }
}
