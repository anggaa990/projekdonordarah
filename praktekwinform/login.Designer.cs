namespace praktekwinform
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            label4 = new Label();
            btnLogin = new Button();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(159, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 23);
            label1.TabIndex = 19;
            label1.Text = "LOGIN";
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(71, 118);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(244, 30);
            txtUsername.TabIndex = 20;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(71, 175);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(244, 30);
            txtPassword.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(74, 93);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 22;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(74, 152);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 23;
            label4.Text = "Password";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Gainsboro;
            btnLogin.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(152, 229);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(94, 29);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += button2_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(133, 272);
            label5.Name = "label5";
            label5.Size = new Size(137, 20);
            label5.TabIndex = 25;
            label5.Text = "Belum punya akun?";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(167, 292);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(63, 20);
            linkLabel1.TabIndex = 26;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Register";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(207, 51);
            panel1.Name = "panel1";
            panel1.Size = new Size(380, 333);
            panel1.TabIndex = 27;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(809, 477);
            Controls.Add(panel1);
            Name = "login";
            Text = "login";
            Load += login_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private Label label4;
        private Button btnLogin;
        private Label label5;
        private LinkLabel linkLabel1;
        private Panel panel1;
    }
}