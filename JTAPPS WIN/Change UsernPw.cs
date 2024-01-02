using Admin__FAQ__V2;
using bagianAB;
using Fitur_Homepage_admin_penginapan;
using System.Xml.Linq;

namespace Change_UsernPw
{
    public partial class ChangeUsernPw : Form
    {
        public ChangeUsernPw()
        {
            InitializeComponent();
        }

        private void rectang1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Username usform = new Username();
            usform.Show();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Kata_Sandi Ksform = new Kata_Sandi();
            Ksform.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }
    }
}
