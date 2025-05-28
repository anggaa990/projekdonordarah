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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           
        }
        private void txtUsername_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var registerForm = new login();
            this.Hide();
            registerForm.ShowDialog();
        }

        private void btnRegister_Click_1(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Isi semua field!");
                return;
            }

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();

                string cekUser = "SELECT COUNT(*) FROM akun WHERE username = @username";
                using (var cmd = new NpgsqlCommand(cekUser, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    long count = (long)cmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("Username sudah digunakan.");
                        return;
                    }
                }

                string insert = "INSERT INTO akun (username, password) VALUES (@username, @password)";
                using (var cmd = new NpgsqlCommand(insert, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registrasi berhasil!");
                this.Hide();
                new login().ShowDialog();
            }
        }
    }
}
