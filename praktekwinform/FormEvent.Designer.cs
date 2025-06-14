﻿namespace praktekwinform
{
    partial class FormEvent
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
            txtAlamat = new TextBox();
            dtpTanggal = new DateTimePicker();
            txtWaktu = new TextBox();
            txtDeskripsi = new TextBox();
            btnSimpan = new Button();
            btnBatal = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(21, 30);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(216, 27);
            txtAlamat.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(21, 87);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(216, 27);
            dtpTanggal.TabIndex = 1;
            // 
            // txtWaktu
            // 
            txtWaktu.Location = new Point(21, 144);
            txtWaktu.Name = "txtWaktu";
            txtWaktu.Size = new Size(216, 27);
            txtWaktu.TabIndex = 2;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(21, 204);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(216, 27);
            txtDeskripsi.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(21, 251);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(105, 35);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(132, 251);
            btnBatal.Name = "btnBatal";
            btnBatal.Size = new Size(105, 35);
            btnBatal.TabIndex = 5;
            btnBatal.Text = "Batal";
            btnBatal.UseVisualStyleBackColor = true;
            btnBatal.Click += btnBatal_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 7);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Alamat event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 7;
            label2.Text = "Tanggal event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 121);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Waktu event (12:00)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 181);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Deskripsi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(429, 81);
            label5.Name = "label5";
            label5.Size = new Size(139, 28);
            label5.TabIndex = 10;
            label5.Text = "Tambah Event";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnBatal);
            panel1.Controls.Add(btnSimpan);
            panel1.Controls.Add(txtDeskripsi);
            panel1.Controls.Add(txtWaktu);
            panel1.Controls.Add(dtpTanggal);
            panel1.Controls.Add(txtAlamat);
            panel1.Location = new Point(367, 128);
            panel1.Name = "panel1";
            panel1.Size = new Size(261, 318);
            panel1.TabIndex = 11;
            // 
            // button1
            // 
            button1.Location = new Point(23, 25);
            button1.Name = "button1";
            button1.Size = new Size(105, 35);
            button1.TabIndex = 10;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            // 
            // FormEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(976, 577);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(label5);
            Name = "FormEvent";
            Text = "FormEvent";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAlamat;
        private DateTimePicker dtpTanggal;
        private TextBox txtWaktu;
        private TextBox txtDeskripsi;
        private Button btnSimpan;
        private Button btnBatal;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Button button1;
    }
}