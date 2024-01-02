using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;
using JTAPPS_WIN.Context;
using JTAPPS_WIN.Models;
using ListPenginapan;
using Siticone.Desktop.UI.WinForms;

namespace History_Fix
{
    public partial class Home_History : Form
    {
        CUser contextUser = new CUser();
        CTotalTiket contextTiket = new CTotalTiket();

        public List<User> UserList = new List<User>();
        public List<TotalKamar> KamarList = new List<TotalKamar>();
        public List<TotalTiket> TiketList = new List<TotalTiket>();
        public Home_History()
        {
            InitializeComponent();
            ReadDataUser();
            ReadDataTiket();
        }

        private void ReadDataUser()
        {
            contextUser.Read();
            if (contextUser.listUser.Count > 0)
            {

                User user = contextUser.listUser[0];

                labelticketpapuma.Text = user.Namakamar.ToString();
                label_no_pesanan.Text = user.IDDetTrans.ToString();
                label_no_pesanan2.Text = user.IDDetTrans.ToString();
                label5.Text = user.NamaTiket;
                label_e_ticket_rembangan.Text = user.NamaTiket;
                label6.Text = user.IDDetTrans.ToString();
                labelharga.Text = user.Paketkamar.ToString();
            }
        }

        private void ReadDataTiket()
        {
            contextTiket.Read();
            if (contextTiket.listTotalTiket.Count > 0)
            {
                TotalTiket tiket = contextTiket.listTotalTiket[0];

                label_harga2.Text = tiket.TiketTotal.ToString();
                label_harga3.Text = tiket.TiketTotal.ToString();
            }

        }

        private void labelJudulNavBar_Click(object sender, EventArgs e)
        {

        }

        private void buttondetail_Click(object sender, EventArgs e)
        {
            Detail1 form2 = new Detail1();
            form2.Show();
            this.Hide();
        }
        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_detail2_Click(object sender, EventArgs e)
        {
            Detail_History2 form3 = new Detail_History2();
            form3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Detail_History3 form4 = new Detail_History3();
            form4.Show();
            this.Hide();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            new SiticoneShadowForm(this);
            new SiticoneDragControl(this);
        }

        private void Home_History_Load(object sender, EventArgs e)
        {
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
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
            HomeMyVoucher myvoucher = new HomeMyVoucher();
            myvoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History history = new Home_History();
            history.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }

        private void buttonback_Click(object sender, EventArgs e)
        {

            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void paneltengah_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
