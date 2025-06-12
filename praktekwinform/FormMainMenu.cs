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
    public partial class FormMainMenu : Form
    {
        private string username;

        public FormMainMenu(string username)
        {
            InitializeComponent();
            this.username = username;
            this.Load += FormMainMenu_Load;
        }

        private void btnPendonor_Click(object sender, EventArgs e)
        {
            FormKelolaPendonor form = new FormKelolaPendonor();
            this.Hide();
            form.ShowDialog();
        }

        private void btnStokDarah_Click_1(object sender, EventArgs e)
        {
            FormKelolaStokDarah form = new FormKelolaStokDarah();
            this.Hide();
            form.ShowDialog();
        }

        private void btnPermintaan_Click_1(object sender, EventArgs e)
        {
            FormKelolaPermintaan form = new FormKelolaPermintaan();
            this.Hide();
            form.ShowDialog();
        }

        private void btnEvent_Click_1(object sender, EventArgs e)
        {
            FormKelolaEvent form = new FormKelolaEvent();
            this.Hide();
            form.ShowDialog();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            this.Close();
            Application.Restart();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            LoadLaporanDarah();
        }

        private void LoadLaporanDarah()
        {
            var laporan = new LaporanDarah();

            try
            {
                dataGridMasuk.DataSource = laporan.GetDarahMasuk();
                dataGridKeluar.DataSource = laporan.GetDarahKeluar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gagal memuat laporan: " + ex.Message);
            }
        }

        private void dataGridKeluar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridMasuk_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
