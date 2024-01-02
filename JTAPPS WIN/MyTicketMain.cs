using Fitur_Profile_Account;
using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
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

namespace JTAPPS_WIN
{
    public partial class MyTicketMain : Form
    {
        Models.MytiketContext mytiketContext;
        public MyTicketMain()
        {
            InitializeComponent();
            mytiketContext = new Models.MytiketContext();

        }

        private void roundedPicbox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MyTicketMain_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyTicketRembangan myTicketRembangan = new MyTicketRembangan();
            myTicketRembangan.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void ShowItems()
        {
            mytiketContext.Read();
            List<MyTiket> tiketList;
            tiketList = mytiketContext.TiketList;

            flpMyTicket.Controls.Clear();
            foreach (var tiket in tiketList)
            {

                lbNamaWisata.Text = tiket.NamaWisata;
                labelAlamatWisata.Text = tiket.AlamatWisata;
                labelKuantitas.Text = tiket.Kuantitas.ToString();
                labelHargaTiket.Text = tiket.HargaTiket.ToString();
                roundedPicboxWisata.Image = tiket.Image;

                RoundedPanel ticketItem = new MyTicketItem(tiket).CreateItem();
                flpMyTicket.Controls.Add(ticketItem);
            }

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            ProfileAccount profileAccount = new ProfileAccount();
            profileAccount.Show();
            this.Hide();
        }

        private void Homepage_Click(object sender, EventArgs e)
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

        private void btnWishlist_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }
    }
}
