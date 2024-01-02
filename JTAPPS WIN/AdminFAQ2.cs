using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin__FAQ__V2
{
    public partial class Form2 : Form
    {
        string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
        int idpertanyaan = AdminFAQ.IDFAQ;
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string sqll = "UPDATE faq SET pertanyaan = @pertanyaanbox, jawaban = @jawabanbox WHERE faq_id =@id ";
                using (var cmdd = new NpgsqlCommand(sqll, connection))
                {
                    cmdd.Parameters.AddWithValue("pertanyaanbox", textBox2.Text);
                    cmdd.Parameters.AddWithValue("jawabanbox", textBox1.Text);
                    cmdd.Parameters.AddWithValue("id", idpertanyaan);
                    int rowsAffected = cmdd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Berhasil mengubah FAQ.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Gagal mengubah Faq.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                using (NpgsqlCommand command = new NpgsqlCommand("SELECT pertanyaan FROM faq WHERE faq_id=@id;", connection))
                {
                    command.Parameters.AddWithValue("id", idpertanyaan);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string valueFromDatabase = reader.GetString(0);
                            textBox2.Text = valueFromDatabase;
                        }
                    }
                }
                using (NpgsqlCommand command = new NpgsqlCommand("SELECT jawaban FROM faq WHERE faq_id=@id;", connection))
                {
                    command.Parameters.AddWithValue("id", idpertanyaan);
                    command.Parameters.AddWithValue("id", idpertanyaan);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string valueFromDatabase = reader.GetString(0);
                            textBox1.Text = valueFromDatabase;
                        }
                    }
                }
            }
        }

        private void backbtnnavbar_Click(object sender, EventArgs e)
        {
            new AdminFAQ().Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                connection.Open();

                // Buat pernyataan SQL untuk menghapus entri FAQ berdasarkan ID serial
                string query = "DELETE FROM faq WHERE faq_id = @id"; // = id_faq nya bisa diganti tergantung yang ingin dihapus id berapa

                // Buat objek perintah dengan parameter
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("id", idpertanyaan);
                    // Eksekusi perintah DELETE
                    int deleteRows = cmd.ExecuteNonQuery();

                    if (deleteRows > 0)
                    {
                        MessageBox.Show("Data berhasil dihapus");
                        new AdminFAQ().Show();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Data dengan ID tersebut tidak ditemukan");
                    }
                }
            }

        }
    }
}
