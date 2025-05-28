namespace praktekwinform
{
    partial class register
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
            linkLabel1 = new LinkLabel();
            label5 = new Label();
            btnRegister = new Button();
            label4 = new Label();
            label3 = new Label();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(376, 339);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(46, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(332, 319);
            label5.Name = "label5";
            label5.Size = new Size(136, 20);
            label5.TabIndex = 17;
            label5.Text = "Sudah punya akun?";
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Gainsboro;
            btnRegister.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(351, 276);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(94, 29);
            btnRegister.TabIndex = 16;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(273, 199);
            label4.Name = "label4";
            label4.Size = new Size(157, 20);
            label4.TabIndex = 15;
            label4.Text = "Masukkan password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(273, 140);
            label3.Name = "label3";
            label3.Size = new Size(158, 20);
            label3.TabIndex = 14;
            label3.Text = "Masukkan username";
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(270, 222);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 30);
            txtPassword.TabIndex = 13;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(270, 165);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 30);
            txtUsername.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 20);
            label2.Name = "label2";
            label2.Size = new Size(144, 23);
            label2.TabIndex = 11;
            label2.Text = "Selamat Datang";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(332, 85);
            label1.Name = "label1";
            label1.Size = new Size(121, 23);
            label1.TabIndex = 10;
            label1.Text = "New Account";
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(linkLabel1);
            Controls.Add(label5);
            Controls.Add(btnRegister);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkLabel1;
        private Label label5;
        private Button btnRegister;
        private Label label4;
        private Label label3;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}