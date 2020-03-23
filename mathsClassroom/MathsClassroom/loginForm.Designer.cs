namespace MathsClassroom
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chooseTeacherOrStudentTxt = new System.Windows.Forms.Label();
            this.teacherLoginBtn = new System.Windows.Forms.Button();
            this.studentLoginBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1164, 83);
            this.label1.TabIndex = 0;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathsClassroom.Properties.Resources.cooltext344649375848277;
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1155, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // chooseTeacherOrStudentTxt
            // 
            this.chooseTeacherOrStudentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.chooseTeacherOrStudentTxt.Location = new System.Drawing.Point(18, 154);
            this.chooseTeacherOrStudentTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.chooseTeacherOrStudentTxt.Name = "chooseTeacherOrStudentTxt";
            this.chooseTeacherOrStudentTxt.Size = new System.Drawing.Size(1155, 58);
            this.chooseTeacherOrStudentTxt.TabIndex = 2;
            this.chooseTeacherOrStudentTxt.Text = "Please Choose Whether You Are Signing In As A Teacher Or Student";
            this.chooseTeacherOrStudentTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // teacherLoginBtn
            // 
            this.teacherLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.teacherLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.teacherLoginBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.teacherLoginBtn.Location = new System.Drawing.Point(18, 309);
            this.teacherLoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.teacherLoginBtn.Name = "teacherLoginBtn";
            this.teacherLoginBtn.Size = new System.Drawing.Size(1155, 102);
            this.teacherLoginBtn.TabIndex = 3;
            this.teacherLoginBtn.Text = "I Want To Login As A Teacher";
            this.teacherLoginBtn.UseVisualStyleBackColor = false;
            this.teacherLoginBtn.Click += new System.EventHandler(this.teacherLoginBtn_Click);
            // 
            // studentLoginBtn
            // 
            this.studentLoginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.studentLoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.studentLoginBtn.Location = new System.Drawing.Point(18, 420);
            this.studentLoginBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studentLoginBtn.Name = "studentLoginBtn";
            this.studentLoginBtn.Size = new System.Drawing.Size(1155, 102);
            this.studentLoginBtn.TabIndex = 4;
            this.studentLoginBtn.Text = "I Want To Login as A Student";
            this.studentLoginBtn.UseVisualStyleBackColor = false;
            this.studentLoginBtn.Click += new System.EventHandler(this.studentLoginBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 514);
            this.Controls.Add(this.studentLoginBtn);
            this.Controls.Add(this.teacherLoginBtn);
            this.Controls.Add(this.chooseTeacherOrStudentTxt);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1204, 570);
            this.MinimumSize = new System.Drawing.Size(1204, 570);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "maths classroom";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label chooseTeacherOrStudentTxt;
        private System.Windows.Forms.Button teacherLoginBtn;
        private System.Windows.Forms.Button studentLoginBtn;
    }
}

