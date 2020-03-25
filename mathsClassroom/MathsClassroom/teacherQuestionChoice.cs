﻿using System;
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
        string _studentName;

        public teacherQuestionChoice(string studentName)
        {
            InitializeComponent();
            _studentName = studentName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            teacherNumberQuestions tnq = new teacherNumberQuestions(_studentName);
            tnq.ShowDialog();
        }
    }
}