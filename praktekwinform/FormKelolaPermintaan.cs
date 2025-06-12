using Npgsql;
using praktekwinform.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktekwinform
{
    public partial class FormKelolaPermintaan : Form
    {
        public FormKelolaPermintaan()
        {
            InitializeComponent();
        }

        private void FormKelolaPermintaan_Load(object sender, EventArgs e)
        {
            // Isi ComboBox Golongan Darah
            cbGolongan.Items.AddRange(new string[] { "A", "B", "AB", "O" });

            // Isi ComboBox Rhesus
            cbRhesus.Items.AddRange(new string[] { "Positif", "Negatif" });
            cbGolongan.SelectedIndex = 0;
            cbRhesus.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtRumahSakit.Text) ||
        string.IsNullOrWhiteSpace(txtPengaju.Text) ||
        string.IsNullOrWhiteSpace(txtJumlah.Text))
            {
                MessageBox.Show("Semua kolom harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi input jumlah harus angka
            if (!int.TryParse(txtJumlah.Text.Trim(), out int jumlahDarah))
            {
                MessageBox.Show("Jumlah harus berupa angka.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var permintaan = new PermintaanDarah
            {
                NamaRS = txtRumahSakit.Text.Trim(),
                NamaPengaju = txtPengaju.Text.Trim(),
                GolonganDarah = cbGolongan.Text,
                Rhesus = cbRhesus.Text,
                Jumlah = jumlahDarah,
                TanggalPermintaan = dtpTanggal.Value,
                Status = "Menunggu"
            };

            bool berhasil = permintaan.SimpanSaja();

            if (berhasil)
                MessageBox.Show("Permintaan berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Gagal menyimpan permintaan.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var tabelPermintaan = new TabelPermintaan();
            this.Hide();
            tabelPermintaan.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string username = "Admin";
            FormMainMenu form = new FormMainMenu(username);
            this.Hide();
            form.ShowDialog();
        }
    }
}
