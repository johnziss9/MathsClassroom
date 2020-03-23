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
    public partial class practiceAdditionQuestion : Form
    {
        public int number1, number2, score;
        

        public practiceAdditionQuestion()
        {
            InitializeComponent();
        }


        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            i++;
            lblTimer.Text = i.ToString() + " Seconds";
        }

        int j = 0;

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void num1_Click(object sender, EventArgs e)
        {

        }

        private void num2_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {


            int total = number1 + number2;
            if (answer.Text == total.ToString())
            {
                answer.Text = "";
                answer.Text = "right answer";
                score = score + 1;
                activeScore.Text = score.ToString();


            }
            else
            {
                answer.Text = "";
                answer.Text = "wrong answer";

            }

                
            if (j < 15)
            {
                j++;
                count.Text = j.ToString();
            }
            else
            {
                timer1.Stop();
            }


        }

        int l = 0;  
        private void startBtn_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            number1 = rand.Next(100,999);
            number2 = rand.Next(10,99);
            num1.Text = number1.ToString();
            num2.Text = number2.ToString();
        }
    }
}