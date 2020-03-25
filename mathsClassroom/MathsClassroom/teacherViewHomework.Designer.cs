namespace MathsClassroom
{
    partial class teacherViewHomework
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.setHomeworkBtn = new System.Windows.Forms.Button();
            this.viewHomeworkBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.07749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.92251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 265F));
            this.tableLayoutPanel1.Controls.Add(this.viewHomeworkBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.setHomeworkBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addStudentBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 408);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(808, 45);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.addStudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addStudentBtn.Location = new System.Drawing.Point(3, 3);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(260, 39);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // setHomeworkBtn
            // 
            this.setHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.setHomeworkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.setHomeworkBtn.Location = new System.Drawing.Point(269, 3);
            this.setHomeworkBtn.Name = "setHomeworkBtn";
            this.setHomeworkBtn.Size = new System.Drawing.Size(270, 39);
            this.setHomeworkBtn.TabIndex = 1;
            this.setHomeworkBtn.Text = "Set Homework";
            this.setHomeworkBtn.UseVisualStyleBackColor = false;
            this.setHomeworkBtn.Click += new System.EventHandler(this.viewHomeworkBtn_Click);
            // 
            // viewHomeworkBtn
            // 
            this.viewHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.viewHomeworkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.viewHomeworkBtn.Location = new System.Drawing.Point(545, 3);
            this.viewHomeworkBtn.Name = "viewHomeworkBtn";
            this.viewHomeworkBtn.Size = new System.Drawing.Size(260, 39);
            this.viewHomeworkBtn.TabIndex = 2;
            this.viewHomeworkBtn.Text = "View Homework";
            this.viewHomeworkBtn.UseVisualStyleBackColor = false;
            this.viewHomeworkBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // teacherViewHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 451);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "teacherViewHomework";
            this.Text = "teacherViewHomework";
            this.Load += new System.EventHandler(this.teacherViewHomework_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button viewHomeworkBtn;
        private System.Windows.Forms.Button setHomeworkBtn;
    }
}