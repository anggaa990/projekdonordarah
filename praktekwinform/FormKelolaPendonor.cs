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
    public partial class FormKelolaPendonor : Form
    {
        public FormKelolaPendonor()
        {
            InitializeComponent();
            cbJenisKelamin.Items.AddRange(new string[] { "Laki-laki", "Perempuan" });
            cbGolonganDarah.Items.AddRange(new string[] { "A", "B", "AB", "O" });
            cbRhesus.Items.AddRange(new string[] { "Positif", "Negatif" });


            cbJenisKelamin.SelectedIndex = -1;
            cbGolonganDarah.SelectedIndex = -1;
            cbRhesus.SelectedIndex = -1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TabelPendonor formData = new TabelPendonor();
            this.Hide();
            formData.ShowDialog();
        }

        private void ClearForm()
        {
            txtNama.Clear();
            cbJenisKelamin.SelectedIndex = -1;
            cbGolonganDarah.SelectedIndex = -1;
            cbRhesus.SelectedIndex = -1;
            dtpTanggalLahir.Value = DateTime.Today;
            txtAlamat.Clear();
            txtNoHP.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNama.Text) || cbJenisKelamin.SelectedIndex == -1 ||
        cbGolonganDarah.SelectedIndex == -1 || cbRhesus.SelectedIndex == -1)
            {
                MessageBox.Show("Harap lengkapi semua data.");
                return;
            }

            Pendonorbase pendonor = new Pendonor
            {
                Nama = txtNama.Text,
                JenisKelamin = cbJenisKelamin.Text,
                GolonganDarah = cbGolonganDarah.Text,
                Rhesus = cbRhesus.Text,
                TanggalLahir = dtpTanggalLahir.Value.Date,
                Alamat = txtAlamat.Text,
                NoHP = txtNoHP.Text
            };

            pendonor.Simpan();  // Memanggil Simpan menggunakan polymorphism

            MessageBox.Show("Data berhasil disimpan.");
            ClearForm();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormKelolaPendonor_Load(object sender, EventArgs e)
        {

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
