using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using ListPenginapan;
using JTAPPS_WIN;

namespace JT_APPS__Final_Setting_
{
    public partial class HomeMawar : Form
    {
        public HomeMawar()
        {
            InitializeComponent();
        }
        private void HomeMawar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Mawar1 mawar1 = new Mawar1();
            mawar1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Mawar2 mawar2 = new Mawar2();
            mawar2.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Mawar2DB mawar2db = new Mawar2DB();
            mawar2db.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Mawar1 mawar1 = new Mawar1();
            mawar1.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Mawar2 mawar2 = new Mawar2();
            mawar2.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Mawar2DB mawar2db = new Mawar2DB();
            mawar2db.Show();
            this.Hide();
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form hompage_mawar = new HomepageUtama();
            hompage_mawar.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form voucher_mawar = new HomeMyVoucher();
            voucher_mawar.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history_mawar = new Home_History();
            history_mawar.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form checkout_mawar = new WishlistTiket();
            checkout_mawar.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {

        }
    }
}