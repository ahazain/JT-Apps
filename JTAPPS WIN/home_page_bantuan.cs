using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
using ListPenginapan;

namespace JTAPPS_WIN
{
    public partial class home_page_bantuan : Form
    {
        public home_page_bantuan()
        {
            InitializeComponent();
        }

        private void btnFaq_Click(object sender, EventArgs e)
        {
            homaFAQ faq = new homaFAQ();
            faq.Show();
            this.Hide();
        }

        private void btnKritik_Click(object sender, EventArgs e)
        {
            Kritik_SaranForm2 kritik = new Kritik_SaranForm2();
            kritik.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            No_Darurat no_Darurat = new No_Darurat();
            no_Darurat.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void btnHomepage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myVoucher = new HomeMyVoucher();
            myVoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History myHistory = new Home_History();
            myHistory.Show();
            this.Hide();
        }

        private void btnchekcout_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }
    }
}