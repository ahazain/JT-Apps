using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;

namespace JT_APPS__Final_Setting_
{
    public partial class HomeSetting : Form
    {
        public HomeSetting()
        {
            InitializeComponent();
        }

        private void btnUbahprfl_Click(object sender, EventArgs e)
        {
            UbahProfil ubahProfil = new UbahProfil();
            ubahProfil.Show();
            this.Hide();
        }

        private void btnUbhSandi_Click(object sender, EventArgs e)
        {
            UbahSandi ubahSandi = new UbahSandi();
            ubahSandi.Show();
            this.Hide();
        }

        private void btnKebijakanPrivasi_Click(object sender, EventArgs e)
        {
            KebijakanPrivasi kebijakanPrivasi = new KebijakanPrivasi();
            kebijakanPrivasi.Show();
            this.Hide();
        }

        private void btnSyarat_Click(object sender, EventArgs e)
        {
            SyaratDanKetentuan syaratDanKetentuan = new SyaratDanKetentuan();
            syaratDanKetentuan.Show();
            this.Hide();
        }

        private void btnTentangKami_Click(object sender, EventArgs e)
        {
            TentangKami tentangKami = new TentangKami();
            tentangKami.Show();
            this.Hide();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {

        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlist = new WishlistTiket();
            wishlist.Show();
            this.Hide();
        }
    }
}
