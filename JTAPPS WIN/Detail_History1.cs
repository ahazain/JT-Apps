using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN.Context;
using JTAPPS_WIN.Models;
using ListPenginapan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JTAPPS_WIN;
namespace History_Fix
{
    public partial class Detail1 : Form
    {
        CUser contextUser = new CUser();
        CTotalKamar contextKamar = new CTotalKamar();
        CTotalTiket contextTiket = new CTotalTiket();
        CKamar contextKamarHarga = new CKamar();


        public List<User> UserList = new List<User>();
        public List<TotalKamar> KamarList = new List<TotalKamar>();
        public List<TotalTiket> TiketList = new List<TotalTiket>();
        public List<Kamar> Kamarlist = new List<Kamar>();

        public Detail1()
        {
            InitializeComponent();
            ReadDataUser();
            ReadDataTotalKamar();
            ReadDataKamar();
        }

        private void ReadDataUser()
        {
            contextUser.Read();
            if (contextUser.listUser.Count > 0)
            {

                User user = contextUser.listUser[0];

                label3.Text = "Hotel " + user.Wisata;
                label4.Text = "No Pesanan " + user.IDDetTrans.ToString();
                //label11.Text = "RP " + user.Paketkamar.ToString();
                label6.Text = "RP " + user.Paketkamar.ToString();
                label1.Text = user.Namakamar;
                label34.Text = user.TglTransaksi.ToString("dd/MM/yyyy");
                label35.Text = user.TglTransaksi.ToString("dd/MM/yyyy");
                label31.Text = user.Nama;
                label47.Text = user.IDDetTrans.ToString();

            }
        }


        private void ReadDataTotalKamar()
        {
            contextKamar.Read();
            if (contextKamar.listTotalKamar.Count > 0)
            {
                TotalKamar totalKamar = contextKamar.listTotalKamar[0];

                label21.Text = "RP " + totalKamar.KamarTotal.ToString();
                label19.Text = "-RP " + totalKamar.KamarTotal.ToString();
                label24.Text = "RP " + totalKamar.KamarTotal.ToString();

            }

        }

        private void ReadDataKamar()
        {
            contextKamarHarga.Read();
            if (contextKamarHarga.listKamar.Count > 0)
            {
                Kamar kamar = contextKamarHarga.listKamar[0];

                label11.Text = "RP " + kamar.HargaKamar.ToString();
                label12.Text = kamar.KamarNama;

            }

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelNavBar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Home_History history1 = new Home_History();
            history1.Show();
            this.Close();
        }

        private void labelJudulNavBar_Click(object sender, EventArgs e)
        {
        }

        private void label28_Click(object sender, EventArgs e)
        {
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();

        }

        private void panelbatas_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label34_Click(object sender, EventArgs e)
        {
        }

        private void label19_Click(object sender, EventArgs e)
        {
        }

        private void label24_Click(object sender, EventArgs e)
        {
        }

        private void label54_Click(object sender, EventArgs e)
        {
        }

        private void label32_Click(object sender, EventArgs e)
        {
        }

        private void label29_Click(object sender, EventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label27_Click(object sender, EventArgs e)
        {
        }

        private void label21_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button12_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label12_Click_1(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void label47_Click(object sender, EventArgs e)
        {
        }

        private void label48_Click(object sender, EventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label45_Click(object sender, EventArgs e)
        {
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label46_Click(object sender, EventArgs e)
        {
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label44_Click(object sender, EventArgs e)
        {
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label42_Click(object sender, EventArgs e)
        {
        }

        private void label39_Click(object sender, EventArgs e)
        {
        }

        private void label38_Click(object sender, EventArgs e)
        {
        }

        private void label37_Click(object sender, EventArgs e)
        {
        }

        private void label36_Click(object sender, EventArgs e)
        {
        }

        private void label35_Click(object sender, EventArgs e)
        {
        }

        private void label31_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label18_Click(object sender, EventArgs e)
        {
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void label22_Click(object sender, EventArgs e)
        {
        }

        private void label20_Click(object sender, EventArgs e)
        {
        }

        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button14_Click(object sender, EventArgs e)
        {
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }

        private void label16_Click(object sender, EventArgs e)
        {
        }

        private void label17_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void panelSidebar_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void buttonback_Click_1(object sender, EventArgs e)
        {
            Home_History history1 = new Home_History();
            history1.Show();
            this.Hide();
        }

        private void Detail1_Load(object sender, EventArgs e)
        {

        }
    }
}
