namespace WindowsFormsApp2
{
    partial class Employees
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employees));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            EmpNameTb = new System.Windows.Forms.TextBox();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            panel2 = new System.Windows.Forms.Panel();
            label7 = new System.Windows.Forms.Label();
            DailySalTb = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            GenCb = new System.Windows.Forms.ComboBox();
            DepCb = new System.Windows.Forms.ComboBox();
            AddBtn = new System.Windows.Forms.Button();
            UpdateBtn = new System.Windows.Forms.Button();
            EmployeeList = new Guna.UI2.WinForms.Guna2DataGridView();
            DOBTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            JDateTb = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label9 = new System.Windows.Forms.Label();
            pictureBox5 = new System.Windows.Forms.PictureBox();
            label10 = new System.Windows.Forms.Label();
            pictureBox4 = new System.Windows.Forms.PictureBox();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            pictureBox3 = new System.Windows.Forms.PictureBox();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            Delete = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
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
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(497, 57);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(609, 36);
            label1.TabIndex = 0;
            label1.Text = "Employee Management System Verson 0.0.1";
            label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Teal;
            label2.Location = new System.Drawing.Point(616, 241);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(276, 36);
            label2.TabIndex = 1;
            label2.Text = "Manage Employee";
            label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Teal;
            label3.Location = new System.Drawing.Point(7, 276);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(206, 29);
            label3.TabIndex = 6;
            label3.Text = "Employee Name";
            // 
            // EmpNameTb
            // 
            EmpNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            EmpNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            EmpNameTb.Location = new System.Drawing.Point(12, 316);
            EmpNameTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new System.Drawing.Size(409, 41);
            EmpNameTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label4.ForeColor = System.Drawing.Color.Teal;
            label4.Location = new System.Drawing.Point(6, 385);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(224, 29);
            label4.TabIndex = 8;
            label4.Text = "Employee Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label5.ForeColor = System.Drawing.Color.Teal;
            label5.Location = new System.Drawing.Point(7, 488);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(272, 29);
            label5.TabIndex = 10;
            label5.Text = "Employee Department";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label6.ForeColor = System.Drawing.Color.Teal;
            label6.Location = new System.Drawing.Point(6, 594);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(162, 29);
            label6.TabIndex = 12;
            label6.Text = "Date Of Birth";
            // 
            // panel2
            // 
            panel2.BackColor = System.Drawing.Color.Teal;
            panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            panel2.Location = new System.Drawing.Point(0, 1014);
            panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new System.Drawing.Size(1325, 41);
            panel2.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label7.ForeColor = System.Drawing.Color.Teal;
            label7.Location = new System.Drawing.Point(7, 696);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(123, 29);
            label7.TabIndex = 15;
            label7.Text = "Join Date";
            label7.Click += label7_Click;
            // 
            // DailySalTb
            // 
            DailySalTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            DailySalTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            DailySalTb.Location = new System.Drawing.Point(12, 854);
            DailySalTb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DailySalTb.Name = "DailySalTb";
            DailySalTb.Size = new System.Drawing.Size(409, 41);
            DailySalTb.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label8.ForeColor = System.Drawing.Color.Teal;
            label8.Location = new System.Drawing.Point(7, 802);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(275, 29);
            label8.TabIndex = 17;
            label8.Text = "Employee Daily Salary";
            // 
            // GenCb
            // 
            GenCb.FormattingEnabled = true;
            GenCb.Items.AddRange(new object[] { "Male", "Female", "Other" });
            GenCb.Location = new System.Drawing.Point(11, 436);
            GenCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            GenCb.Name = "GenCb";
            GenCb.Size = new System.Drawing.Size(410, 28);
            GenCb.TabIndex = 16;
            // 
            // DepCb
            // 
            DepCb.FormattingEnabled = true;
            DepCb.Location = new System.Drawing.Point(12, 548);
            DepCb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            DepCb.Name = "DepCb";
            DepCb.Size = new System.Drawing.Size(409, 28);
            DepCb.TabIndex = 20;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = System.Drawing.Color.Teal;
            AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AddBtn.ForeColor = System.Drawing.Color.White;
            AddBtn.Location = new System.Drawing.Point(0, 933);
            AddBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new System.Drawing.Size(168, 61);
            AddBtn.TabIndex = 23;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += button1_Click;
            // 
            // UpdateBtn
            // 
            UpdateBtn.BackColor = System.Drawing.Color.White;
            UpdateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UpdateBtn.ForeColor = System.Drawing.Color.Teal;
            UpdateBtn.Location = new System.Drawing.Point(252, 933);
            UpdateBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new System.Drawing.Size(168, 61);
            UpdateBtn.TabIndex = 24;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.Click += UpdateBtn_Click;
            // 
            // EmployeeList
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            EmployeeList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            EmployeeList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeeList.ColumnHeadersHeight = 4;
            EmployeeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            EmployeeList.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeeList.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            EmployeeList.Location = new System.Drawing.Point(531, 289);
            EmployeeList.Name = "EmployeeList";
            EmployeeList.RowHeadersVisible = false;
            EmployeeList.RowHeadersWidth = 51;
            EmployeeList.Size = new System.Drawing.Size(703, 579);
            EmployeeList.TabIndex = 26;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            EmployeeList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            EmployeeList.ThemeStyle.BackColor = System.Drawing.Color.White;
            EmployeeList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(100, 88, 255);
            EmployeeList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            EmployeeList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            EmployeeList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            EmployeeList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeList.ThemeStyle.HeaderStyle.Height = 4;
            EmployeeList.ThemeStyle.ReadOnly = false;
            EmployeeList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            EmployeeList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            EmployeeList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            EmployeeList.ThemeStyle.RowsStyle.Height = 29;
            EmployeeList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(231, 229, 255);
            EmployeeList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(71, 69, 94);
            EmployeeList.CellContentClick += EmployeeList_CellContentClick;
            // 
            // DOBTb
            // 
            DOBTb.Checked = true;
            DOBTb.CustomizableEdges = customizableEdges1;
            DOBTb.FillColor = System.Drawing.Color.White;
            DOBTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            DOBTb.ForeColor = System.Drawing.Color.Teal;
            DOBTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            DOBTb.Location = new System.Drawing.Point(11, 636);
            DOBTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            DOBTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            DOBTb.Name = "DOBTb";
            DOBTb.ShadowDecoration.CustomizableEdges = customizableEdges2;
            DOBTb.Size = new System.Drawing.Size(409, 49);
            DOBTb.TabIndex = 27;
            DOBTb.Value = new System.DateTime(2025, 3, 16, 10, 42, 48, 320);
            // 
            // JDateTb
            // 
            JDateTb.Checked = true;
            JDateTb.CustomizableEdges = customizableEdges3;
            JDateTb.FillColor = System.Drawing.Color.White;
            JDateTb.Font = new System.Drawing.Font("Segoe UI", 9F);
            JDateTb.ForeColor = System.Drawing.Color.Teal;
            JDateTb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            JDateTb.Location = new System.Drawing.Point(12, 739);
            JDateTb.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            JDateTb.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            JDateTb.Name = "JDateTb";
            JDateTb.ShadowDecoration.CustomizableEdges = customizableEdges4;
            JDateTb.Size = new System.Drawing.Size(409, 49);
            JDateTb.TabIndex = 28;
            JDateTb.Value = new System.DateTime(2025, 3, 16, 10, 42, 48, 320);
            // 
            // label9
            // 
            label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label9.ForeColor = System.Drawing.Color.Teal;
            label9.Location = new System.Drawing.Point(1053, 186);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(105, 29);
            label9.TabIndex = 62;
            label9.Text = "Log Out";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox5.Image = (System.Drawing.Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new System.Drawing.Point(990, 176);
            pictureBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new System.Drawing.Size(57, 50);
            pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 61;
            pictureBox5.TabStop = false;
            // 
            // label10
            // 
            label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label10.ForeColor = System.Drawing.Color.Teal;
            label10.Location = new System.Drawing.Point(880, 186);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(86, 29);
            label10.TabIndex = 60;
            label10.Text = "Salary";
            label10.Click += label10_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox4.Image = (System.Drawing.Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new System.Drawing.Point(817, 176);
            pictureBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new System.Drawing.Size(57, 50);
            pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 59;
            pictureBox4.TabStop = false;
            // 
            // label11
            // 
            label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label11.ForeColor = System.Drawing.Color.Teal;
            label11.Location = new System.Drawing.Point(654, 186);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(148, 29);
            label11.TabIndex = 58;
            label11.Text = "Department";
            // 
            // label12
            // 
            label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label12.ForeColor = System.Drawing.Color.Teal;
            label12.Location = new System.Drawing.Point(442, 186);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(130, 29);
            label12.TabIndex = 57;
            label12.Text = "Employee";
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox3.Image = (System.Drawing.Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new System.Drawing.Point(591, 176);
            pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(57, 50);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 56;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(379, 176);
            pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(57, 50);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 55;
            pictureBox2.TabStop = false;
            // 
            // Delete
            // 
            Delete.BackColor = System.Drawing.Color.Red;
            Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Delete.ForeColor = System.Drawing.Color.White;
            Delete.Location = new System.Drawing.Point(798, 933);
            Delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Delete.Name = "Delete";
            Delete.Size = new System.Drawing.Size(168, 61);
            Delete.TabIndex = 63;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = false;
            Delete.Click += Delete_Click;
            // 
            // Employees
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1325, 1055);
            Controls.Add(Delete);
            Controls.Add(label9);
            Controls.Add(pictureBox5);
            Controls.Add(label10);
            Controls.Add(pictureBox4);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(JDateTb);
            Controls.Add(DOBTb);
            Controls.Add(EmployeeList);
            Controls.Add(UpdateBtn);
            Controls.Add(AddBtn);
            Controls.Add(DepCb);
            Controls.Add(GenCb);
            Controls.Add(DailySalTb);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(EmpNameTb);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "Employees";
            WindowState = System.Windows.Forms.FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeList).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EmpNameTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DailySalTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox GenCb;
        private System.Windows.Forms.ComboBox DepCb;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeList;
        private Guna.UI2.WinForms.Guna2DateTimePicker DOBTb;
        private Guna.UI2.WinForms.Guna2DateTimePicker JDateTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Delete;
    }
}