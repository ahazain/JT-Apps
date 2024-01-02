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
using HomepageUser;
using JT_APPS__Final_Voucher_;
using ListPenginapan;
using History_Fix;
using Npgsql;
using System.Diagnostics;

namespace JTAPPS_WIN
{

    public partial class homaFAQ : Form
    {
        private string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
        public homaFAQ()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FAQ1 faq1 = new FAQ1();
            faq1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FAQ2 faq2 = new FAQ2();
            faq2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FAQ3 faq3 = new FAQ3();
            faq3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FAQ4 faq4 = new FAQ4();
            faq4.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FAQ5 faq5 = new FAQ5();
            faq5.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FAQ6 faq6 = new FAQ6();
            faq6.Show();
            this.Hide();
        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            this.Hide();
            home_page_bantuan form1 = new home_page_bantuan();
            form1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
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

        private void homaFAQ_Load(object sender, EventArgs e)
        {

        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            HomeMyVoucher homeMyVoucher = new HomeMyVoucher();
            homeMyVoucher.Show();
            this.Hide();
        }

        private void btnHomepage_Click_1(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }

        private void btnVoucher_Click_1(object sender, EventArgs e)
        {
            HomeMyVoucher homeMyVoucher = new HomeMyVoucher();
            homeMyVoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History home_History = new Home_History();
            home_History.Show();
            this.Hide();
        }

        private void btnchekcout_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            // Mengambil nomor telepon dan nama kontak dari database
            string nomorTelepon = string.Empty;
            string namaKontak = string.Empty;

            // Menggunakan NpgsqlConnection untuk menghubungkan ke database
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Mengeksekusi query untuk mendapatkan nomor telepon dan nama kontak
                string query = "SELECT nomor_telepon, nama_kontak FROM nomor_darurat WHERE nomor_darurat_id = 1";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    nomorTelepon = reader.GetString(reader.GetOrdinal("nomor_telepon"));
                    namaKontak = reader.GetString(reader.GetOrdinal("nama_kontak"));
                }
            }

            // Mengubah struktur nomor telepon menjadi format +62
            nomorTelepon = nomorTelepon.Replace(" ", "").Replace("+", "").Replace("-", "");
            nomorTelepon = "+62" + nomorTelepon.Substring(1);

            // Format URL WhatsApp
            string urlWhatsApp = "https://wa.me/" + nomorTelepon;

            // Tampilkan MessageBox dengan pesan yang diinginkan dan nomor telepon sebagai LinkLabel
            DialogResult dialogResult = MessageBox.Show($"Anda dapat menghubungi {namaKontak} melalui WhatsApp di nomor {nomorTelepon}. Klik OK untuk langsung menghubungi atau klik Cancel untuk menutup.", "Informasi Kontak", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            // Jika pengguna mengklik OK, buka URL di browser default
            if (dialogResult == DialogResult.OK)
            {
                System.Diagnostics.Process.Start(new ProcessStartInfo
                {
                    FileName = urlWhatsApp,
                    UseShellExecute = true
                });
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ1();
            form.Show();
            this.Hide();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ2();
            form.Show();
            this.Hide();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ3();
            form.Show();
            this.Hide();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ4();
            form.Show();
            this.Hide();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ5();
            form.Show();
            this.Hide();
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
            Form form = new FAQ6();
            form.Show();
            this.Hide();
        }
    }
}
