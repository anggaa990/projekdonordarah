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
    public partial class FormKelolaEvent : Form
    {
        public FormKelolaEvent()
        {
            InitializeComponent();
            LoadData();
            this.dgvEvents.CellContentClick += new DataGridViewCellEventHandler(this.dgvEvents_CellContentClick);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var formEvent = new FormEvent();
            if (formEvent.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void LoadData()
        {
            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();
                var dt = new DataTable();
                var da = new NpgsqlDataAdapter("SELECT * FROM events ORDER BY tanggal", conn);
                da.Fill(dt);
                dgvEvents.DataSource = dt;
            }

            dgvEvents.Columns["id"].HeaderText = "ID";
            dgvEvents.Columns["alamat"].HeaderText = "Alamat";
            dgvEvents.Columns["tanggal"].HeaderText = "Tanggal";
            dgvEvents.Columns["waktu"].HeaderText = "Waktu";
            dgvEvents.Columns["deskripsi"].HeaderText = "Deskripsi";

            dgvEvents.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (!dgvEvents.Columns.Contains("btnEdit"))
            {
                DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn();
                btnEdit.HeaderText = "Edit";
                btnEdit.Text = "Edit";
                btnEdit.Name = "btnEdit";
                btnEdit.UseColumnTextForButtonValue = true;
                dgvEvents.Columns.Add(btnEdit);
            }

            if (!dgvEvents.Columns.Contains("btnHapus"))
            {
                DataGridViewButtonColumn btnHapus = new DataGridViewButtonColumn();
                btnHapus.HeaderText = "Hapus";
                btnHapus.Text = "Hapus";
                btnHapus.Name = "btnHapus";
                btnHapus.UseColumnTextForButtonValue = true;
                dgvEvents.Columns.Add(btnHapus);
            }

        }

        private void dgvEvents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvEvents.Columns[e.ColumnIndex].Name == "btnEdit")
                {
                    
                    var selectedEvent = new Event
                    {
                        Id = Convert.ToInt32(dgvEvents.Rows[e.RowIndex].Cells["id"].Value),
                        Alamat = dgvEvents.Rows[e.RowIndex].Cells["alamat"].Value.ToString(),
                        Tanggal = Convert.ToDateTime(dgvEvents.Rows[e.RowIndex].Cells["tanggal"].Value),
                        Waktu = dgvEvents.Rows[e.RowIndex].Cells["waktu"].Value.ToString(),
                        Deskripsi = dgvEvents.Rows[e.RowIndex].Cells["deskripsi"].Value.ToString()
                    };

                    var formEdit = new FormEvent();
                    formEdit.EventData = selectedEvent;

                    if (formEdit.ShowDialog() == DialogResult.OK)
                    {
                        LoadData();
                    }
                }
                else if (dgvEvents.Columns[e.ColumnIndex].Name == "btnHapus")
                {
                    int id = Convert.ToInt32(dgvEvents.Rows[e.RowIndex].Cells["id"].Value);
                    var confirm = MessageBox.Show("Hapus event ini?", "Konfirmasi", MessageBoxButtons.YesNo);

                    if (confirm == DialogResult.Yes)
                    {
                        using (var conn = new NpgsqlConnection(Database.ConnString))
                        {
                            conn.Open();
                            var cmd = new NpgsqlCommand("DELETE FROM events WHERE id = @id", conn);
                            cmd.Parameters.AddWithValue("id", id);
                            cmd.ExecuteNonQuery();
                        }

                        LoadData();
                    }
                }
            }
        }

    }
}
