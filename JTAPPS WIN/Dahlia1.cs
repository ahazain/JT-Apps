using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using ListPenginapan;
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

namespace JT_APPS__Final_Setting_
{
    public partial class Dahlia1 : Form
    {
        public Dahlia1()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeDahlia form1 = new HomeDahlia();
            form1.Show();
            this.Close();
        }

        private void labelJudulNavBar_Click(object sender, EventArgs e)
        {

        }

        private void Mawar1_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeDahlia homeDahlia = new HomeDahlia();
            homeDahlia.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form dahlia_homepage = new HomepageUtama();
            dahlia_homepage.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form dahlia_voucher = new HomeMyVoucher();
            dahlia_voucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form dahlia_history = new Home_History();
            dahlia_history.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form dahlia_checkout = new WishlistTiket();
            dahlia_checkout.Show();
            this.Hide();
        }

        private void BtnHomePage_Click_1(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();

        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void btnVoucher_Click_1(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void btnHistory_Click_1(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void BtnCheckout_Click_1(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }
    }
}
