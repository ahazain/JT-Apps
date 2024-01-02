using UMKM_FIX;
using JT_APPS__Final_Setting_;
using JT_APPS__Final_Voucher_;
using ListPenginapan;
using Fitur_Profile_Account;
using ListPenginapan;
using History_Fix;
using Fitur_Poin;
using JTAPPS_WIN;
using wisata2;

namespace HomepageUser
{
    public partial class HomepageUtama : Form
    {
        public HomepageUtama()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Homepage_Umkm homepageUmkm = new Homepage_Umkm();
            homepageUmkm.Show();
            this.Hide();
        }

        private void HomepageUser_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            HomeSetting setting = new HomeSetting();
            setting.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//paket
        {
            penginapanMain listPenginapan = new penginapanMain();
            listPenginapan.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)//history
        {
            Home_History history = new Home_History();
            history.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)//checkout
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            List_Wisata list_Wisata = new List_Wisata();
            list_Wisata.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Click(object sender, EventArgs e)
        {
            ProfileAccount account = new ProfileAccount();
            account.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            poin poin = new poin();
            poin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            home_page_bantuan bantuan = new home_page_bantuan();
            bantuan.Show();
            this.Hide();
        }




    }
}