using History_Fix;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using JTAPPS_WIN;

namespace CRUDProject
{
    public partial class Suite : Form
    {
        public Suite()
        {
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            new Suite().Show();
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            new Suite().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form suite_room = new HomepageUtama();
            suite_room.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form suite_room_voucher = new HomeMyVoucher();
            suite_room_voucher.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form suite_room_history = new Home_History();
            suite_room_history.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form suite_room_checkout = new WishlistTiket();
            suite_room_checkout.Show();
            this.Hide();
        }
        //private void Form1_SizeChanged_1(object sender, EventArgs e)
        //{
        //    float fontSize = (float)(Width + Height) / 400; // Sesuaikan rumus ini sesuai kebutuhan Anda

        //    // Atur ukuran font pada kontrol yang diinginkan
        //    button1.Font = new Font(button1.Font.FontFamily, fontSize, button1.Font.Style);
        //    // textBox6.Font = new Font(textBox6.Font.FontFamily, fontSize, textBox6.Font.Style);
        //    button2.Font = new Font(button2.Font.FontFamily, fontSize, button2.Font.Style);
        //    textBox7.Font = new Font(textBox7.Font.FontFamily, fontSize, textBox7.Font.Style);
        //    button3.Font = new Font(button3.Font.FontFamily, fontSize, button3.Font.Style);
        //    textBox9.Font = new Font(textBox9.Font.FontFamily, fontSize, textBox9.Font.Style);
        //    button4.Font = new Font(button4.Font.FontFamily, fontSize, button4.Font.Style);
        //    //textBox16.Font = new Font(textBox16.Font.FontFamily, fontSize, textBox16.Font.Style);
        //    button5.Font = new Font(button5.Font.FontFamily, fontSize, button5.Font.Style);
        //    textBox15.Font = new Font(textBox15.Font.FontFamily, fontSize, textBox15.Font.Style);
        //    //button6.Font = new Font(button6.Font.FontFamily, fontSize, button6.Font.Style);
        //    textBox14.Font = new Font(textBox14.Font.FontFamily, fontSize, textBox14.Font.Style);
        //    textBox13.Font = new Font(textBox13.Font.FontFamily, fontSize, textBox13.Font.Style);
        //    textBox12.Font = new Font(textBox12.Font.FontFamily, fontSize, textBox12.Font.Style);
        //    textBox17.Font = new Font(textBox17.Font.FontFamily, fontSize, textBox17.Font.Style);
        //    textBox18.Font = new Font(textBox18.Font.FontFamily, fontSize, textBox18.Font.Style);
        //    //textBox19.Font = new Font(textBox19.Font.FontFamily, fontSize, textBox19.Font.Style);
        //    textBox20.Font = new Font(textBox20.Font.FontFamily, fontSize, textBox20.Font.Style);
        //    textBox21.Font = new Font(textBox21.Font.FontFamily, fontSize, textBox21.Font.Style);
        //    textBox22.Font = new Font(textBox22.Font.FontFamily, fontSize, textBox22.Font.Style);
        //    //judul.Font = new Font(judul.Font.FontFamily, fontSize, judul.Font.Style);
        //    label2.Font = new Font(label2.Font.FontFamily, fontSize, label2.Font.Style);
        //    //pictureBox2.Font = new Font(pictureBox2.Font.FontFamily, fontSize, pictureBox2.Font.Style);
        //    //pictureBox1.Font = new Font(pictureBox1.Font.FontFamily, fontSize, pictureBox1.Font.Style);
        //    //pictureBox5.Font = new Font(pictureBox5.Font.FontFamily, fontSize, pictureBox5.Font.Style);
        //    panel1.Font = new Font(panel1.Font.FontFamily, fontSize, panel1.Font.Style);
        //    label3.Font = new Font(label3.Font.FontFamily, fontSize, label3.Font.Style);
        //    label4.Font = new Font(label4.Font.FontFamily, fontSize, label4.Font.Style);
        //}

        //private void labelUbahProfil_Click(object sender, EventArgs e)
        //{
        //    float fontSize = (float)(Width + Height) / 400;
        //    labelUbahProfil.Font = new Font(labelUbahProfil.Font.FontFamily, fontSize, labelUbahProfil.Font.Style);
        //}
    }
}