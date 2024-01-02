using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
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
using ListPenginapan;

namespace JT_APPS__Final_Setting_
{
    public partial class SyaratDanKetentuan : Form
    {
        public SyaratDanKetentuan()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeSetting homeSetting = new HomeSetting();
            homeSetting.Show();
            this.Hide();
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form syarat_ketentuan_homepage = new HomepageUtama();
            syarat_ketentuan_homepage.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form syarat_ketentuan_homepage = new HomepageUtama();
            syarat_ketentuan_homepage.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form syarat_ketentuan_history = new Home_History();
            syarat_ketentuan_history.Show();
            this.Hide();
        }

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            Form syarat_ketentuan_chekout = new WishlistTiket();
            syarat_ketentuan_chekout.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }
    }
}
