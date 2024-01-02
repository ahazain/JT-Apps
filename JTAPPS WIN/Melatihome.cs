using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;

namespace JT_APPS__Final_Setting_
{
    public partial class Melatihome : Form
    {
        public Melatihome()
        {
            InitializeComponent();
        }
        private void HomeMawar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Melati1 melati1 = new Melati1();
            melati1.Show();
            this.Hide();
        }


        private void label5_Click(object sender, EventArgs e)
        {
            Melati1 melati1 = new Melati1();
            melati1.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Melati2 melati2 = new Melati2();
            melati2.Show();
            this.Hide();
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Melati2 melati2 = new Melati2();
            melati2.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Melati2DB melati2db = new Melati2DB();
            melati2db.Show();
            this.Hide();
        }


        private void label7_Click(object sender, EventArgs e)
        {
            Melati2DB melati2db = new Melati2DB();
            melati2db.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Melati3 melati3 = new Melati3();
            melati3.Show();
            this.Hide();
        }



        private void label8_Click(object sender, EventArgs e)
        {
            Melati3 melati3 = new Melati3();
            melati3.Show();
            this.Hide();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            Melati1 melati1 = new Melati1();
            melati1.Show();
            this.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Melati2 melati2 = new Melati2();
            melati2.Show();
            this.Hide();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Melati2DB melati2db = new Melati2DB();
            melati2db.Show();
            this.Hide();
        }

        private void panel5_Click(object sender, EventArgs e)
        {
            Melati3 melati3 = new Melati3();
            melati3.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form melati_homepage = new HomepageUtama();
            melati_homepage.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form melati_voucher = new HomeMyVoucher();
            melati_voucher.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form melati_checkout = new WishlistTiket();
            melati_checkout.Show();
            this.Hide();
        }
    }
}