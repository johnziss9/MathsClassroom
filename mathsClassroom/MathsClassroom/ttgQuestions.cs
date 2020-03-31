using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MathsClassroom
{
    public partial class ttgQuestions : Form
    {
        Random random;
        List<int> buttons = new List<int>();
        int randomNubmer;

        int previousButton = 0;
        int previousValue = 0;
        int currentButton = 0;
        int value = 0;

        int button1Num;
        int button2Num;
        int button3Num;
        int button4Num;
        int button5Num;
        int button6Num;
        int button7Num;
        int button8Num;

        // These are to check if the button is already been pressed
        bool button1Clicked = false;
        bool button2Clicked = false;
        bool button3Clicked = false;
        bool button4Clicked = false;
        bool button5Clicked = false;
        bool button6Clicked = false;
        bool button7Clicked = false;
        bool button8Clicked = false;

        int clickNo = 1;

        string question1;
        string question2;
        string question3;
        string question4;
        int question1Answer;
        int question2Answer;
        int question3Answer;
        int question4Answer;
        int answer1;
        int answer2;
        int answer3;
        int answer4;

        List<int> buttonsNotFound = new List<int>();
        List<int> buttonsFound = new List<int>();

        bool gameOver = false;

        public ttgQuestions()
        {
            InitializeComponent();

            // Fill in the list
            for (int i = 1; i <= 8; i++)
            {
                buttons.Add(i);
                buttonsNotFound.Add(i);
            }

            GenerateQandA();
        }

        private void GenerateQandA()
        {
            List<int> numbers = new List<int>();

            Random rand = new Random();
            int num1 = 3;
            int num2 = 0;

            num2 = rand.Next(0, 10);
            numbers.Add(num2);
            question1 = num1 + " x " + num2;

            answer1 = num1 * num2;
            question1Answer = answer1;

            num2 = rand.Next(0, 10);
            while (numbers.Contains(num2))
                num2 = rand.Next(0, 10);
            question2 = num1 + " x " + num2;
            numbers.Add(num2);

            answer2 = num1 * num2;
            question2Answer = answer2;

            num2 = rand.Next(0, 10);
            while (numbers.Contains(num2))
                num2 = rand.Next(0, 10);
            question3 = num1 + " x " + num2;
            numbers.Add(num2);

            answer3 = num1 * num2;
            question3Answer = answer3;

            num2 = rand.Next(0, 10);
            while (numbers.Contains(num2))
                num2 = rand.Next(0, 10);
            question4 = num1 + " x " + num2;
            numbers.Add(num2);

            answer4 = num1 * num2;
            question4Answer = answer4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!button1Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button1Num = randomNubmer;
                button1Clicked = true;
                Button1Logic();
                previousValue = value;
                previousButton = 1;
            }
            else
            {
                Button1Logic();
                previousValue = value;
                previousButton = 1;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!button2Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button2Num = randomNubmer;
                button2Clicked = true;
                Button2Logic();
                previousValue = value;
                previousButton = 2;
            }
            else
            {
                Button2Logic();
                previousValue = value;
                previousButton = 2;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!button3Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button3Num = randomNubmer;
                button3Clicked = true;
                Button3Logic();
                previousValue = value;
                previousButton = 3;
            }
            else
            {
                Button3Logic();
                previousValue = value;
                previousButton = 3;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!button4Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button4Num = randomNubmer;
                button4Clicked = true;
                Button4Logic();
                previousValue = value;
                previousButton = 4;
            }
            else
            {
                Button4Logic();
                previousValue = value;
                previousButton = 4;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!button5Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button5Num = randomNubmer;
                button5Clicked = true;
                Button5Logic();
                previousValue = value;
                previousButton = 5;
            }
            else
            {
                Button5Logic();
                previousValue = value;
                previousButton = 5;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!button6Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button6Num = randomNubmer;
                button6Clicked = true;
                Button6Logic();
            }
            else
            {
                Button6Logic();
                previousValue = value;
                previousButton = 6;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!button7Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button7Num = randomNubmer;
                button7Clicked = true;
                Button7Logic();
            }
            else
            {
                Button7Logic();
                previousValue = value;
                previousButton = 7;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!button8Clicked)
            {
                random = new Random();
                int buttonsCount = buttons.Count - 1;
                randomNubmer = buttons[random.Next(0, buttonsCount)];
                buttons.Remove(randomNubmer);
                button8Num = randomNubmer;
                button8Clicked = true;
                Button8Logic();
                previousValue = value;
                previousButton = 8;
            }
            else
            {
                Button8Logic();
                previousValue = value;
                previousButton = 8;
            }

            if (gameOver)
                MessageBox.Show("Congratulations, You've completed the game!");
        }

        private string AssignQuestion(int num)
        {
            string question = "";

            switch(num)
            {
                case 1:
                    question = question1;
                    value = question1Answer;
                    break;
                case 2:
                    question = question2;
                    value = question2Answer;
                    break;
                case 3:
                    question = question3;
                    value = question3Answer;
                    break;
                case 4:
                    question = question4;
                    value = question4Answer;
                    break;
                default:
                    break;
            }

            return question;
        }

        private int AssignAnswer(int num)
        {
            int answer = -1;

            switch (num)
            {
                case 5:
                    answer = answer1;
                    value = answer1;
                    break;
                case 6:
                    answer = answer2;
                    value = answer2;
                    break;
                case 7:
                    answer = answer3;
                    value = answer3;
                    break;
                case 8:
                    answer = answer4;
                    value = answer4;
                    break;
                default:
                    break;
            }

            return answer;
        }

        private void Button1Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(1);

                if (button1Num > 0 && button1Num < 5)
                    button1.Text = AssignQuestion(button1Num);
                else
                    button1.Text = AssignAnswer(button1Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button1Num > 0 && button1Num < 5)
                    button1.Text = AssignQuestion(button1Num);
                else
                    button1.Text = AssignAnswer(button1Num).ToString();

                currentButton = 1;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button2Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(2);

                if (button2Num > 0 && button2Num < 5)
                    button2.Text = AssignQuestion(button2Num);
                else
                    button2.Text = AssignAnswer(button2Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button2Num > 0 && button2Num < 5)
                    button2.Text = AssignQuestion(button2Num);
                else
                    button2.Text = AssignAnswer(button2Num).ToString();

                currentButton = 2;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button3Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(3);

                if (button3Num > 0 && button3Num < 5)
                    button3.Text = AssignQuestion(button3Num);
                else
                    button3.Text = AssignAnswer(button3Num).ToString();
            
                clickNo = 2;
            }
            else
            {
                if (button3Num > 0 && button3Num < 5)
                    button3.Text = AssignQuestion(button3Num);
                else
                    button3.Text = AssignAnswer(button3Num).ToString();

                currentButton = 3;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button4Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(4);

                if (button4Num > 0 && button4Num < 5)
                    button4.Text = AssignQuestion(button4Num);
                else
                    button4.Text = AssignAnswer(button4Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button4Num > 0 && button4Num < 5)
                    button4.Text = AssignQuestion(button4Num);
                else
                    button4.Text = AssignAnswer(button4Num).ToString();

                currentButton = 4;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button5Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(5);

                if (button5Num > 0 && button5Num < 5)
                    button5.Text = AssignQuestion(button5Num);
                else
                    button5.Text = AssignAnswer(button5Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button5Num > 0 && button5Num < 5)
                    button5.Text = AssignQuestion(button5Num);
                else
                    button5.Text = AssignAnswer(button5Num).ToString();

                currentButton = 5;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button6Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(6);

                if (button6Num > 0 && button6Num < 5)
                    button6.Text = AssignQuestion(button6Num);
                else
                    button6.Text = AssignAnswer(button6Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button6Num > 0 && button6Num < 5)
                    button6.Text = AssignQuestion(button6Num);
                else
                    button6.Text = AssignAnswer(button6Num).ToString();

                currentButton = 6;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button7Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(7);

                if (button7Num > 0 && button7Num < 5)
                    button7.Text = AssignQuestion(button7Num);
                else
                    button7.Text = AssignAnswer(button7Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button7Num > 0 && button7Num < 5)
                    button7.Text = AssignQuestion(button7Num);
                else
                    button7.Text = AssignAnswer(button7Num).ToString();

                currentButton = 7;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private void Button8Logic()
        {
            if (clickNo == 1)
            {
                ClearAllOtherButtons(8);

                if (button8Num > 0 && button8Num < 5)
                    button8.Text = AssignQuestion(button8Num);
                else
                    button8.Text = AssignAnswer(button8Num).ToString();

                clickNo = 2;
            }
            else
            {
                if (button8Num > 0 && button8Num < 5)
                    button8.Text = AssignQuestion(button8Num);
                else
                    button8.Text = AssignAnswer(button8Num).ToString();

                currentButton = 8;

                if (CheckMatch())
                    clickNo = 1;
                else
                    clickNo = 1;
            }
        }

        private bool CheckMatch()
        {
            bool matched = false;

            if (previousValue == value)
            {
                buttonsNotFound.Remove(previousButton);
                buttonsNotFound.Remove(currentButton);

                buttonsFound.Add(previousButton);
                buttonsFound.Add(currentButton);

                if (buttonsFound.Count == 8)
                    gameOver = true;

                matched = true;
            }
                
            else
                matched = false;

            return matched;
        }

        private void ChangePreviousButtonText(int previousButton)
        {
            switch (previousButton)
            {
                case 1:
                    button1.Text = "";
                    break;
                case 2:
                    button2.Text = "";
                    break;
                case 3:
                    button3.Text = "";
                    break;
                case 4:
                    button4.Text = "";
                    break;
                case 5:
                    button5.Text = "";
                    break;
                case 6:
                    button6.Text = "";
                    break;
                case 7:
                    button7.Text = "";
                    break;
                case 8:
                    button8.Text = "";
                    break;
            }
        }

        private void ClearAllOtherButtons(int buttonPressed)
        {
            foreach (var button in Controls.OfType<Button>())
            {
                int buttonNumber = Convert.ToInt32(button.Name.Substring(6, 1));

                if (buttonsNotFound.Contains(buttonNumber) && buttonNumber != buttonPressed)
                    button.Text = "";

                if (buttonsFound.Contains(buttonNumber))
                    button.Enabled = false;
            }
        }
    }
}
