using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GradientForm;
using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
using JTAPPS_WIN.Context;
using JTAPPS_WIN.Models;
using ListPenginapan;
using DesktopApp;
using System.Reflection.Emit;
using Npgsql;

namespace Fitur_Profile_Account
{
    public partial class ProfileAccount : Form
    {
        public static string TempEmail { get; set; }
        private string connectionString = "Server=localhost; Port=5432; Database=JT-Apps; User Id=postgres; Password=timotius";
        private UserDatabase userDatabase;
        statusmembershipContext context;

        public ProfileAccount()
        {
            InitializeComponent();
            userDatabase = new UserDatabase(connectionString);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            context = new statusmembershipContext();
            context.Read();

            foreach (statusmembership status in context.statuslist)
            {
                if (status.status == 1)
                {
                    label3.Text = "Aktif";
                }
                else
                {
                    label3.Text = "Tidak Aktif";
                }
            }

            try
            {
                User user = userDatabase.GetUserById(2);

                if (user != null)
                {
                    label5.Text = user.FullName;
                    label11.Text = user.Email;
                    label9.Text = user.Points.ToString();
                    label6.Text = user.FullName;
                    label4.Text = GetWaktuSekarang();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }
        private string GetWaktuSekarang()
        {
            string waktu = string.Empty;
            DateTime sekarang = DateTime.Now;
            int jam = sekarang.Hour;

            if (jam >= 0 && jam < 12)
            {
                waktu = "Selamat Pagi";
            }
            else if (jam >= 12 && jam < 15)
            {
                waktu = "Selamat Siang";
            }
            else if (jam >= 15 && jam < 18)
            {
                waktu = "Selamat Sore";
            }
            else
            {
                waktu = "Selamat Malam";
            }

            return waktu;
        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void gradientPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Profil_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }

        private void gradientPanel2_Paint(object sender, PaintEventArgs e)
        {
            {
                {
                    context = new statusmembershipContext();
                    context.Read();

                    foreach (statusmembership status in context.statuslist)
                    {
                        if (status.status == 1)
                        {
                            gradientPanel2.Visible = true;
                        }
                        else
                        {
                            gradientPanel2.Visible = false;
                        }
                    }
                }

            }
        }

        private void gradientPanel3_Paint(object sender, PaintEventArgs e)
        {
            {
                {
                    context = new statusmembershipContext();
                    context.Read();

                    foreach (statusmembership status in context.statuslist)
                    {
                        if (status.status == 1)
                        {
                            gradientPanel3.Visible = true;
                        }
                        else
                        {
                            gradientPanel3.Visible = false;
                        }
                    }
                }

            }
        }

        private void Homepage_Click_1(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }
    }
    public class User
    {
        public string FullName { get; set; }
        public string Email { get; set; }
        public int Points { get; set; }
    }
    public class UserDatabase

    {
        private string connectionString;

        public UserDatabase(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public User GetUserById(int userId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string email = Formlogin.TempEmail;
                connection.Open();

                string query = "SELECT nama_lengkap, email, poin, status FROM \"User\" WHERE email=@email";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("email", email);

                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            User user = new User();
                            user.FullName = reader["nama_lengkap"].ToString();
                            user.Email = reader["email"].ToString();
                            user.Points = Convert.ToInt32(reader["poin"]);
                            return user;
                        }
                    }
                }

                connection.Close();
            }


            return null;
        }
    }
}
