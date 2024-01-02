using History_Fix;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;

namespace ListPenginapan
{
    public partial class HomeMawarAdmin : Form
    {
        public HomeMawarAdmin()
        {
            InitializeComponent();
        }
        private void HomeMawar_Load(object sender, EventArgs e)
        {

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

        //private void label2_Click(object sender, EventArgs e)
        //{
        //    Mawar1 mawar1 = new Mawar1();
        //    mawar1.Show();
        //    this.Hide();
        //}

        //private void label3_Click(object sender, EventArgs e)
        //{
        //    Mawar2 mawar2 = new Mawar2();
        //    mawar2.Show();
        //    this.Hide();
        //}

        //private void label5_Click(object sender, EventArgs e)
        //{
        //    Mawar2DB mawar2db = new Mawar2DB();
        //    mawar2db.Show();
        //    this.Hide();
        //}

        //private void panel1_Click(object sender, EventArgs e)
        //{
        //    Mawar1 mawar1 = new Mawar1();
        //    mawar1.Show();
        //    this.Hide();
        //}

        //private void panel3_Click(object sender, EventArgs e)
        //{
        //    Mawar2 mawar2 = new Mawar2();
        //    mawar2.Show();
        //    this.Hide();
        //}

        //private void panel4_Click(object sender, EventArgs e)
        //{
        //    Mawar2DB mawar2db = new Mawar2DB();
        //    mawar2db.Show();
        //    this.Hide();
        //}
    }
}