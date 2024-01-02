using Admin__FAQ__V2;
using bagianAB;
using data_staf;
using Fitur_Homepage_admin_penginapan;
using HomepageUser;
using JTAPPS_WIN;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherAdmin;
using NpgsqlTypes;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace JT_APPS__Final_Setting_
{
    public partial class AdminEditStaff : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
        public AdminEditStaff()
        {
            InitializeComponent();
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            NpgsqlDataAdapter dataadp = new NpgsqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();
        }
        private void ResetForm()
        {
            // Reset nilai-nilai kontrol ke keadaan awal

            boxnama.Text = string.Empty;
            boxhp.Text = string.Empty;
            boxemail.Text = string.Empty;
            boxdom.Text = string.Empty;
            boxjabatan.Text = string.Empty;
        }
        private bool AlertGakLengkap()
        {
            if (string.IsNullOrEmpty(boxnama.Text) ||
                string.IsNullOrEmpty(boxhp.Text) ||
                string.IsNullOrEmpty(boxemail.Text) ||
                string.IsNullOrEmpty(boxdom.Text))
            {
                return true; // Ada TextBox yang kosong
            }
            return false; // Semua TextBox terisi
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGanti_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Apakah anda yakin ingin mengganti sandi?", "Ubah Sandi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AdminEditStaff_Load(object sender, EventArgs e)
        {

        }

        private void AdminEditStaff_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form form = new HapusStafAdmin();
            form.ShowDialog();
            this.Hide();

        }

        public void refresh()
        {
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from staff";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            NpgsqlDataAdapter dataadp = new NpgsqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            conn.Close();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PanelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnsimpandata_Click(object sender, EventArgs e)
        {
            conn.Open();
            NpgsqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update staf set nama='" + this.boxnama.Text + "',no_hp='" + this.boxhp.Text + "',email='" + this.boxemail.Text + "',domisili='" + this.boxdom.Text + "',tanggal_masuk='" + this.boxtglmsk.Text + "' ";
            boxtglmsk.Value = DateTime.Now;
            cmd.ExecuteNonQuery();
            conn.Close();
            if (boxnama.Text == "")
            {
                MessageBox.Show("Masukan Nama Terlebih Dahulu");
            }
            else if (boxhp.Text == "")
            {
                MessageBox.Show("Silahkan Isi Data Terbaru");
            }
            else if (boxemail.Text == "")
            {
                MessageBox.Show("Silahkan Isi Data Terbaru");
            }
            else if (boxdom.Text == "")
            {
                MessageBox.Show("Silahkan Isi Data Terbaru");
            }
            else
            {
                this.Hide();
                MessageBox.Show("Data Berhasil Di Update");
                this.Close();

            }
        }

        private void btntambahdata_Click(object sender, EventArgs e)
        {
            conn.Open();
            string nama = boxnama.Text;
            string hp = boxhp.Text;
            string email = boxemail.Text;
            string domisili = boxdom.Text;
            DateTime tanggalmasuk = boxtglmsk.Value.Date;
            DateTime tanggallahir = boxtgllhr.Value.Date;
            string query = "INSERT INTO public.staff (nama, no_hp, email, domisili, hire_date, tanggal_lahir) VALUES (@nama, @hp, @email, @domisili, @tglmsk, @tgllhr)";
            NpgsqlCommand comm = new NpgsqlCommand(query, conn);
            comm.Parameters.AddWithValue("@nama", nama);
            comm.Parameters.AddWithValue("@hp", hp);
            comm.Parameters.AddWithValue("@email", email);
            comm.Parameters.AddWithValue("@domisili", domisili);
            comm.Parameters.AddWithValue("@tanggalmasuk", NpgsqlDbType.Date, tanggalmasuk);
            comm.Parameters.AddWithValue("@tanggallahir", NpgsqlDbType.Date, tanggallahir);
            if (AlertGakLengkap())
            {
                MessageBox.Show("Harap isi semua data");
                return; // Tidak melanjutkan penyimpanan data
            }
            comm.ExecuteNonQuery();
            conn.Close();
            ResetForm();
            formdata.Visible = false;
        }

        private void btnbatal_Click(object sender, EventArgs e)
        {
            ResetForm();
            formdata.Visible = false;
        }
    }
}
