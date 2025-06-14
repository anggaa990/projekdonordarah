﻿namespace praktekwinform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            label1 = new Label();
            btnPendonor = new Button();
            btnEvent = new Button();
            btnPermintaan = new Button();
            btnStokDarah = new Button();
            btnLogout = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            panel2 = new Panel();
            panel4 = new Panel();
            label2 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            dataGridMasuk = new DataGridView();
            dataGridKeluar = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridMasuk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridKeluar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 22);
            label1.Name = "label1";
            label1.Size = new Size(110, 28);
            label1.TabIndex = 5;
            label1.Text = "MainMenu";
            // 
            // btnPendonor
            // 
            btnPendonor.Location = new Point(80, 60);
            btnPendonor.Name = "btnPendonor";
            btnPendonor.Size = new Size(180, 29);
            btnPendonor.TabIndex = 0;
            btnPendonor.Text = "Kelola Pendonor";
            btnPendonor.UseVisualStyleBackColor = true;
            btnPendonor.Click += btnPendonor_Click;
            // 
            // btnEvent
            // 
            btnEvent.Location = new Point(80, 199);
            btnEvent.Name = "btnEvent";
            btnEvent.Size = new Size(180, 29);
            btnEvent.TabIndex = 1;
            btnEvent.Text = "Kelola Event donor";
            btnEvent.UseVisualStyleBackColor = true;
            btnEvent.Click += btnEvent_Click_1;
            // 
            // btnPermintaan
            // 
            btnPermintaan.Location = new Point(80, 154);
            btnPermintaan.Name = "btnPermintaan";
            btnPermintaan.Size = new Size(180, 29);
            btnPermintaan.TabIndex = 2;
            btnPermintaan.Text = "Kelola Permintaan darah";
            btnPermintaan.UseVisualStyleBackColor = true;
            btnPermintaan.Click += btnPermintaan_Click_1;
            // 
            // btnStokDarah
            // 
            btnStokDarah.Location = new Point(80, 106);
            btnStokDarah.Name = "btnStokDarah";
            btnStokDarah.Size = new Size(180, 29);
            btnStokDarah.TabIndex = 3;
            btnStokDarah.Text = "Kelola Stok darah";
            btnStokDarah.UseVisualStyleBackColor = true;
            btnStokDarah.Click += btnStokDarah_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(80, 290);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(180, 29);
            btnLogout.TabIndex = 7;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(btnEvent);
            panel1.Controls.Add(btnPermintaan);
            panel1.Controls.Add(panel7);
            panel1.Controls.Add(btnStokDarah);
            panel1.Controls.Add(panel6);
            panel1.Controls.Add(btnPendonor);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnLogout);
            panel1.Location = new Point(12, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(284, 478);
            panel1.TabIndex = 8;
            panel1.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(29, 294);
            panel5.Name = "panel5";
            panel5.Size = new Size(45, 25);
            panel5.TabIndex = 11;
            // 
            // panel7
            // 
            panel7.BackgroundImage = (Image)resources.GetObject("panel7.BackgroundImage");
            panel7.BackgroundImageLayout = ImageLayout.Stretch;
            panel7.Location = new Point(29, 199);
            panel7.Name = "panel7";
            panel7.Size = new Size(45, 29);
            panel7.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.BackgroundImage = (Image)resources.GetObject("panel6.BackgroundImage");
            panel6.BackgroundImageLayout = ImageLayout.Stretch;
            panel6.Location = new Point(29, 158);
            panel6.Name = "panel6";
            panel6.Size = new Size(45, 25);
            panel6.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(29, 110);
            panel2.Name = "panel2";
            panel2.Size = new Size(45, 25);
            panel2.TabIndex = 8;
            // 
            // panel4
            // 
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Location = new Point(29, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(45, 25);
            panel4.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(597, 53);
            label2.Name = "label2";
            label2.Size = new Size(85, 28);
            label2.TabIndex = 10;
            label2.Text = "Laporan";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridMasuk
            // 
            dataGridMasuk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridMasuk.Location = new Point(382, 159);
            dataGridMasuk.Name = "dataGridMasuk";
            dataGridMasuk.RowHeadersWidth = 51;
            dataGridMasuk.Size = new Size(551, 112);
            dataGridMasuk.TabIndex = 11;
            dataGridMasuk.CellContentClick += dataGridMasuk_CellContentClick;
            // 
            // dataGridKeluar
            // 
            dataGridKeluar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridKeluar.Location = new Point(382, 333);
            dataGridKeluar.Name = "dataGridKeluar";
            dataGridKeluar.RowHeadersWidth = 51;
            dataGridKeluar.Size = new Size(551, 112);
            dataGridKeluar.TabIndex = 12;
            dataGridKeluar.CellContentClick += dataGridKeluar_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(380, 136);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 13;
            label3.Text = "Darah masuk :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(382, 310);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 14;
            label4.Text = "Darah keluar :";
            // 
            // FormMainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(982, 577);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridKeluar);
            Controls.Add(dataGridMasuk);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FormMainMenu";
            Text = "Mainmenu";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridMasuk).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridKeluar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btnPendonor;
        private Button btnEvent;
        private Button btnPermintaan;
        private Button btnStokDarah;
        private Button btnLogout;
        private Panel panel1;
        private Panel panel5;
        private Panel panel7;
        private Panel panel6;
        private Panel panel4;
        private Panel panel2;
        private Label label2;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridMasuk;
        private DataGridView dataGridKeluar;
        private Label label3;
        private Label label4;
    }
}