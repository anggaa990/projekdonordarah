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
    public partial class TabelPendonor : Form
    {
        public TabelPendonor()
        {
            InitializeComponent();
            dgvPendonor.CellContentClick += dgvPendonor_CellContentClick;
        }

        private void TabelPendonor_Load(object sender, EventArgs e)
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var query = "SELECT id, nama, jenis_kelamin, golongan_darah, rhesus, tanggal_lahir, alamat, no_hp FROM pendonor ORDER BY id";
                var da = new NpgsqlDataAdapter(query, conn);
                var dt = new DataTable();
                da.Fill(dt);
                dgvPendonor.DataSource = dt;
            }

            if (!dgvPendonor.Columns.Contains("Edit"))
            {
                var editButton = new DataGridViewButtonColumn
                {
                    Name = "Edit",
                    HeaderText = "",
                    Text = "Edit",
                    UseColumnTextForButtonValue = true
                };
                dgvPendonor.Columns.Add(editButton);
            }

            // Tambahkan tombol Hapus jika belum ada
            if (!dgvPendonor.Columns.Contains("Hapus"))
            {
                var deleteButton = new DataGridViewButtonColumn
                {
                    Name = "Hapus",
                    HeaderText = "",
                    Text = "Hapus",
                    UseColumnTextForButtonValue = true
                };
                dgvPendonor.Columns.Add(deleteButton);
            }
        }

        private void dgvPendonor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dgvPendonor.Rows[e.RowIndex];
                int id = Convert.ToInt32(selectedRow.Cells["id"].Value);


                if (dgvPendonor.Columns[e.ColumnIndex].Name == "Hapus")
                {
                    var confirm = MessageBox.Show("Yakin ingin menghapus pendonor ini?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        using (var conn = new NpgsqlConnection(Database.ConnString))
                        {
                            conn.Open();

                            // Cek apakah pendonor masih punya stok darah
                            var checkCmd = new NpgsqlCommand("SELECT COUNT(*) FROM stokdarah WHERE id = @id", conn);
                            checkCmd.Parameters.AddWithValue("id", id);
                            int stokCount = Convert.ToInt32(checkCmd.ExecuteScalar());

                            if (stokCount > 0)
                            {
                                MessageBox.Show("Data pribadi pendonor belum bisa dihapus jika stok darah dari pendonor belum habis.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }

                            // Jika tidak ada stok, hapus pendonor
                            var deleteCmd = new NpgsqlCommand("DELETE FROM pendonor WHERE id = @id", conn);
                            deleteCmd.Parameters.AddWithValue("id", id);
                            deleteCmd.ExecuteNonQuery();
                        }

                        TabelPendonor_Load(null, null); // refresh tabel
                    }
                }



                else if (dgvPendonor.Columns[e.ColumnIndex].Name == "Edit")
                {
                    var row = dgvPendonor.Rows[e.RowIndex];
                    int selectedId = Convert.ToInt32(row.Cells["id"].Value);
                    string nama = row.Cells["nama"].Value.ToString();
                    string jk = row.Cells["jenis_kelamin"].Value.ToString();
                    string gol = row.Cells["golongan_darah"].Value.ToString();
                    string rhesus = row.Cells["rhesus"].Value.ToString();
                    DateTime tglLahir = Convert.ToDateTime(row.Cells["tanggal_lahir"].Value);
                    string alamat = row.Cells["alamat"].Value.ToString();
                    string noHp = row.Cells["no_hp"].Value.ToString(); 

                    var formEdit = new FormEditPendonor(selectedId, nama, jk, gol, rhesus, tglLahir, alamat, noHp);
                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        TabelPendonor_Load(null, null); // refresh
                    }
                }

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKelolaPendonor form = new FormKelolaPendonor();
            this.Hide();
            form.ShowDialog();
        }
    }
}
