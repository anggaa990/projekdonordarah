using Npgsql;
using praktekwinform.Model;
using System;
using System.Data;
using System.Windows.Forms;

namespace praktekwinform
{
    public partial class TabelPermintaan : Form
    {
        public TabelPermintaan()
        {
            InitializeComponent();
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.Columns.Clear(); // Pastikan kolom aksi tidak dobel

            var permintaan = new PermintaanDarah();
            var dt = permintaan.GetAll();

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Data tidak ditemukan di tabel permintaan_darah.");
            }

            dataGridView1.DataSource = dt;
            TambahTombolAksi();
        }


        private void TambahTombolAksi()
        {

            if (dataGridView1.Columns["btnSetujui"] == null)
            {
                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "Aksi",
                    Text = "Setujui",
                    Name = "btnSetujui",
                    UseColumnTextForButtonValue = true
                });

                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "",
                    Text = "Tolak",
                    Name = "btnTolak",
                    UseColumnTextForButtonValue = true
                });

                dataGridView1.Columns.Add(new DataGridViewButtonColumn()
                {
                    HeaderText = "",
                    Text = "Hapus",
                    Name = "btnHapus",
                    UseColumnTextForButtonValue = true
                });
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Gunakan nama kolom hasil alias di SQL (AS id)
            try
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                var permintaan = new PermintaanDarah();

                string kolom = dataGridView1.Columns[e.ColumnIndex].Name;

                if (kolom == "btnSetujui")
                {
                    if (permintaan.Setujui(id))
                        MessageBox.Show("Permintaan disetujui dan stok dikurangi.");
                    else
                        MessageBox.Show("Stok darah tidak mencukupi!");
                }
                else if (kolom == "btnTolak")
                {
                    if (permintaan.Tolak(id))
                        MessageBox.Show("Permintaan ditolak.");
                    else
                        MessageBox.Show("Gagal menolak permintaan.");
                }
                else if (kolom == "btnHapus")
                {
                    var konfirmasi = MessageBox.Show("Yakin ingin menghapus?", "Konfirmasi", MessageBoxButtons.YesNo);
                    if (konfirmasi == DialogResult.Yes)
                    {
                        if (permintaan.Hapus(id))
                            MessageBox.Show("Permintaan dihapus.");
                        else
                            MessageBox.Show("Gagal menghapus permintaan.");
                    }
                }

                LoadData(); // Refresh data setiap aksi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormKelolaPermintaan form = new FormKelolaPermintaan();
            this.Hide();
            form.ShowDialog();
        }
    }
}
