namespace MathsClassroom
{
    partial class teacherSetHomework
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherSetHomework));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewHomeworkBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.setHomeworkBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.64595F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.35405F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 367F));
            this.tableLayoutPanel1.Controls.Add(this.viewHomeworkBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.addStudentBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.setHomeworkBtn, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 502);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1069, 54);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewHomeworkBtn
            // 
            this.viewHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.viewHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.viewHomeworkBtn.Location = new System.Drawing.Point(705, 4);
            this.viewHomeworkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.viewHomeworkBtn.Name = "viewHomeworkBtn";
            this.viewHomeworkBtn.Size = new System.Drawing.Size(352, 46);
            this.viewHomeworkBtn.TabIndex = 5;
            this.viewHomeworkBtn.Text = "View Homework";
            this.viewHomeworkBtn.UseVisualStyleBackColor = false;
            this.viewHomeworkBtn.Click += new System.EventHandler(this.viewHomeworkBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addStudentBtn.Location = new System.Drawing.Point(4, 4);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(326, 46);
            this.addStudentBtn.TabIndex = 3;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // setHomeworkBtn
            // 
            this.setHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.setHomeworkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.setHomeworkBtn.Location = new System.Drawing.Point(338, 4);
            this.setHomeworkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.setHomeworkBtn.Name = "setHomeworkBtn";
            this.setHomeworkBtn.Size = new System.Drawing.Size(359, 46);
            this.setHomeworkBtn.TabIndex = 4;
            this.setHomeworkBtn.Text = "Set Homework";
            this.setHomeworkBtn.UseVisualStyleBackColor = false;
            this.setHomeworkBtn.Click += new System.EventHandler(this.setHomeworkBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 244);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(711, 267);
            this.select.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(100, 28);
            this.select.TabIndex = 4;
            this.select.Text = "select";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(273, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(538, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // teacherSetHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.select);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "teacherSetHomework";
            this.Text = "teacherSetHomework";
            this.Load += new System.EventHandler(this.teacherSetHomework_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button viewHomeworkBtn;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button setHomeworkBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button select;
    }
}