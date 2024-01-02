using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
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

namespace JT_APPS__Final_Setting_
{
    public partial class KebijakanPrivasi : Form
    {
        public KebijakanPrivasi()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Form form = new HomeSetting();
            form.Show();
            this.Hide();
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
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

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();

        }

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }
    }
}