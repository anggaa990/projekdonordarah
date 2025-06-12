namespace praktekwinform
{
    partial class FormKelolaPermintaan
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
            txtRumahSakit = new TextBox();
            txtJumlah = new TextBox();
            txtPengaju = new TextBox();
            cbRhesus = new ComboBox();
            cbGolongan = new ComboBox();
            dtpTanggal = new DateTimePicker();
            btnTambah = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label7 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtRumahSakit
            // 
            txtRumahSakit.Location = new Point(179, 27);
            txtRumahSakit.Name = "txtRumahSakit";
            txtRumahSakit.Size = new Size(168, 27);
            txtRumahSakit.TabIndex = 0;
            txtRumahSakit.TextChanged += textBox1_TextChanged;
            // 
            // txtJumlah
            // 
            txtJumlah.Location = new Point(179, 191);
            txtJumlah.Name = "txtJumlah";
            txtJumlah.Size = new Size(168, 27);
            txtJumlah.TabIndex = 1;
            // 
            // txtPengaju
            // 
            txtPengaju.Location = new Point(179, 72);
            txtPengaju.Name = "txtPengaju";
            txtPengaju.Size = new Size(168, 27);
            txtPengaju.TabIndex = 2;
            // 
            // cbRhesus
            // 
            cbRhesus.FormattingEnabled = true;
            cbRhesus.Location = new Point(179, 157);
            cbRhesus.Name = "cbRhesus";
            cbRhesus.Size = new Size(168, 28);
            cbRhesus.Sorted = true;
            cbRhesus.TabIndex = 3;
            // 
            // cbGolongan
            // 
            cbGolongan.FormattingEnabled = true;
            cbGolongan.Location = new Point(179, 115);
            cbGolongan.Name = "cbGolongan";
            cbGolongan.Size = new Size(168, 28);
            cbGolongan.TabIndex = 4;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(179, 233);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(168, 27);
            dtpTanggal.TabIndex = 5;
            // 
            // btnTambah
            // 
            btnTambah.Location = new Point(104, 294);
            btnTambah.Name = "btnTambah";
            btnTambah.Size = new Size(94, 29);
            btnTambah.TabIndex = 6;
            btnTambah.Text = "Simpan";
            btnTambah.UseVisualStyleBackColor = true;
            btnTambah.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(213, 294);
            button2.Name = "button2";
            button2.Size = new Size(134, 29);
            button2.TabIndex = 7;
            button2.Text = "Lihat Permintaan";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 30);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 8;
            label1.Text = "Nama Rumah Sakit";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 79);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 9;
            label2.Text = "Nama Pengaju";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 123);
            label3.Name = "label3";
            label3.Size = new Size(118, 20);
            label3.TabIndex = 10;
            label3.Text = "Golongan Darah";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 165);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 11;
            label4.Text = "Rhesus";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 198);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 12;
            label5.Text = "Jumlah";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 238);
            label6.Name = "label6";
            label6.Size = new Size(139, 20);
            label6.TabIndex = 13;
            label6.Text = "Tanggal Permintaan";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Control;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(btnTambah);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(cbGolongan);
            panel1.Controls.Add(cbRhesus);
            panel1.Controls.Add(txtPengaju);
            panel1.Controls.Add(txtJumlah);
            panel1.Controls.Add(txtRumahSakit);
            panel1.Location = new Point(187, 56);
            panel1.Name = "panel1";
            panel1.Size = new Size(444, 355);
            panel1.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(291, 25);
            label7.Name = "label7";
            label7.Size = new Size(192, 28);
            label7.TabIndex = 15;
            label7.Text = "Tambah Permintaan";
            // 
            // button1
            // 
            button1.Location = new Point(12, 22);
            button1.Name = "button1";
            button1.Size = new Size(66, 31);
            button1.TabIndex = 16;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormKelolaPermintaan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(panel1);
            Name = "FormKelolaPermintaan";
            Text = "FormKelolaPermintaan";
            Load += FormKelolaPermintaan_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtRumahSakit;
        private TextBox txtJumlah;
        private TextBox txtPengaju;
        private ComboBox cbRhesus;
        private ComboBox cbGolongan;
        private DateTimePicker dtpTanggal;
        private Button btnTambah;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Panel panel1;
        private Label label7;
        private Button button1;
    }
}