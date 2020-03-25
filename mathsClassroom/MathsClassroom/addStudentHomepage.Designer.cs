namespace MathsClassroom
{
    partial class addStudentHomepage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addStudentHomepage));
            this.viewHomeworkBtn = new System.Windows.Forms.Button();
            this.setHomeworkBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // viewHomeworkBtn
            // 
            this.viewHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.viewHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.viewHomeworkBtn.Location = new System.Drawing.Point(730, 4);
            this.viewHomeworkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewHomeworkBtn.Name = "viewHomeworkBtn";
            this.viewHomeworkBtn.Size = new System.Drawing.Size(341, 40);
            this.viewHomeworkBtn.TabIndex = 5;
            this.viewHomeworkBtn.Text = "View Homework";
            this.viewHomeworkBtn.UseVisualStyleBackColor = false;
            this.viewHomeworkBtn.Click += new System.EventHandler(this.viewHomeworkBtn_Click);
            // 
            // setHomeworkBtn
            // 
            this.setHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.setHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.setHomeworkBtn.Location = new System.Drawing.Point(358, 4);
            this.setHomeworkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setHomeworkBtn.Name = "setHomeworkBtn";
            this.setHomeworkBtn.Size = new System.Drawing.Size(360, 40);
            this.setHomeworkBtn.TabIndex = 4;
            this.setHomeworkBtn.Text = "Set Homework";
            this.setHomeworkBtn.UseVisualStyleBackColor = false;
            this.setHomeworkBtn.Click += new System.EventHandler(this.setHomeworkBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addStudentBtn.Location = new System.Drawing.Point(4, 4);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(346, 40);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.71795F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.28205F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 349F));
            this.tableLayoutPanel1.Controls.Add(this.setHomeworkBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.viewHomeworkBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addStudentBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 507);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1076, 48);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1072, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "Enter student email:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(296, 268);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(469, 37);
            this.textBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(463, 359);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // addStudentHomepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addStudentHomepage";
            this.Text = "addStudentHomepage";
            this.Load += new System.EventHandler(this.addStudentHomepage_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button viewHomeworkBtn;
        private System.Windows.Forms.Button setHomeworkBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}