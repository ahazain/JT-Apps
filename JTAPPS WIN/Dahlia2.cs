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
    public partial class Dahlia2 : Form
    {
        public Dahlia2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeDahlia homeDahlia = new HomeDahlia();
            homeDahlia.Show();
            this.Close();
        }

        private void Mawar2DB_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form dahlia2_homepage = new HomepageUtama();
            dahlia2_homepage.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form dahlia2_voucher = new HomeMyVoucher();
            dahlia2_voucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form dahlia2_history = new Home_History();
            dahlia2_history.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form dahlia2_checkout = new WishlistTiket();
            dahlia2_checkout.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }
    }
}
