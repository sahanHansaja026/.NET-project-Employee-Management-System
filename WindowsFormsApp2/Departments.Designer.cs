namespace WindowsFormsApp2
{
    partial class Deparment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Deparment));
            DepList = new Guna.UI2.WinForms.Guna2DataGridView();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            DepNameTb = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            panel1 = new System.Windows.Forms.Panel();
            label4 = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            EmpLbl = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            label9 = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            EditBtn = new System.Windows.Forms.Button();
            AddBtn = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DepList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // DepList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            DepList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            DepList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            DepList.ColumnHeadersHeight = 4;
            DepList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            DepList.DefaultCellStyle = dataGridViewCellStyle3;
            DepList.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            DepList.Location = new System.Drawing.Point(559, 376);
            DepList.Name = "DepList";
            DepList.RowHeadersVisible = false;
            DepList.RowHeadersWidth = 51;
            DepList.Size = new System.Drawing.Size(703, 349);
            DepList.TabIndex = 45;
            DepList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            DepList.ThemeStyle.AlternatingRowsStyle.Font = null;
            DepList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            DepList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            DepList.ThemeStyle.BackColor = System.Drawing.Color.White;
            DepList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            DepList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            DepList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            DepList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            DepList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            DepList.ThemeStyle.HeaderStyle.Height = 4;
            DepList.ThemeStyle.ReadOnly = false;
            DepList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            DepList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            DepList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            DepList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            DepList.ThemeStyle.RowsStyle.Height = 29;
            DepList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            DepList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            DepList.CellContentClick += DepList_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(179, 215);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(144, 144);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 44;
            pictureBox1.TabStop = false;
            // 
            // DepNameTb
            // 
            DepNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DepNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DepNameTb.Location = new System.Drawing.Point(17, 416);
            DepNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DepNameTb.Name = "DepNameTb";
            DepNameTb.Size = new System.Drawing.Size(409, 41);
            DepNameTb.TabIndex = 32;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Teal;
            label3.Location = new System.Drawing.Point(12, 376);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(224, 29);
            label3.TabIndex = 31;
            label3.Text = "Department Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Teal;
            label2.Location = new System.Drawing.Point(629, 261);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(315, 36);
            label2.TabIndex = 30;
            label2.Text = "Manage Departments";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(501, 58);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(609, 36);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System Verson 0.0.1";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1343, 170);
            panel1.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Teal;
            label4.Location = new System.Drawing.Point(905, 314);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(196, 29);
            label4.TabIndex = 46;
            label4.Text = "Department List";
            label4.Click += label4_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(368, 178);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 47;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(580, 178);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(57, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 48;
            pictureBox3.TabStop = false;
            // 
            // EmpLbl
            // 
            EmpLbl.AutoSize = true;
            EmpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            EmpLbl.ForeColor = System.Drawing.Color.Teal;
            EmpLbl.Location = new System.Drawing.Point(431, 188);
            EmpLbl.Name = "EmpLbl";
            EmpLbl.Size = new System.Drawing.Size(130, 29);
            EmpLbl.TabIndex = 49;
            EmpLbl.Text = "Employee";
            EmpLbl.Click += EmpLbl_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Teal;
            label6.Location = new System.Drawing.Point(643, 188);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(148, 29);
            label6.TabIndex = 50;
            label6.Text = "Department";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Teal;
            label7.Location = new System.Drawing.Point(869, 188);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(86, 29);
            label7.TabIndex = 52;
            label7.Text = "Salary";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(806, 178);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(57, 50);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 51;
            pictureBox4.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Teal;
            label9.Location = new System.Drawing.Point(1042, 188);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(105, 29);
            label9.TabIndex = 54;
            label9.Text = "Log Out";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(979, 178);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(57, 50);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 53;
            pictureBox5.TabStop = false;
            // 
            // EditBtn
            // 
            EditBtn.BackColor = System.Drawing.Color.White;
            EditBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            EditBtn.ForeColor = System.Drawing.Color.Teal;
            EditBtn.Location = new System.Drawing.Point(258, 530);
            EditBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new System.Drawing.Size(168, 61);
            EditBtn.TabIndex = 56;
            EditBtn.Text = "Update";
            EditBtn.UseVisualStyleBackColor = false;
            EditBtn.Click += EditBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.Teal;
            AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AddBtn.ForeColor = System.Drawing.Color.White;
            AddBtn.Location = new System.Drawing.Point(6, 530);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(168, 61);
            AddBtn.TabIndex = 55;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.Red;
            button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(125, 599);
            button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(168, 61);
            button1.TabIndex = 57;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Deparment
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1343, 828);
            Controls.Add(button1);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label7);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(EmpLbl);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label4);
            Controls.Add(DepList);
            Controls.Add(pictureBox1);
            Controls.Add(DepNameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Deparment";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Departments";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)DepList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView DepList;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox DepNameTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label EmpLbl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button button1;
    }
}