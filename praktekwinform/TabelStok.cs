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
    public partial class TabelStok : Form
    {
        public TabelStok()
        {
            InitializeComponent();
            dataGridViewStok.CellContentClick += dataGridViewStok_CellContentClick;
            LoadData();
        }

        private void LoadData()
        {
            var listStok = new List<StokDarah>();

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var cmd = new NpgsqlCommand("SELECT id_stok, golongan_darah, rhesus, jumlah_kantong, tanggal_masuk, tanggal_exp FROM stokdarah", conn);
                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    listStok.Add(new StokDarah
                    {
                        Id = reader.GetInt32(0),
                        GolonganDarah = reader.GetString(1),
                        Rhesus = reader.GetString(2),
                        JumlahKantong = reader.GetInt32(3),
                        TanggalMasuk = reader.GetDateTime(4),
                        TanggalExp = reader.GetDateTime(5)
                    });
                }
            }

            dataGridViewStok.DataSource = listStok;

            if (dataGridViewStok.Columns["Edit"] == null)
            {
                var editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewStok.Columns.Add(editButton);
            }

            if (dataGridViewStok.Columns["Hapus"] == null)
            {
                var deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Hapus",
                    Text = "Hapus",
                    UseColumnTextForButtonValue = true
                };
                dataGridViewStok.Columns.Add(deleteButton);
            }
        }




        private void dataGridViewStok_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var id = ((List<StokDarah>)dataGridViewStok.DataSource)[e.RowIndex].Id;

                if (dataGridViewStok.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        using (var conn = new NpgsqlConnection(Database.ConnString))
                        {
                            conn.Open();
                            var cmd = new NpgsqlCommand("DELETE FROM stokdarah WHERE id_stok = @id", conn);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        LoadData();
                    }
                }
                else if (dataGridViewStok.Columns[e.ColumnIndex].Name == "Edit")
                {
                    string input = Microsoft.VisualBasic.Interaction.InputBox("Masukkan jumlah kantong baru:", "Edit Jumlah", "", -1, -1);
                    if (int.TryParse(input, out int jumlahBaru))
                    {
                        using (var conn = new NpgsqlConnection(Database.ConnString))
                        {
                            conn.Open();
                            var cmd = new NpgsqlCommand("UPDATE stokdarah SET jumlah_kantong = @jumlah WHERE id_stok = @id", conn);
                            cmd.Parameters.AddWithValue("jumlah", jumlahBaru);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Jumlah tidak valid!");
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKelolaStokDarah form = new FormKelolaStokDarah();
            this.Hide();
            form.ShowDialog();
        }
    }
}
