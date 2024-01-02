using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
using ListPenginapan;
using Npgsql;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JTAPPS_WIN
{
    public partial class FAQ2 : Form
    {
        private string connectionString = "Server=localhost; Port=5432; Database=JT-Apps; User Id=postgres; Password=timotius";
        public FAQ2()
        {
            InitializeComponent();
            LoadFAQ();
        }
        private void LoadFAQ()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan, jawaban FROM faq WHERE faq_id = 2", connection);

                    NpgsqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        string pertanyaan = reader["pertanyaan"].ToString();
                        string jawaban = reader["jawaban"].ToString();

                        labelpertanyaan.Text = pertanyaan;
                        labeljawaban.Text = jawaban;
                    }
                    else
                    {
                        MessageBox.Show("FAQ tidak ditemukan.");
                    }

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            homaFAQ fAQForm2 = new homaFAQ();
            fAQForm2.Show();
        }

        private void FAQ2_Load(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                label6.Text = "Ketuk untuk Cari";
            }
            else
            {
                label6.Text = "";
            }
            textBox1.AutoSize = false;
            textBox1.Height = 20;

        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Visible = false;
            textBox1.Focus();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            textBox1.Focus();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void btnchekcout_Click(object sender, EventArgs e)
        {

            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }
    }
}
