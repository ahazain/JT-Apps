using HomepageUser;
using JT_APPS__Final_Voucher_;
using History_Fix;
using JTAPPS_WIN;

namespace UMKM_FIX
{
    public partial class Homepage_Umkm : Form
    {

        public Homepage_Umkm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            //this.Hide();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e) //wishlist
        {
            WishlistTiket wishlist = new WishlistTiket();
            wishlist.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e) //history
        {
            Home_History history = new Home_History();
            history.Show();
            this.Dispose();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            //this.Hide();
            //new Form2().Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Umkm_DairyFarm().Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Umkm_Cafe().Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            //this.Hide();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Dispose();
        }
    }
}