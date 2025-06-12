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
    public partial class FormKelolaStokDarah : Form
    {
        private List<Pendonor> pendonors = new List<Pendonor>();

        public FormKelolaStokDarah()
        {
            InitializeComponent();
            LoadPendonor();
        }

        private void LoadPendonor()
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id, nama, golongan_darah, rhesus FROM pendonor", conn);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    var p = new Pendonor
                    {
                        Id = reader.GetInt32(0),
                        Nama = reader.GetString(1),
                        GolonganDarah = reader.GetString(2),
                        Rhesus = reader.GetString(3)
                    };
                    pendonors.Add(p);
                }
                comboBoxPendonor.DataSource = pendonors;
                comboBoxPendonor.DisplayMember = "Nama";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi pendonor harus dipilih
            if (comboBoxPendonor.SelectedItem == null)
            {
                MessageBox.Show("Silakan pilih pendonor terlebih dahulu.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jumlah tidak boleh kosong
            if (string.IsNullOrWhiteSpace(txtJumlahKantong.Text))
            {
                MessageBox.Show("Jumlah kantong darah wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validasi jumlah harus angka
            if (!int.TryParse(txtJumlahKantong.Text.Trim(), out int jumlahKantong))
            {
                MessageBox.Show("Jumlah kantong darah harus berupa angka.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selected = (Pendonor)comboBoxPendonor.SelectedItem;

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("INSERT INTO stokdarah (id, golongan_darah, rhesus, jumlah_kantong, tanggal_masuk, tanggal_exp) VALUES (@id, @gd, @rh, @jumlah, @masuk, @exp)", conn);
                cmd.Parameters.AddWithValue("@id", selected.Id);
                cmd.Parameters.AddWithValue("@gd", selected.GolonganDarah);
                cmd.Parameters.AddWithValue("@rh", selected.Rhesus);
                cmd.Parameters.AddWithValue("@jumlah", jumlahKantong);
                cmd.Parameters.AddWithValue("@masuk", dtTanggalMasuk.Value);
                cmd.Parameters.AddWithValue("@exp", dtTanggalExp.Value);
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Data stok berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void txtRhesus_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxPendonor_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (Pendonor)comboBoxPendonor.SelectedItem;
            txtGolonganDarah.Text = selected.GolonganDarah;
            txtRhesus.Text = selected.Rhesus;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TabelStok form = new TabelStok();
            this.Hide();
            form.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = "Admin";
            FormMainMenu form = new FormMainMenu(username);
            this.Hide();
            form.ShowDialog();
        }
    }
}
