using HomepageUser;
using JT_APPS__Final_Voucher_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTAPPS_WIN;
using UMKM_FIX;
using JTAPPS_WIN.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using Npgsql;
using System.Reflection.Emit;

namespace JTAPPS_WIN
{
    public partial class Umkm_DairyFarm : Form
    {
        Models.umkmcontext2 umkmContext;
        public Umkm_DairyFarm()
        {
            InitializeComponent();
            umkmContext = new umkmcontext2();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Homepage_Umkm().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlist = new WishlistTiket();
            wishlist.Show();
            this.Hide();
        }

        private void ShowItems()
        {
            umkmContext.Read();
            List<umkm> UmkmList;
            UmkmList = umkmContext.UmkmList;

            foreach (var umkm in UmkmList)
            {
                groupBox1.Text = umkm.deskripsi;
                label2.Text = umkm.lokasi;
            }
        }

        private void Umkm_DairyFarm_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT deskripsi FROM umkm OFFSET 1 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string lokasiumkm = reader.GetString(0);
                            groupBox1.Text = lokasiumkm;
                        }
                    }
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Username=postgres;Password=timotius;Database=JT-Apps";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT lokasi FROM umkm OFFSET 1 LIMIT 1";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string lokasiumkm = reader.GetString(0);
                            label2.Text = lokasiumkm;
                        }
                    }
                }

            }
        }
    }
}
