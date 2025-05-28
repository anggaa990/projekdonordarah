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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (var conn = new NpgsqlConnection(Database.ConnString))
            {
                conn.Open();

                string query = "SELECT COUNT(*) FROM akun WHERE username = @username AND password = @password";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("username", username);
                    cmd.Parameters.AddWithValue("password", password);

                    long count = (long)cmd.ExecuteScalar();
                    if (count == 1)
                    {
                        MessageBox.Show("Login berhasil!");
                        this.Hide();
                        new FormMainMenu(username).Show();
                    }
                    else
                    {
                        MessageBox.Show("Login gagal. Username atau password salah.");
                    }
                }
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
