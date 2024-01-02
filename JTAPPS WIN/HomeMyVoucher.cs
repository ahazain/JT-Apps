using HomepageUser;
using Npgsql;
using JTAPPS_WIN;
using ListPenginapan;
using History_Fix;

namespace JT_APPS__Final_Voucher_
{
    public partial class HomeMyVoucher : Form
    {
        public HomeMyVoucher()
        {
            InitializeComponent();
        }

        private void HomeMyVoucher_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                conn.Open(); // membuka koneksi
                NpgsqlCommand cmd = conn.CreateCommand(); // mengambil nilai kolom 
                cmd.CommandText = "select voucher_id from voucher WHERE voucher_id=1"; // mengatur nilai yang akan dieksekusi

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read()) // memeriksa baris data yang akan dibaca
                    {
                        int voucher = reader.GetInt32(0);
                        label13.Text = voucher.ToString();
                    }
                }

                cmd.CommandText = "select voucher_id from voucher WHERE voucher_id=2";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label14.Text = voucher.ToString();
                    }
                }

                cmd.CommandText = "select voucher_id from voucher WHERE voucher_id=3";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label15.Text = voucher.ToString();
                    }
                }

                cmd.CommandText = "select voucher_id from voucher WHERE voucher_id=4";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label16.Text = voucher.ToString();
                    }
                }
            }
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History home_History = new Home_History();
            home_History.Show();
            this.Hide();
        }

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlist = new WishlistTiket();
            wishlist.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select deskripsi from voucher WHERE voucher_id=4";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String voucher = reader.GetString(0);
                        label12.Text = voucher;
                    }
                }

                cmd.CommandText = "select harga_voucher from voucher WHERE voucher_id=4";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label11.Text = voucher.ToString();
                    }
                }
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select deskripsi from voucher WHERE voucher_id=3";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String voucher = reader.GetString(0);
                        label9.Text = voucher;
                    }
                }

                cmd.CommandText = "select harga_voucher from voucher WHERE voucher_id=3";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label8.Text = voucher.ToString();
                    }
                }
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select deskripsi from voucher WHERE voucher_id=2";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String voucher = reader.GetString(0);
                        label6.Text = voucher;
                    }
                }

                cmd.CommandText = "select harga_voucher from voucher WHERE voucher_id=2";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label5.Text = voucher.ToString();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select deskripsi from voucher WHERE voucher_id=1";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String voucher = reader.GetString(0);
                        label1.Text = voucher;
                    }
                }

                cmd.CommandText = "select harga_voucher from voucher WHERE voucher_id=1";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int voucher = reader.GetInt32(0);
                        label2.Text = voucher.ToString();
                    }
                }
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}