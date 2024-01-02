using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN.Models;
using JTAPPS_WIN.Context;
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
    public partial class Detail_History2 : Form
    {
        CUser contextUser = new CUser(); 
        CTotalKamar contextKamar = new CTotalKamar();
        CTotalTiket contextTiket = new CTotalTiket();


        public List<User> UserList = new List<User>();
        public List<TotalKamar> KamarList = new List<TotalKamar>();
        public List<TotalTiket> TiketList = new List<TotalTiket>();

        public Detail_History2()
        {
            InitializeComponent();
            ReadDataUser();
            ReadDataTotalTiket();

        }

        private void ReadDataUser()
        {
            contextUser.Read();
            if (contextUser.listUser.Count > 0)
            {

                User user = contextUser.listUser[0];

                label41.Text = "E-Ticket " + user.Wisata;
                label35.Text = "No.Pesanan " + user.IDDetTrans.ToString();
                label12.Text = user.NamaTiket + " ( " + user.Kuantitas + " ) ";
                label34.Text = user.TglTransaksi.ToString("dd/MM/yyyy");
                tanggal.Text = user.TglTransaksi.ToString("dd/MM/yyyy");
                label31.Text = user.Nama;
                no_pesanan.Text = user.IDDetTrans.ToString();

            }
        }
        private void ReadDataTotalTiket()
        {
            contextTiket.Read();
            if (contextTiket.listTotalTiket.Count > 0)
            {
                TotalTiket totalTiket = contextTiket.listTotalTiket[0];
                harga1.Text = "RP " + totalTiket.TiketTotal.ToString();
                harga2.Text = "RP " + totalTiket.TiketTotal.ToString();
                harga3.Text = "-RP" + totalTiket.TiketTotal.ToString();
                harga4.Text = "RP " + totalTiket.TiketTotal.ToString();
            }

        }

        private void buttonback_Click(object sender, EventArgs e)
        {
            Home_History history1 = new Home_History();
            history1.Show();
            this.Close();
        }

        private void Detail_History2_Load(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form homepage_user = new HomepageUtama();
            homepage_user.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form paket_user = new penginapanMain();
            paket_user.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form voucher_user = new HomeMyVoucher();
            voucher_user.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Form history_user = new Home_History();
            history_user.Show();
            this.Hide();
        }

        private void BtnCheckout_Click(object sender, EventArgs e)
        {
            Form wishlist_user = new WishlistTiket();
            wishlist_user.Show();
            this.Hide();
        }
    }
}
