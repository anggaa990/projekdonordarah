namespace praktekwinform
{
    partial class FormMainMenu
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
            btnPendonor = new Button();
            btnEvent = new Button();
            btnPermintaan = new Button();
            btnStokDarah = new Button();
            btnLaporan = new Button();
            label1 = new Label();
            lblWelcome = new Label();
            btnLogout = new Button();
            SuspendLayout();
            // 
            // btnPendonor
            // 
            btnPendonor.Location = new Point(310, 113);
            btnPendonor.Name = "btnPendonor";
            btnPendonor.Size = new Size(180, 29);
            btnPendonor.TabIndex = 0;
            btnPendonor.Text = "Kelola Pendonor";
            btnPendonor.UseVisualStyleBackColor = true;
            btnPendonor.Click += btnPendonor_Click;
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(310, 255);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(180, 29);
            btnEvent.TabIndex = 1;
            btnEvent.Text = "Kelola Event donor";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click_1;
            // 
            // btnPermintaan
            // 
            btnPermintaan.Location = new Point(310, 210);
            btnPermintaan.Name = "btnPermintaan";
            btnPermintaan.Size = new Size(180, 29);
            btnPermintaan.TabIndex = 2;
            btnPermintaan.Text = "Kelola Permintaan darah";
            btnPermintaan.UseVisualStyleBackColor = true;
            btnPermintaan.Click += btnPermintaan_Click_1;
            // 
            // btnStokDarah
            // 
            btnStokDarah.Location = new Point(310, 161);
            btnStokDarah.Name = "btnStokDarah";
            btnStokDarah.Size = new Size(180, 29);
            btnStokDarah.TabIndex = 3;
            btnStokDarah.Text = "Kelola Stok darah";
            btnStokDarah.UseVisualStyleBackColor = true;
            btnStokDarah.Click += btnStokDarah_Click_1;
            // 
            // btnLaporan
            // 
            btnLaporan.Location = new Point(310, 300);
            btnLaporan.Name = "btnLaporan";
            btnLaporan.Size = new Size(180, 29);
            btnLaporan.TabIndex = 4;
            btnLaporan.Text = "Laporan";
            btnLaporan.UseVisualStyleBackColor = true;
            btnLaporan.Click += btnLaporan_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(345, 69);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 5;
            label1.Text = "MainMenu";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = Color.Red;
            lblWelcome.Location = new Point(47, 19);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(42, 20);
            lblWelcome.TabIndex = 6;
            lblWelcome.Text = "label";
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(310, 348);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(lblWelcome);
            Controls.Add(label1);
            Controls.Add(btnLaporan);
            Controls.Add(btnStokDarah);
            Controls.Add(btnPermintaan);
            Controls.Add(btnEvent);
            Controls.Add(btnPendonor);
            Name = "FormMainMenu";
            Text = "Mainmenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPendonor;
        private Button btnEvent;
        private Button btnPermintaan;
        private Button btnStokDarah;
        private Button btnLaporan;
        private Label label1;
        private Label lblWelcome;
        private Button btnLogout;
    }
}