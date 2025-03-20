namespace WindowsFormsApp2
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            pictureBox1 = new System.Windows.Forms.PictureBox();
            UNameTb = new System.Windows.Forms.TextBox();
            PasswordTb = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            LoginBtn = new System.Windows.Forms.Button();
            ResetBtn = new System.Windows.Forms.Label();
            pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.Teal;
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(294, 734);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.Teal;
            label1.Location = new System.Drawing.Point(554, 39);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(337, 54);
            label1.TabIndex = 1;
            label1.Text = "Employee M S";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new System.Drawing.Point(595, 108);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(235, 202);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // UNameTb
            // 
            UNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            UNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            UNameTb.Location = new System.Drawing.Point(484, 382);
            UNameTb.Name = "UNameTb";
            UNameTb.Size = new System.Drawing.Size(469, 41);
            UNameTb.TabIndex = 3;
            // 
            // PasswordTb
            // 
            PasswordTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            PasswordTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            PasswordTb.Location = new System.Drawing.Point(484, 500);
            PasswordTb.Name = "PasswordTb";
            PasswordTb.Size = new System.Drawing.Size(469, 41);
            PasswordTb.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.Teal;
            label2.Location = new System.Drawing.Point(479, 339);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 29);
            label2.TabIndex = 5;
            label2.Text = "User Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            label3.ForeColor = System.Drawing.Color.Teal;
            label3.Location = new System.Drawing.Point(479, 456);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(128, 29);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // LoginBtn
            // 
            LoginBtn.BackColor = System.Drawing.Color.Teal;
            LoginBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = System.Drawing.Color.White;
            LoginBtn.Location = new System.Drawing.Point(639, 587);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new System.Drawing.Size(168, 49);
            LoginBtn.TabIndex = 7;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += button1_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.AutoSize = true;
            ResetBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = System.Drawing.Color.Teal;
            ResetBtn.Location = new System.Drawing.Point(677, 656);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Size = new System.Drawing.Size(81, 29);
            ResetBtn.TabIndex = 8;
            ResetBtn.Text = "Reset";
            ResetBtn.Click += ResetBtn_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (System.Drawing.Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new System.Drawing.Point(1151, 30);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new System.Drawing.Size(64, 63);
            pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.White;
            ClientSize = new System.Drawing.Size(1245, 734);
            Controls.Add(pictureBox2);
            Controls.Add(ResetBtn);
            Controls.Add(LoginBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(PasswordTb);
            Controls.Add(UNameTb);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            Name = "Login";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox UNameTb;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label ResetBtn;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

