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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teacherViewHomework));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.viewHomeworkBtn = new System.Windows.Forms.Button();
            this.setHomeworkBtn = new System.Windows.Forms.Button();
            this.addStudentBtn = new System.Windows.Forms.Button();
            this.lblCompleted = new System.Windows.Forms.Label();
            this.lblNoCompleted = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridNotCompleted = new System.Windows.Forms.DataGridView();
            this.dataGridCompleted = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotCompleted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompleted)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.07749F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.92251F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 356F));
            this.tableLayoutPanel1.Controls.Add(this.viewHomeworkBtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.setHomeworkBtn, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.addStudentBtn, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-2, 661);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1077, 55);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // viewHomeworkBtn
            // 
            this.viewHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.viewHomeworkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.viewHomeworkBtn.Location = new System.Drawing.Point(724, 4);
            this.viewHomeworkBtn.Margin = new System.Windows.Forms.Padding(4);
            this.viewHomeworkBtn.Name = "viewHomeworkBtn";
            this.viewHomeworkBtn.Size = new System.Drawing.Size(349, 47);
            this.viewHomeworkBtn.TabIndex = 2;
            this.viewHomeworkBtn.Text = "View Homework";
            this.viewHomeworkBtn.UseVisualStyleBackColor = false;
            // 
            // setHomeworkBtn
            // 
            this.setHomeworkBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.setHomeworkBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.setHomeworkBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.setHomeworkBtn.Location = new System.Drawing.Point(357, 4);
            this.setHomeworkBtn.Margin = new System.Windows.Forms.Padding(4);
            this.setHomeworkBtn.Name = "setHomeworkBtn";
            this.setHomeworkBtn.Size = new System.Drawing.Size(359, 47);
            this.setHomeworkBtn.TabIndex = 1;
            this.setHomeworkBtn.Text = "Set Homework";
            this.setHomeworkBtn.UseVisualStyleBackColor = false;
            this.setHomeworkBtn.Click += new System.EventHandler(this.setHomeworkBtn_Click);
            // 
            // addStudentBtn
            // 
            this.addStudentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(244)))), ((int)(((byte)(63)))));
            this.addStudentBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.addStudentBtn.Location = new System.Drawing.Point(4, 4);
            this.addStudentBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addStudentBtn.Name = "addStudentBtn";
            this.addStudentBtn.Size = new System.Drawing.Size(345, 47);
            this.addStudentBtn.TabIndex = 0;
            this.addStudentBtn.Text = "Add Student";
            this.addStudentBtn.UseVisualStyleBackColor = false;
            this.addStudentBtn.Click += new System.EventHandler(this.addStudentBtn_Click);
            // 
            // lblCompleted
            // 
            this.lblCompleted.AutoSize = true;
            this.lblCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCompleted.Location = new System.Drawing.Point(91, 408);
            this.lblCompleted.Name = "lblCompleted";
            this.lblCompleted.Size = new System.Drawing.Size(143, 29);
            this.lblCompleted.TabIndex = 3;
            this.lblCompleted.Text = "Completed:";
            // 
            // lblNoCompleted
            // 
            this.lblNoCompleted.AutoSize = true;
            this.lblNoCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblNoCompleted.Location = new System.Drawing.Point(91, 144);
            this.lblNoCompleted.Name = "lblNoCompleted";
            this.lblNoCompleted.Size = new System.Drawing.Size(189, 29);
            this.lblNoCompleted.TabIndex = 4;
            this.lblNoCompleted.Text = "Not Completed:";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblDate.Location = new System.Drawing.Point(761, 144);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(206, 29);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date: 00/00/0000";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(197, 39);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(611, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridNotCompleted
            // 
            this.dataGridNotCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridNotCompleted.Location = new System.Drawing.Point(96, 192);
            this.dataGridNotCompleted.Name = "dataGridNotCompleted";
            this.dataGridNotCompleted.RowTemplate.Height = 24;
            this.dataGridNotCompleted.Size = new System.Drawing.Size(871, 178);
            this.dataGridNotCompleted.TabIndex = 8;
            // 
            // dataGridCompleted
            // 
            this.dataGridCompleted.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCompleted.Location = new System.Drawing.Point(96, 453);
            this.dataGridCompleted.Name = "dataGridCompleted";
            this.dataGridCompleted.RowTemplate.Height = 24;
            this.dataGridCompleted.Size = new System.Drawing.Size(871, 178);
            this.dataGridCompleted.TabIndex = 9;
            this.dataGridCompleted.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridCompleted_RowHeaderMouseDoubleClick);
            // 
            // teacherViewHomework
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 718);
            this.Controls.Add(this.dataGridCompleted);
            this.Controls.Add(this.dataGridNotCompleted);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblNoCompleted);
            this.Controls.Add(this.lblCompleted);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "teacherViewHomework";
            this.Text = "teacherViewHomework";
            this.Load += new System.EventHandler(this.teacherViewHomework_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridNotCompleted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCompleted)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button addStudentBtn;
        private System.Windows.Forms.Button viewHomeworkBtn;
        private System.Windows.Forms.Button setHomeworkBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblCompleted;
        private System.Windows.Forms.Label lblNoCompleted;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DataGridView dataGridNotCompleted;
        private System.Windows.Forms.DataGridView dataGridCompleted;
    }
}