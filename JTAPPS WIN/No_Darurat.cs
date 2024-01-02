using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTAPPS_WIN;
using Npgsql;

namespace JTAPPS_WIN
{
    public partial class No_Darurat : Form
    {
        public No_Darurat()
        {
            InitializeComponent();
            this.Load += label1_nomordarurat;
            this.Load += label2_nomordarurat;
            this.Load += label3_nomordarurat;
            this.Load += label4_nomordarurat_nama;
            this.Load += label7_nomordarurat_nama;
            this.Load += label6_nomordarurat_nama;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void label1_nomordarurat(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nomor_telepon FROM nomor_darurat";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomor_pakyasin = reader.GetString(0);

                            label1.Text = nomor_pakyasin;
                        }
                    }
                }

            }
        }

        public void label2_nomordarurat(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nomor_telepon FROM nomor_darurat OFFSET 1 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomor_polisi = reader.GetString(0);
                            label2.Text = nomor_polisi;
                        }
                    }
                }

            }
        }

        public void label3_nomordarurat(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nomor_telepon FROM nomor_darurat OFFSET 2 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomor_pemadam = reader.GetString(0);

                            label3.Text = nomor_pemadam;
                        }
                    }
                }

            }
        }

        public void label7_nomordarurat_nama(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nama_kontak FROM nomor_darurat";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nama_pak_yasin = reader.GetString(0);
                            label7.Text = nama_pak_yasin;
                        }
                    }
                }

            }
        }


        public void label6_nomordarurat_nama(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nama_kontak FROM nomor_darurat OFFSET 1 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nama_polisi = reader.GetString(0);
                            label6.Text = nama_polisi;
                        }
                    }
                }

            }
        }

        public void label4_nomordarurat_nama(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT nama_kontak FROM nomor_darurat OFFSET 2 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nama_pemadam = reader.GetString(0);
                            label4.Text = nama_pemadam;
                        }
                    }
                }

            }
        }
        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page_bantuan home_page_bantuan = new home_page_bantuan();
            home_page_bantuan.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void No_Darurat_Load(object sender, EventArgs e)
        {

        }
    }
}
