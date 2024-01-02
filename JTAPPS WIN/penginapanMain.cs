using HomepageUser;
using Npgsql;
using System.Reflection;
using JT_APPS__Final_Setting_;
using JT_APPS__Final_Voucher_;
using History_Fix;
using JTAPPS_WIN;

namespace ListPenginapan
{
    public partial class penginapanMain : Form
    {
        penginapanContext mypenginapanContext;
        public penginapanMain()
        {
            InitializeComponent();
            mypenginapanContext = new penginapanContext();
        }

        private void penginapanMain_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void ShowItems()
        {
            mypenginapanContext.Read();
            List<penginapan> penginapanList;
            penginapanList = mypenginapanContext.penginapanList;

            flppenginapan.Controls.Clear();
            foreach (var inap in penginapanList)
            {
                string nama = inap.Nama;

                Panel pgnitem = new penginapanitem(inap).CreateItem();
                flppenginapan.Controls.Add(pgnitem);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void panellist_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btndetails_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }








        //private void Panel7_Click(object sender, EventArgs e)
        //{
        //    HomeMawar homeMawar = new HomeMawar();
        //    homeMawar.Show();
        //}

        //private void Panel6_Click(object sender, EventArgs e)
        //{
        //    HomeDahlia homeDahlia = new HomeDahlia();
        //    homeDahlia.Show();
        //}

        //private void Panel5_Click(object sender, EventArgs e)
        //{
        //    HomeMelati homeMelati = new HomeMelati();
        //    homeMelati.Show();
        //}

        //private void panel4_Click(object sender, EventArgs e)
        //{
        //    Suite suite = new Suite();
        //    suite.Show();
        //}
    }
}