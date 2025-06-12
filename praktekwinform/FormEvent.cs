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
    public partial class FormEvent : Form
    {
        public Event EventData { get; set; }
        public FormEvent()
        {
            InitializeComponent();
            this.Load += FormEvent_Load;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Validasi input kosong
            if (string.IsNullOrWhiteSpace(txtAlamat.Text) ||
                string.IsNullOrWhiteSpace(txtWaktu.Text) ||
                string.IsNullOrWhiteSpace(txtDeskripsi.Text))
            {
                MessageBox.Show("Semua data harus diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                NpgsqlCommand cmd;

                if (EventData == null)
                {
                    cmd = new NpgsqlCommand("INSERT INTO events (alamat, tanggal, waktu, deskripsi) VALUES (@alamat, @tanggal, @waktu, @deskripsi)", conn);
                }
                else
                {
                    cmd = new NpgsqlCommand("UPDATE events SET alamat = @alamat, tanggal = @tanggal, waktu = @waktu, deskripsi = @deskripsi WHERE id = @id", conn);
                    cmd.Parameters.AddWithValue("id", EventData.Id);
                }

                cmd.Parameters.AddWithValue("alamat", txtAlamat.Text.Trim());
                cmd.Parameters.AddWithValue("tanggal", dtpTanggal.Value.Date);
                cmd.Parameters.AddWithValue("waktu", txtWaktu.Text.Trim());
                cmd.Parameters.AddWithValue("deskripsi", txtDeskripsi.Text.Trim());

                cmd.ExecuteNonQuery();
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEvent_Load(object sender, EventArgs e)
        {
            if (EventData != null)
            {
                txtAlamat.Text = EventData.Alamat;
                dtpTanggal.Value = EventData.Tanggal;
                txtWaktu.Text = EventData.Waktu;
                txtDeskripsi.Text = EventData.Deskripsi;
            }
        }

    }
}
