namespace praktekwinform
{
    partial class FormKelolaStokDarah
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
            label1 = new Label();
            comboBoxPendonor = new ComboBox();
            label2 = new Label();
            txtGolonganDarah = new TextBox();
            label3 = new Label();
            txtRhesus = new TextBox();
            label4 = new Label();
            dtTanggalMasuk = new DateTimePicker();
            label5 = new Label();
            dtTanggalExp = new DateTimePicker();
            label6 = new Label();
            txtJumlahKantong = new TextBox();
            btnSimpan = new Button();
            button1 = new Button();
            button2 = new Button();
            panel1 = new Panel();
            label7 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 4);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 0;
            label1.Text = "Pendonor";
            // 
            // comboBoxPendonor
            // 
            comboBoxPendonor.FormattingEnabled = true;
            comboBoxPendonor.Location = new Point(56, 27);
            comboBoxPendonor.Name = "comboBoxPendonor";
            comboBoxPendonor.Size = new Size(209, 28);
            comboBoxPendonor.TabIndex = 1;
            comboBoxPendonor.SelectedIndexChanged += comboBoxPendonor_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 75);
            label2.Name = "label2";
            label2.Size = new Size(116, 20);
            label2.TabIndex = 2;
            label2.Text = "Golongan darah";
            // 
            // txtGolonganDarah
            // 
            txtGolonganDarah.Location = new Point(56, 108);
            txtGolonganDarah.Name = "txtGolonganDarah";
            txtGolonganDarah.ReadOnly = true;
            txtGolonganDarah.Size = new Size(116, 27);
            txtGolonganDarah.TabIndex = 3;
            txtGolonganDarah.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(195, 75);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 4;
            label3.Text = "Rhesus";
            // 
            // txtRhesus
            // 
            txtRhesus.Location = new Point(178, 108);
            txtRhesus.Name = "txtRhesus";
            txtRhesus.ReadOnly = true;
            txtRhesus.Size = new Size(87, 27);
            txtRhesus.TabIndex = 5;
            txtRhesus.TextChanged += txtRhesus_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(109, 147);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 6;
            label4.Text = "Tanggal masuk";
            // 
            // dtTanggalMasuk
            // 
            dtTanggalMasuk.Location = new Point(56, 170);
            dtTanggalMasuk.Name = "dtTanggalMasuk";
            dtTanggalMasuk.Size = new Size(209, 27);
            dtTanggalMasuk.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(99, 211);
            label5.Name = "label5";
            label5.Size = new Size(138, 20);
            label5.TabIndex = 8;
            label5.Text = "Tanggal Kadaluarsa";
            label5.Click += label5_Click;
            // 
            // dtTanggalExp
            // 
            dtTanggalExp.Location = new Point(56, 234);
            dtTanggalExp.Name = "dtTanggalExp";
            dtTanggalExp.Size = new Size(209, 27);
            dtTanggalExp.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(109, 274);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 10;
            label6.Text = "Jumlah kantong";
            // 
            // txtJumlahKantong
            // 
            txtJumlahKantong.Location = new Point(56, 297);
            txtJumlahKantong.Name = "txtJumlahKantong";
            txtJumlahKantong.Size = new Size(209, 27);
            txtJumlahKantong.TabIndex = 11;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(56, 341);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(103, 29);
            btnSimpan.TabIndex = 12;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(165, 341);
            button1.Name = "button1";
            button1.Size = new Size(100, 29);
            button1.TabIndex = 13;
            button1.Text = "Lihat Stok";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(27, 27);
            button2.Name = "button2";
            button2.Size = new Size(107, 31);
            button2.TabIndex = 14;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonFace;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtJumlahKantong);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(dtTanggalExp);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dtTanggalMasuk);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtRhesus);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtGolonganDarah);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(comboBoxPendonor);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(345, 114);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 387);
            panel1.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(431, 66);
            label7.Name = "label7";
            label7.Size = new Size(151, 28);
            label7.TabIndex = 16;
            label7.Text = "Masukkan Stok";
            // 
            // FormKelolaStokDarah
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(987, 571);
            Controls.Add(label7);
            Controls.Add(panel1);
            Controls.Add(button2);
            Name = "FormKelolaStokDarah";
            Text = "FormKelolaStokDarah";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxPendonor;
        private Label label2;
        private TextBox txtGolonganDarah;
        private Label label3;
        private TextBox txtRhesus;
        private Label label4;
        private DateTimePicker dtTanggalMasuk;
        private Label label5;
        private DateTimePicker dtTanggalExp;
        private Label label6;
        private TextBox txtJumlahKantong;
        private Button btnSimpan;
        private Button button1;
        private Button button2;
        private Panel panel1;
        private Label label7;
    }
}