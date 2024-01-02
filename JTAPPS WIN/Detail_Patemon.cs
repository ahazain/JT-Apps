using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN.Models;
using ListPenginapan;
using Npgsql;
using System.Data;
using System.Text;
using JTAPPS_WIN;

namespace wisata2
{
    public partial class Detail_Patemon : Form
    {
        public Detail_Patemon()
        {
            InitializeComponent();
            getWeather();
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select deskripsi_wisata from wisata where id_wisata = 'A03'";
            NpgsqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                textBox1.Text = reader["deskripsi_wisata"].ToString();
            }
            conn.Close();

            NpgsqlConnection con = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
            con.Open();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = con;
            comm.CommandType = CommandType.Text;
            comm.CommandText = "select nama_fasilitas from fasilitas_wisata";
            using (NpgsqlDataReader dr = comm.ExecuteReader())
            {
                StringBuilder sb = new StringBuilder();
                while (dr.Read())
                {
                    string rowdata = dr.GetString(0);
                    sb.AppendLine(rowdata);
                }
                label7.Text = sb.ToString();
            }

            conn.Close();

            NpgsqlConnection conne = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
            conne.Open();
            NpgsqlCommand comma = new NpgsqlCommand();
            comma.Connection = conne;
            comma.CommandType = CommandType.Text;
            comma.CommandText = "select alamat_wisata from wisata where id_wisata = 'A03'";
            NpgsqlDataReader r = comma.ExecuteReader();
            if (r.Read())
            {
                label10.Text = (string)r["alamat_wisata"];
            }
            conne.Close();

            NpgsqlConnection connec = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
            connec.Open();
            NpgsqlCommand comd = new NpgsqlCommand();
            comd.Connection = connec;
            comd.CommandType = CommandType.Text;
            comd.CommandText = "select nama_tiket, harga_tiket from tiket where tiket_id = '2'";
            using (NpgsqlDataReader dr = comd.ExecuteReader())
            {
                StringBuilder sb = new StringBuilder();
                while (dr.Read())
                {
                    string rowdata = $"{dr.GetString(0)} : {dr.GetDecimal(1):N0}";
                    sb.AppendLine(rowdata);
                }
                label4.Text = sb.ToString();
            }
            connec.Close();

            NpgsqlConnection connect = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
            connect.Open();
            NpgsqlCommand commd = new NpgsqlCommand();
            commd.Connection = connect;
            commd.CommandType = CommandType.Text;
            commd.CommandText = "select nama_paketmakanan, harga, deskripsi_paket from Paket_Makanan";
            using (NpgsqlDataReader dre = commd.ExecuteReader())
            {
                StringBuilder stb = new StringBuilder();
                while (dre.Read())
                {
                    string rowdata = $"{dre.GetString(0)}, {dre.GetDecimal(1)}, {dre.GetString(2)}";
                    stb.AppendLine(rowdata);
                }
                label12.Text = stb.ToString();
            }
            connect.Close();
        }

        private void backbtnnavbar_Click(object sender, EventArgs e)
        {
            List_Wisata list_Wisata = new List_Wisata();
            list_Wisata.Show();
            this.Close();
        }
        void getWeather()
        {
            WeatherAPIContext weatherAPIContext = new WeatherAPIContext();
            WeatherAPI weatherAPI = new WeatherAPI();
            weatherAPI.ReadWeather(weatherAPIContext, iconweather, suhu, feelslike);
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Homepagebtn_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void paketbtn_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void Voucherbtn_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void Historybtn_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }
    }
}