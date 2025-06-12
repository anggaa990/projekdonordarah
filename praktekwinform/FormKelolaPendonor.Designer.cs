namespace praktekwinform
{
    partial class FormKelolaPendonor
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
            txtNama = new TextBox();
            cbJenisKelamin = new ComboBox();
            cbGolonganDarah = new ComboBox();
            dtpTanggalLahir = new DateTimePicker();
            txtAlamat = new TextBox();
            txtNoHP = new TextBox();
            btnSimpan = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            cbRhesus = new ComboBox();
            panel1 = new Panel();
            label8 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtNama
            // 
            txtNama.Location = new Point(21, 29);
            txtNama.Name = "txtNama";
            txtNama.Size = new Size(250, 27);
            txtNama.TabIndex = 0;
            txtNama.TextChanged += textBox1_TextChanged;
            // 
            // cbJenisKelamin
            // 
            cbJenisKelamin.FormattingEnabled = true;
            cbJenisKelamin.Location = new Point(21, 80);
            cbJenisKelamin.Name = "cbJenisKelamin";
            cbJenisKelamin.Size = new Size(250, 28);
            cbJenisKelamin.TabIndex = 1;
            cbJenisKelamin.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbGolonganDarah
            // 
            cbGolonganDarah.FormattingEnabled = true;
            cbGolonganDarah.Location = new Point(21, 129);
            cbGolonganDarah.Name = "cbGolonganDarah";
            cbGolonganDarah.Size = new Size(116, 28);
            cbGolonganDarah.TabIndex = 2;
            cbGolonganDarah.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // dtpTanggalLahir
            // 
            dtpTanggalLahir.Location = new Point(21, 183);
            dtpTanggalLahir.Name = "dtpTanggalLahir";
            dtpTanggalLahir.Size = new Size(250, 27);
            dtpTanggalLahir.TabIndex = 3;
            dtpTanggalLahir.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(21, 236);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(250, 27);
            txtAlamat.TabIndex = 4;
            txtAlamat.TextChanged += textBox2_TextChanged;
            // 
            // txtNoHP
            // 
            txtNoHP.Location = new Point(21, 290);
            txtNoHP.Name = "txtNoHP";
            txtNoHP.Size = new Size(250, 27);
            txtNoHP.TabIndex = 5;
            txtNoHP.TextChanged += textBox3_TextChanged;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(21, 323);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(94, 29);
            btnSimpan.TabIndex = 6;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // button4
            // 
            button4.Location = new Point(116, 323);
            button4.Name = "button4";
            button4.Size = new Size(155, 29);
            button4.TabIndex = 9;
            button4.Text = "Lihat Data";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 6);
            label1.Name = "label1";
            label1.Size = new Size(116, 20);
            label1.TabIndex = 10;
            label1.Text = "Nama Pendonor";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 59);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 11;
            label2.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 111);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 12;
            label3.Text = "Golongan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 160);
            label4.Name = "label4";
            label4.Size = new Size(97, 20);
            label4.TabIndex = 13;
            label4.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 213);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 14;
            label5.Text = "Alamat";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 267);
            label6.Name = "label6";
            label6.Size = new Size(79, 20);
            label6.TabIndex = 15;
            label6.Text = "Nomor HP";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(185, 111);
            label7.Name = "label7";
            label7.Size = new Size(54, 20);
            label7.TabIndex = 16;
            label7.Text = "Rhesus";
            // 
            // cbRhesus
            // 
            cbRhesus.FormattingEnabled = true;
            cbRhesus.Location = new Point(155, 129);
            cbRhesus.Name = "cbRhesus";
            cbRhesus.Size = new Size(116, 28);
            cbRhesus.TabIndex = 17;
            cbRhesus.SelectedIndexChanged += comboBox3_SelectedIndexChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(cbRhesus);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtNoHP);
            panel1.Controls.Add(txtAlamat);
            panel1.Controls.Add(dtpTanggalLahir);
            panel1.Controls.Add(cbGolonganDarah);
            panel1.Controls.Add(cbJenisKelamin);
            panel1.Controls.Add(txtNama);
            panel1.Location = new Point(369, 122);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 366);
            panel1.TabIndex = 18;
            panel1.Paint += panel1_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(423, 79);
            label8.Name = "label8";
            label8.Size = new Size(185, 31);
            label8.TabIndex = 19;
            label8.Text = "Kelola Pendonor";
            // 
            // button1
            // 
            button1.Location = new Point(12, 14);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 20;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormKelolaPendonor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(981, 574);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(panel1);
            Name = "FormKelolaPendonor";
            Text = "FormKelolaPendonor";
            Load += FormKelolaPendonor_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNama;
        private ComboBox cbJenisKelamin;
        private ComboBox cbGolonganDarah;
        private DateTimePicker dtpTanggalLahir;
        private TextBox txtAlamat;
        private TextBox txtNoHP;
        private Button btnSimpan;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ComboBox cbRhesus;
        private Panel panel1;
        private Label label8;
        private Button button1;
    }
}