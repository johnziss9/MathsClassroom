using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class ttgQuestions : Form
    {
        Random random;
        List<int> buttons = new List<int>();
        int randomNubmer;

        int button1Num;
        int button2Num;
        int button3Num;
        int button4Num;
        int button5Num;
        int button6Num;
        int button7Num;
        int button8Num;
        bool button1Clicked = false;
        bool button2Clicked = false;
        bool button3Clicked = false;
        bool button4Clicked = false;
        bool button5Clicked = false;
        bool button6Clicked = false;
        bool button7Clicked = false;
        bool button8Clicked = false;

        string question1;
        string question2;
        string question3;
        string question4;
        string answer1;
        string answer2;
        string answer3;
        string answer4;

        public ttgQuestions()
        {
            InitializeComponent();

            // Fill in the list
            for (int i = 1; i <= 8; i++)
                buttons.Add(i);

            GenerateQandA();
        }

        // TODO Get cards to show unique questions and answers
        // TODO Get card guessed correctly to stay visible

        private void GenerateQandA()
        {
            Random rand = new Random();
            int num1 = 3;
            int num2 = 0;

            num2 = rand.Next(0, 10);
            question1 = num1 + " x " + num2;
            answer1 = Convert.ToString(num1 * num2);

            num2 = rand.Next(0, 10);
            question2 = num1 + " x " + num2;
            answer2 = Convert.ToString(num1 * num2);

            num2 = rand.Next(0, 10);
            question3 = num1 + " x " + num2;
            answer3 = Convert.ToString(num1 * num2);

            num2 = rand.Next(0, 10);
            question4 = num1 + " x " + num2;
            answer4 = Convert.ToString(num1 * num2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1Clicked)
            {
                if (button1Num > 0 && button1Num < 5)
                    button1.Text = AssignQuestion(button1Num);
                else
                    button1.Text = AssignAnswer(button1Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button1Num = randomNubmer;
                button1Clicked = true;

                if (button1Num > 0 && button1Num < 5)
                    button1.Text = AssignQuestion(button1Num);
                else
                    button1.Text = AssignAnswer(button1Num);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2Clicked)
            {
                if (button2Num > 0 && button2Num < 5)
                    button2.Text = AssignQuestion(button2Num);
                else
                    button2.Text = AssignAnswer(button2Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button2Num = randomNubmer;
                button2Clicked = true;

                if (button2Num > 0 && button2Num < 5)
                    button2.Text = AssignQuestion(button2Num);
                else
                    button2.Text = AssignAnswer(button2Num);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3Clicked)
            {
                if (button3Num > 0 && button3Num < 5)
                    button3.Text = AssignQuestion(button3Num);
                else
                    button3.Text = AssignAnswer(button3Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button3Num = randomNubmer;
                button3Clicked = true;

                if (button3Num > 0 && button3Num < 5)
                    button3.Text = AssignQuestion(button3Num);
                else
                    button3.Text = AssignAnswer(button3Num);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4Clicked)
            {
                if (button4Num > 0 && button4Num < 5)
                    button4.Text = AssignQuestion(button4Num);
                else
                    button4.Text = AssignAnswer(button4Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button4Num = randomNubmer;
                button4Clicked = true;

                if (button4Num > 0 && button4Num < 5)
                    button4.Text = AssignQuestion(button4Num);
                else
                    button4.Text = AssignAnswer(button4Num);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5Clicked)
            {
                if (button5Num > 0 && button5Num < 5)
                    button5.Text = AssignQuestion(button5Num);
                else
                    button5.Text = AssignAnswer(button5Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button5Num = randomNubmer;
                button5Clicked = true;

                if (button5Num > 0 && button5Num < 5)
                    button5.Text = AssignQuestion(button5Num);
                else
                    button5.Text = AssignAnswer(button5Num);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6Clicked)
            {
                if (button6Num > 0 && button6Num < 5)
                    button6.Text = AssignQuestion(button6Num);
                else
                    button6.Text = AssignAnswer(button6Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button6Num = randomNubmer;
                button6Clicked = true;

                if (button6Num > 0 && button6Num < 5)
                    button6.Text = AssignQuestion(button6Num);
                else
                    button6.Text = AssignAnswer(button6Num);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7Clicked)
            {
                if (button7Num > 0 && button7Num < 5)
                    button7.Text = AssignQuestion(button7Num);
                else
                    button7.Text = AssignAnswer(button7Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button7Num = randomNubmer;
                button7Clicked = true;

                if (button7Num > 0 && button7Num < 5)
                    button7.Text = AssignQuestion(button7Num);
                else
                    button7.Text = AssignAnswer(button7Num);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8Clicked)
            {
                if (button8Num > 0 && button8Num < 5)
                    button8.Text = AssignQuestion(button8Num);
                else
                    button8.Text = AssignAnswer(button8Num);
            }
            else
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button8Num = randomNubmer;
                button8Clicked = true;

                if (button8Num > 0 && button8Num < 5)
                    button8.Text = AssignQuestion(button8Num);
                else
                    button8.Text = AssignAnswer(button8Num);
            }
        }

        private string AssignQuestion(int num)
        {
            string question = "";

            switch(num)
            {
                case 1:
                    question = question1;
                    break;
                case 2:
                    question = question2;
                    break;
                case 3:
                    question = question3;
                    break;
                case 4:
                    question = question4;
                    break;
                default:
                    break;
            }

            return question;
        }

        private string AssignAnswer(int num)
        {
            string answer = "";

            switch (num)
            {
                case 5:
                    answer = answer1;
                    break;
                case 6:
                    answer = answer2;
                    break;
                case 7:
                    answer = answer3;
                    break;
                case 8:
                    answer = answer4;
                    break;
                default:
                    break;
            }

            return answer;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Text = "";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Text = "";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Text = "";
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Text = "";
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Text = "";
        }

        private void button6_MouseLeave(object sender, EventArgs e)
        {
            button6.Text = "";
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Text = "";
        }

        private void button8_MouseLeave(object sender, EventArgs e)
        {
            button8.Text = "";
        }
    }
}
