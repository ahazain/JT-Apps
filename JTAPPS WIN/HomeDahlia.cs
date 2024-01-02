using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
using ListPenginapan;

namespace JT_APPS__Final_Setting_
{
    public partial class HomeDahlia : Form
    {
        public HomeDahlia()
        {
            InitializeComponent();
        }
        private void HomeMawar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Dahlia1 mawar1 = new Dahlia1();
            mawar1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Dahlia2 mawar2 = new Dahlia2();
            mawar2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Dahlia2 mawar2db = new Dahlia2();
            mawar2db.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Dahlia1 dahlia1 = new Dahlia1();
            dahlia1.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Dahlia2 dahlia2 = new Dahlia2();
            dahlia2.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Dahlia2 mawar2db = new Dahlia2();
            mawar2db.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtamama = new HomepageUtama();
            homepageUtamama.Show();
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
            HomeMyVoucher homeMyVoucher = new HomeMyVoucher();
            homeMyVoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History home_History = new Home_History();
            home_History.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }
    }
}