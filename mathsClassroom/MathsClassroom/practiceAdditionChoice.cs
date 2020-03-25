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
    public partial class practiceAdditionChoice : Form
    {
        string _username;

        public practiceAdditionChoice(string username)
        {
            InitializeComponent();
            _username = username;
        }

        private void practiceAdditionChoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            practiceAdditionQuestion paq = new practiceAdditionQuestion(_username);
            paq.ShowDialog();
        }
    }
}
