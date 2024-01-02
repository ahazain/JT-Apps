using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Admin__FAQ__V2;
using bagianAB;
using Npgsql;

namespace Fitur_Homepage_admin_penginapan
{
    public partial class Edit_detail_penginapan : Form
    {
        NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
        public Edit_detail_penginapan()
        {
            InitializeComponent();
        }
        string imglocation = "";
        private void Edit_detail_penginapan_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kapasitas_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imglocation = dialog.FileName.ToString();
                pb_foto_penginapan.ImageLocation = imglocation;
            }
        }

        private void Simpan_Click(object sender, EventArgs e)
        {
            if (imglocation == "")
            {
                MessageBox.Show("Memasukan Foto Terlebih Dahulu");
            }
            else
            {
                byte[] images = null;
                FileStream stream = new FileStream(imglocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(stream);
                images = brs.ReadBytes((int)stream.Length);

                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into jenis_kamar (id_jeniskamar, nama_jeniskamar, kapasitas, nomor_kamar, fasilitas, harga, foto) values ('" + tb_judul.Text + "','" + tb_keterangan.Text + "','" + tb_kapasitas.Text + "','" + tb_nomor_kamar.Text + "','" + tb_fasilitas.Text + "','" + tb_harga.Text + "',@images) ";
                cmd.Parameters.Add(new NpgsqlParameter("@images", images));
                cmd.ExecuteNonQuery();
                conn.Close();
            }




            if (tb_judul.Text == "")
            {
                MessageBox.Show("Masukan Id Kamar Terlebih Dahulu");

            }
            else if (tb_keterangan.Text == "")
            {
                MessageBox.Show("Masukan jenis kamar Terlebih Dahulu");
            }
            else if (tb_kapasitas.Text == "")
            {
                MessageBox.Show("Masukan Kapasitas Terlebih Dahulu");
            }
            else if (tb_nomor_kamar.Text == "")
            {
                MessageBox.Show("Masukan Nomor Kamar Terlebih Dahulu");
            }
            else if (tb_fasilitas.Text == "")
            {
                MessageBox.Show("Masukan Fasilitas Terlebih Dahulu");
            }
            else if (tb_harga.Text == "")
            {
                MessageBox.Show("Masukan Harga Terlebih Dahulu");
            }
            else
            {
                //cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Disimpan");
                tb_judul.Text = "";
                tb_keterangan.Text = "";
                tb_kapasitas.Text = "";
                tb_nomor_kamar.Text = "";
                tb_fasilitas.Text = "";
                tb_harga.Text = "";
            }


        }

        private void Hapus_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            conn.Open();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from edit_penginapan where judul = '" + tb_judul.Text + "', keterangan = '" + tb_keterangan.Text + "', kapasitas = '" + tb_kapasitas.Text + "',nomor_kamar = '" + tb_nomor_kamar.Text + "', fasilitas = '" + tb_fasilitas.Text + "', harga = '" + tb_harga.Text + "', foto = @images ";


            if (tb_judul.Text == "")
            {
                MessageBox.Show("Masukan Judul Terlebih Dahulu");

            }
            else if (tb_keterangan.Text == "")
            {
                MessageBox.Show("Masukan Keterangan Terlebih Dahulu");
            }
            else if (tb_kapasitas.Text == "")
            {
                MessageBox.Show("Masukan Kapasitas Terlebih Dahulu");
            }
            else if (tb_nomor_kamar.Text == "")
            {
                MessageBox.Show("Masukan Nomor Kamar Terlebih Dahulu");
            }
            else if (tb_fasilitas.Text == "")
            {
                MessageBox.Show("Masukan Fasilitas Terlebih Dahulu");
            }
            else if (tb_harga.Text == "")
            {
                MessageBox.Show("Masukan Harga Terlebih Dahulu");
            }
            else
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data Berhasil Dihapus");
                this.Close();
            }
            conn.Close();
        }
    }
}
