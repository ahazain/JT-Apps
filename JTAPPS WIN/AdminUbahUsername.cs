using Admin__FAQ__V2;
using bagianAB;
using Fitur_Homepage_admin_penginapan;

namespace UbahUnamePw
{
    public partial class AdminUbahUsername : Form
    {
        public AdminUbahUsername()
        {
            InitializeComponent();
        }

        private void customRoundedButton1_Click(object sender, EventArgs e)
        {

        }

        private void customRoundedButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
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
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }

        private void btnPaket_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void Homepage_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DetailAdminUbahUsername ubahPWnUN = new DetailAdminUbahUsername();
            ubahPWnUN.Show();
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
        }
    }
}