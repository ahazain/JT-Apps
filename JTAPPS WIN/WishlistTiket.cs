using HomepageUser;
using JT_APPS__Final_Voucher_;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;


namespace JTAPPS_WIN
{
    public partial class WishlistTiket : Form
    {
        public WishlistTiket()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataDiriCheckout dataDiriCheckout = new DataDiriCheckout();
            dataDiriCheckout.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void Homepagebtn_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void Voucherbtn_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void paketbtn_Click(object sender, EventArgs e)
        {

        }

        private void Historybtn_Click(object sender, EventArgs e)
        {

        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {

        }

        private void WishlistTiket_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5433;Username=postgres;Database=JT-Apps;Password=Imel1107_;";
            //menyimpan informasi koneksi ke database PostgreSQL.
            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM wishlist WHERE wishlist_id = @3";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    {
                        cmd.Parameters.AddWithValue("wishlist_id");
                        // Eksekusi perintah DELETE
                        int rowsAffected = cmd.ExecuteNonQuery();
                    }
                    DialogResult result = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        groupBox3.Parent.Controls.Remove(groupBox3);

                        /*DialogResult result1 = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                        }*/
                    }
                }
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5433;Username=postgres;Database=JT-Apps;Password=Imel1107_;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM wishlist WHERE wishlist_id = @2";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {

                    {
                        cmd.Parameters.AddWithValue("wishlist_id");
                        // Eksekusi perintah DELETE
                        int rowsAffected = cmd.ExecuteNonQuery();


                    }
                    DialogResult result = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        groupBox2.Parent.Controls.Remove(groupBox2);

                        /*DialogResult result1 = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        {
                        }*/
                    }
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Host=localhost;Port=5433;Username=postgres;Database=JT-Apps;Password=Imel1107_;";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM wishlist WHERE wishlist_id = @1";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                {
                    {
                        cmd.Parameters.AddWithValue("wishlist_id");
                        // Eksekusi perintah DELETE
                        int rowsAffected = cmd.ExecuteNonQuery();


                    }
                    DialogResult result = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        groupBox1.Parent.Controls.Remove(groupBox1);

                        /*DialogResult result1 = MessageBox.Show("Apakah Anda ingin menghapusnya?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result1 == DialogResult.Yes)
                        
                        }*/
                    }
                }
            }

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}