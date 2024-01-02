using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomepageUser;
using JTAPPS_WIN;
using JTAPPS_WIN.Models;
using JTAPPS_WIN.Properties;

namespace JTAPPS_WIN
{
    public partial class MyTicketRembangan : Form
    {
        public MyTicketRembangan()
        {
            InitializeComponent();
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void btnWishlist_Click(object sender, EventArgs e)
        {
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
        }

        private void btnTutup_Click(object sender, EventArgs e)
        {
            MyTicketMain myTicketForm = new MyTicketMain();
            myTicketForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void SetMyticket(MyTiket myTiket)
        {
            labelnamaWisata.Text = myTiket.NamaWisata;
            labeldeskripsiIsi.Text = myTiket.Deskripsi;
            namaDeskripsi.Text = myTiket.NamaWisata;
            labelharga.Text = myTiket.DetailHarga.ToString();
            panelGambarWisata.BackgroundImage = myTiket.Image;
            pbRating1.Text = myTiket.Rating.ToString();
            pbRating2.Text = myTiket.Rating.ToString();
            pbRating3.Text = myTiket.Rating.ToString();
            pbRating4.Text = myTiket.Rating.ToString();
            pbRating5.Text = myTiket.Rating.ToString();

            float rating = myTiket.Rating;
            if (rating >= 0.5 && rating < 1)
            {
                pbRating1.Image = Resources.lopGroup_7;
                pbRating2.Image = Resources.lop0Group_9;
                pbRating3.Image = Resources.lop0Group_9;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 1 && rating < 1.5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop0Group_9;
                pbRating3.Image = Resources.lop0Group_9;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 1.5 && rating < 2)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lopGroup_7;
                pbRating3.Image = Resources.lop0Group_9;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 2 && rating < 2.5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop0Group_9;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 2.5 && rating < 3)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lopGroup_7;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 3 && rating < 3.5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop2Group_8;
                pbRating4.Image = Resources.lop0Group_9;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 3.5 && rating < 4)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop2Group_8;
                pbRating4.Image = Resources.lopGroup_7;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 4 && rating < 4.5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop2Group_8;
                pbRating4.Image = Resources.lopGroup_7;
                pbRating5.Image = Resources.lop0Group_9;
            }
            if (rating >= 4.5 && rating < 5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop2Group_8;
                pbRating4.Image = Resources.lop2Group_8;
                pbRating5.Image = Resources.lopGroup_7;
            }
            if (rating == 5)
            {
                pbRating1.Image = Resources.lop2Group_8;
                pbRating2.Image = Resources.lop2Group_8;
                pbRating3.Image = Resources.lop2Group_8;
                pbRating4.Image = Resources.lop2Group_8;
                pbRating5.Image = Resources.lop2Group_8;
            }
        }

        private void MyTicketRembangan_Load(object sender, EventArgs e)
        {

        }
    }
}

