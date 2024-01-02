using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using ListPenginapan;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTAPPS_WIN;

namespace membership5
{
    public partial class beli : Form
    {
        public beli()
        {
            InitializeComponent();
        }

        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan membeli membership?", "Konfirmasi Pembelian", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                popmembership popmembership = new popmembership();
                popmembership.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                popmembership.Show();
                int user_id = 1;
                using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
                {
                    //memanggil koneksi db dan membuka
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand(); //mengelola objek parameter
                    cmd.Connection = connection; //memastikan db dan sql koneksinya sama
                    cmd.CommandText = $"UPDATE \"User\" SET status = 1 where user_id = {user_id}"; //mengatur teks yg akan dieksekusi
                    cmd.ExecuteNonQuery(); //mengirim perintah sql
                    cmd.Dispose(); //mengembalikan sumberdaya yg digunakan 
                    connection.Close();
                }
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Pembelian dibatalakan.", "Konfirmasi Pembelian", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            BtnSimpan.Enabled = false;



        }

        private void backbtnnavbar_Click(object sender, EventArgs e)
        {
            membership membership = new membership();
            membership.Show();
            this.Close();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void beli_Load(object sender, EventArgs e)
        {

        }
    }
}
