namespace praktekwinform
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
            SuspendLayout();
            // 
            // txtAlamat
            // 
            txtAlamat.Location = new Point(283, 91);
            txtAlamat.Name = "txtAlamat";
            txtAlamat.Size = new Size(216, 27);
            txtAlamat.TabIndex = 0;
            // 
            // dtpTanggal
            // 
            dtpTanggal.Location = new Point(283, 148);
            dtpTanggal.Name = "dtpTanggal";
            dtpTanggal.Size = new Size(216, 27);
            dtpTanggal.TabIndex = 1;
            // 
            // txtWaktu
            // 
            txtWaktu.Location = new Point(283, 205);
            txtWaktu.Name = "txtWaktu";
            txtWaktu.Size = new Size(216, 27);
            txtWaktu.TabIndex = 2;
            // 
            // txtDeskripsi
            // 
            txtDeskripsi.Location = new Point(283, 265);
            txtDeskripsi.Name = "txtDeskripsi";
            txtDeskripsi.Size = new Size(216, 27);
            txtDeskripsi.TabIndex = 3;
            // 
            // btnSimpan
            // 
            btnSimpan.Location = new Point(283, 312);
            btnSimpan.Name = "btnSimpan";
            btnSimpan.Size = new Size(105, 35);
            btnSimpan.TabIndex = 4;
            btnSimpan.Text = "Simpan";
            btnSimpan.UseVisualStyleBackColor = true;
            btnSimpan.Click += button1_Click;
            // 
            // btnBatal
            // 
            btnBatal.Location = new Point(394, 312);
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
            label1.Location = new Point(283, 68);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 6;
            label1.Text = "Alamat event";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(283, 125);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 7;
            label2.Text = "Tanggal event";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(283, 182);
            label3.Name = "label3";
            label3.Size = new Size(139, 20);
            label3.TabIndex = 8;
            label3.Text = "Waktu event (12:00)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(283, 242);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 9;
            label4.Text = "Deskripsi";
            // 
            // FormEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBatal);
            Controls.Add(btnSimpan);
            Controls.Add(txtDeskripsi);
            Controls.Add(txtWaktu);
            Controls.Add(dtpTanggal);
            Controls.Add(txtAlamat);
            Name = "FormEvent";
            Text = "FormEvent";
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
    }
}