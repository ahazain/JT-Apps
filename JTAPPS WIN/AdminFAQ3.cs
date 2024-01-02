
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;

namespace Admin__FAQ__V2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panelnavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        public void fungsi()
        {
            //using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=PBONEW; User Id=postgres; Password=123"))
            //{
            //    connection.Open();

            //    string test = $"select faq_id from faq where faq_id = '{button2.Text}'";
            //    using (NpgsqlCommand cmd = new NpgsqlCommand(test, connection))
            //    {
            //        cmd.ExecuteScalar();
            //    }
            //}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                connection.Open();

                // Buat pernyataan SQL untuk menghapus entri FAQ berdasarkan ID serial
                string query = "DELETE FROM faq WHERE faq_id = 10"; // = id_faq nya bisa diganti tergantung yang ingin dihapus id berapa

                // Buat objek perintah dengan parameter
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    // Eksekusi perintah DELETE
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                    }
                    else
                    {
                        MessageBox.Show("Data dengan ID tersebut tidak ditemukan");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void CreateFAQ(string pertanyaan, string jawaban, int homepage_id_homepage)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                connection.Open();

                // Buat pernyataan SQL untuk insert data baru ke tabel faq
                string query = "INSERT INTO faq (pertanyaan, jawaban, homepage_id_homepage) VALUES (@pertanyaan, @jawaban, @homepage_id_homepage)";

                // Buat objek perintah dengan parameter
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@pertanyaan", pertanyaan);
                    cmd.Parameters.AddWithValue("@jawaban", jawaban);
                    cmd.Parameters.AddWithValue("@homepage_id_homepage", homepage_id_homepage);

                    // Eksekusi perintah INSERT
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data berhasil disimpan");
                    }
                    else
                    {
                        MessageBox.Show("Gagal menambahkan data FAQ");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string pertanyaan = textBox2.Text;
            string jawaban = textBox1.Text;

            if (string.IsNullOrEmpty(pertanyaan) || string.IsNullOrEmpty(jawaban))
            {
                MessageBox.Show("Pertanyaan dan jawaban harus diisi.");
            }
            else
            {
                int homepage_id_homepage = GetHomepageID(); // Mendapatkan ID homepage dari sumber lain

                if (homepage_id_homepage == 0)
                {
                    MessageBox.Show("ID homepage tidak valid.");
                }
                else
                {
                    CreateFAQ(pertanyaan, jawaban, homepage_id_homepage);

                    textBox2.Text = "";
                    textBox1.Text = "";
                }
            }
        }

        private int GetHomepageID()
        {
            // Logika untuk mendapatkan ID homepage dari sumber lain
            // Misalnya, dapatkan ID homepage terkait dengan pengguna yang sedang masuk
            // atau ambil ID homepage dari daftar yang tersedia

            // Contoh sederhana untuk mengembalikan nilai statis 1
            return 1;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
