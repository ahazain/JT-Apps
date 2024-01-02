using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN.Models;
using ListPenginapan;
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

namespace JTAPPS_WIN
{
    public partial class DataDiriCheckout : Form
    {
        DataDiriContext datadiricontext;
        
        public DataDiriCheckout()
        {
            InitializeComponent();
            datadiricontext = new DataDiriContext();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            WishlistTiket Form1 = new WishlistTiket();
            Form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_pengunjung = textBox1.Text;
            DateTime selectedDateTime = dateTimePicker1.Value;
            string nomor_telepon = textBox2.Text;
            string domisili = textBox4.Text;
            string community_mode = textBox5.Text;

            DataDiri newdata = new DataDiri()
            {
                nama_pengunjung = nama_pengunjung,
                tanggal_reservasi = selectedDateTime,
                nomor_telepon = nomor_telepon,
                domisili = domisili,
                community_mode = community_mode
            };

            bool isSuccess = datadiricontext.insert(newdata);

            if (isSuccess)
            {
                MessageBox.Show("Berhasil menambahkan data diri");
            }
            else
            {
                MessageBox.Show("Data diri gagal ditambahkan");
            }

            Berhasil berhasil = new Berhasil();
            berhasil.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
