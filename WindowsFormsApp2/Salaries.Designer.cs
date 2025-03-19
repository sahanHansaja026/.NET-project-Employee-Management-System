namespace WindowsFormsApp2
{
    partial class Salaries
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salaries));
            SalaryTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            SalaryList = new Guna.UI2.WinForms.Guna2DataGridView();
            UpdateBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            EmpCb = new System.Windows.Forms.ComboBox();
            DaysTb = new System.Windows.Forms.TextBox();
            PeriodTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)SalaryList).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // SalaryTb
            // 
            SalaryTb.Checked = true;
            SalaryTb.CustomizableEdges = customizableEdges5;
            SalaryTb.FillColor = System.Drawing.Color.White;
            SalaryTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            SalaryTb.ForeColor = System.Drawing.Color.Teal;
            SalaryTb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            SalaryTb.Location = new System.Drawing.Point(12, 733);
            SalaryTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            SalaryTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            SalaryTb.Name = "SalaryTb";
            SalaryTb.ShadowDecoration.CustomizableEdges = customizableEdges6;
            SalaryTb.Size = new System.Drawing.Size(409, 49);
            SalaryTb.TabIndex = 45;
            SalaryTb.Value = new System.DateTime(2025, 3, 16, 10, 42, 48, 320);
            // 
            // SalaryList
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            SalaryList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            SalaryList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            SalaryList.ColumnHeadersHeight = 4;
            SalaryList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            SalaryList.DefaultCellStyle = dataGridViewCellStyle6;
            SalaryList.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            SalaryList.Location = new System.Drawing.Point(542, 349);
            SalaryList.Name = "SalaryList";
            SalaryList.RowHeadersVisible = false;
            SalaryList.RowHeadersWidth = 51;
            SalaryList.Size = new System.Drawing.Size(703, 579);
            SalaryList.TabIndex = 44;
            SalaryList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            SalaryList.ThemeStyle.AlternatingRowsStyle.Font = null;
            SalaryList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            SalaryList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            SalaryList.ThemeStyle.BackColor = System.Drawing.Color.White;
            SalaryList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            SalaryList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            SalaryList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            SalaryList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            SalaryList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            SalaryList.ThemeStyle.HeaderStyle.Height = 4;
            SalaryList.ThemeStyle.ReadOnly = false;
            SalaryList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            SalaryList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            SalaryList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            SalaryList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            SalaryList.ThemeStyle.RowsStyle.Height = 29;
            SalaryList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            SalaryList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = System.Drawing.Color.White;
            UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = System.Drawing.Color.Teal;
            UpdateBtn.Location = new System.Drawing.Point(254, 848);
            UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new System.Drawing.Size(168, 61);
            UpdateBtn.TabIndex = 43;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.Teal;
            AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AddBtn.ForeColor = System.Drawing.Color.White;
            AddBtn.Location = new System.Drawing.Point(12, 848);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(168, 61);
            AddBtn.TabIndex = 42;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Teal;
            label6.Location = new System.Drawing.Point(7, 691);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(180, 29);
            label6.TabIndex = 35;
            label6.Text = "Salary Amount";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Teal;
            label5.Location = new System.Drawing.Point(8, 585);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(91, 29);
            label5.TabIndex = 34;
            label5.Text = "Period";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Teal;
            label4.Location = new System.Drawing.Point(7, 482);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(181, 29);
            label4.TabIndex = 33;
            label4.Text = "Days Attended";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Teal;
            label3.Location = new System.Drawing.Point(8, 373);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(130, 29);
            label3.TabIndex = 31;
            label3.Text = "Employee";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Teal;
            label2.Location = new System.Drawing.Point(533, 267);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(227, 36);
            label2.TabIndex = 30;
            label2.Text = "Manage Salary";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1325, 170);
            panel1.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(365, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(609, 36);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System Verson 0.0.1";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Teal;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 1014);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1325, 41);
            panel2.TabIndex = 36;
            // 
            // EmpCb
            // 
            EmpCb.FormattingEnabled = true;
            EmpCb.Items.AddRange(new object[] { "Male", "Female", "Other" });
            EmpCb.Location = new System.Drawing.Point(12, 413);
            EmpCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EmpCb.Name = "EmpCb";
            EmpCb.Size = new System.Drawing.Size(410, 28);
            EmpCb.TabIndex = 47;
            // 
            // DaysTb
            // 
            DaysTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DaysTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DaysTb.Location = new System.Drawing.Point(12, 526);
            DaysTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DaysTb.Name = "DaysTb";
            DaysTb.Size = new System.Drawing.Size(409, 41);
            DaysTb.TabIndex = 48;
            // 
            // PeriodTb
            // 
            PeriodTb.Checked = true;
            PeriodTb.CustomizableEdges = customizableEdges7;
            PeriodTb.FillColor = System.Drawing.Color.White;
            PeriodTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            PeriodTb.ForeColor = System.Drawing.Color.Teal;
            PeriodTb.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            PeriodTb.Location = new System.Drawing.Point(13, 617);
            PeriodTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            PeriodTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            PeriodTb.Name = "PeriodTb";
            PeriodTb.ShadowDecoration.CustomizableEdges = customizableEdges8;
            PeriodTb.Size = new System.Drawing.Size(409, 49);
            PeriodTb.TabIndex = 49;
            PeriodTb.Value = new System.DateTime(2025, 3, 16, 10, 42, 48, 320);
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Teal;
            label9.Location = new System.Drawing.Point(1074, 199);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(105, 29);
            label9.TabIndex = 70;
            label9.Text = "Log Out";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(1011, 189);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(57, 50);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 69;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Teal;
            label10.Location = new System.Drawing.Point(901, 199);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 29);
            label10.TabIndex = 68;
            label10.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(838, 189);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(57, 50);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 67;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Teal;
            label11.Location = new System.Drawing.Point(675, 199);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(148, 29);
            label11.TabIndex = 66;
            label11.Text = "Department";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Teal;
            label12.Location = new System.Drawing.Point(463, 199);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(130, 29);
            label12.TabIndex = 65;
            label12.Text = "Employee";
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(612, 189);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(57, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 64;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(400, 189);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 63;
            pictureBox2.TabStop = false;
            // 
            // Salaries
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1325, 1055);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(PeriodTb);
            Controls.Add(DaysTb);
            Controls.Add(EmpCb);
            Controls.Add(SalaryTb);
            Controls.Add(SalaryList);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Salaries";
            Text = "Salaries";
            ((System.ComponentModel.ISupportInitialize)SalaryList).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker2;
        private Guna.UI2.WinForms.Guna2DateTimePicker SalaryTb;
        private Guna.UI2.WinForms.Guna2DataGridView SalaryList;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox EmpCb;
        private System.Windows.Forms.TextBox DaysTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker PeriodTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}