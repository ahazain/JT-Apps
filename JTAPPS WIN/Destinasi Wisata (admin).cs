using Admin__FAQ__V2;
using bagianAB;
using Fitur_Homepage_admin_penginapan.Models;
using Inap;
using JT_APPS__Final_Setting_;

namespace Fitur_Homepage_admin_penginapan
{
    public partial class DestinasiWisataAdmin : Form
    {
        public Edit_detail_wisata Edit_detail_penginapan { get; private set; }

        public DestinasiWisataAdmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUMKM adminUMKM = new AdminUMKM();
            adminUMKM.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Edit_detail_penginapan == null || Edit_detail_penginapan.IsDisposed)
            {
                Edit_detail_penginapan = new Edit_detail_wisata();
            }

            Edit_detail_penginapan.Show();
            this.Visible = false;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Edit_detail_wisata edit_Detail_Wisata = new Edit_detail_wisata();
            edit_Detail_Wisata.Show();
            this.Visible = false;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Edit_detail_wisata edit_Detail_Wisata = new Edit_detail_wisata();
            edit_Detail_Wisata.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Edit_detail_wisata edit_Detail_Wisata = new Edit_detail_wisata();
            edit_Detail_Wisata.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            PersetujuanBookingAdmin persetujuanBookingAdmin = new PersetujuanBookingAdmin();
            persetujuanBookingAdmin.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            AdminFAQ adminFAQ = new AdminFAQ();
            adminFAQ.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DestinasiWisataAdmin destinasiWisataAdmin = new DestinasiWisataAdmin();
            destinasiWisataAdmin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage_Admin_Penginapan homepage_Admin_Penginapan = new Homepage_Admin_Penginapan();
            homepage_Admin_Penginapan.Show();
            this.Hide();
        }


        /*private void button4_Click(object sender, EventArgs e)
        {
            Edit_detail_penginapan = new Edit_detail_penginapan();
            Edit_detail_penginapan.Show();        }*/
    }
}