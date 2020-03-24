namespace MathsClassroom
{
    partial class teacherLoginForm
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.Label();
            this.usernameTxt = new System.Windows.Forms.Label();
            this.passwordEntry = new System.Windows.Forms.TextBox();
            this.usernameEntry = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.goToStudentBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MathsClassroom.Properties.Resources.david_clode_2slBHG3HtdA_unsplash;
            this.pictureBox2.Location = new System.Drawing.Point(12, 107);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(391, 252);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MathsClassroom.Properties.Resources.cooltext345018287788016;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(432, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Do you want to log in as a student?";
            // 
            // passwordTxt
            // 
            this.passwordTxt.AutoSize = true;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordTxt.Location = new System.Drawing.Point(443, 188);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(98, 25);
            this.passwordTxt.TabIndex = 14;
            this.passwordTxt.Text = "Password";
            // 
            // usernameTxt
            // 
            this.usernameTxt.AutoSize = true;
            this.usernameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameTxt.Location = new System.Drawing.Point(439, 151);
            this.usernameTxt.Name = "usernameTxt";
            this.usernameTxt.Size = new System.Drawing.Size(102, 25);
            this.usernameTxt.TabIndex = 13;
            this.usernameTxt.Text = "Username";
            // 
            // passwordEntry
            // 
            this.passwordEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.passwordEntry.Location = new System.Drawing.Point(547, 184);
            this.passwordEntry.Name = "passwordEntry";
            this.passwordEntry.Size = new System.Drawing.Size(194, 30);
            this.passwordEntry.TabIndex = 12;
            // 
            // usernameEntry
            // 
            this.usernameEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.usernameEntry.Location = new System.Drawing.Point(547, 148);
            this.usernameEntry.Name = "usernameEntry";
            this.usernameEntry.Size = new System.Drawing.Size(194, 30);
            this.usernameEntry.TabIndex = 11;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.loginBtn.Location = new System.Drawing.Point(607, 220);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 37);
            this.loginBtn.TabIndex = 10;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // goToStudentBtn
            // 
            this.goToStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.goToStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.goToStudentBtn.Location = new System.Drawing.Point(669, 307);
            this.goToStudentBtn.Name = "goToStudentBtn";
            this.goToStudentBtn.Size = new System.Drawing.Size(81, 29);
            this.goToStudentBtn.TabIndex = 9;
            this.goToStudentBtn.Text = "click here";
            this.goToStudentBtn.UseVisualStyleBackColor = false;
            this.goToStudentBtn.Click += new System.EventHandler(this.goToStudentBtn_Click);
            // 
            // teacherLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 371);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.usernameTxt);
            this.Controls.Add(this.passwordEntry);
            this.Controls.Add(this.usernameEntry);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.goToStudentBtn);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(810, 410);
            this.MinimumSize = new System.Drawing.Size(810, 410);
            this.Name = "teacherLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacherLoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label passwordTxt;
        private System.Windows.Forms.Label usernameTxt;
        private System.Windows.Forms.TextBox passwordEntry;
        private System.Windows.Forms.TextBox usernameEntry;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button goToStudentBtn;
    }
}