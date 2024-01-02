using Admin__FAQ__V2;
using bagianAB;
using Fitur_Homepage_admin_penginapan;
using Npgsql;
using NpgsqlTypes;

namespace JT_APPS__Final_Setting_
{
    public partial class AdminEditUMKM : Form
    {
        private string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
        public AdminEditUMKM()
        {
            InitializeComponent();
        }

        private void btnUbahprfl_Click(object sender, EventArgs e)
        {
            //editWisata editWisata = new editWisata();
            //editWisata.Show();
            //this.Close();
        }

        private void btnUbhSandi_Click(object sender, EventArgs e)
        {
            //staff ubahSandi = new staff();
            //ubahSandi.Show();
        }

        private void btnKebijakanPrivasi_Click(object sender, EventArgs e)
        {
            //KebijakanPrivasi kebijakanPrivasi = new KebijakanPrivasi();
            //kebijakanPrivasi.Show();
        }

        private void btnSyarat_Click(object sender, EventArgs e)
        {
            //Destinasi syaratDanKetentuan = new Destinasi();
            //syaratDanKetentuan.Show();
        }

        private void btnTentangKami_Click(object sender, EventArgs e)
        {
            //TentangKami tentangKami = new TentangKami();
            //tentangKami.Show();
        }
        
        private void editUMKM_Load(object sender, EventArgs e)
        {
            
        }

       

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();

        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox1.Image = Image.FromFile(filePath);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox2.Image = Image.FromFile(filePath);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox3.Image = Image.FromFile(filePath);
            }
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                pictureBox4.Image = Image.FromFile(filePath);
            }
        }
        private byte[] CombineByteArrays(params byte[][] arrays)
        {
            int totalLength = arrays.Sum(a => a.Length);
            byte[] combinedArray = new byte[totalLength];
            int offset = 0;

            foreach (byte[] array in arrays)
            {
                Buffer.BlockCopy(array, 0, combinedArray, offset, array.Length);
                offset += array.Length;
            }

            return combinedArray;
        }
        private byte[] ImageToByteArray(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string deskripsi = richTextBox1.Text;
            string lokasi = richTextBox2.Text;
            string judul = textBox1.Text;
            Image fotoheader = pictureBox1.Image;
            Image fotoproduk1 = pictureBox2.Image;
            Image fotoproduk2 = pictureBox3.Image;
            Image fotoproduk3 = pictureBox4.Image;
            string idwisata = "A01";

            if (string.IsNullOrWhiteSpace(deskripsi) || string.IsNullOrWhiteSpace(lokasi) || string.IsNullOrWhiteSpace(judul) || fotoheader == null || fotoproduk1 == null || fotoproduk2 == null || fotoproduk3 == null)
            {
                MessageBox.Show("Harap isi semua field!");
                return;
            }

            byte[] fotoheaderBytes = ImageToByteArray(fotoheader);
            byte[] fotoproduk1Bytes = ImageToByteArray(fotoproduk1);
            byte[] fotoproduk2Bytes = ImageToByteArray(fotoproduk2);
            byte[] fotoproduk3Bytes = ImageToByteArray(fotoproduk3);

            byte[] fotoprodukBytes = CombineByteArrays(fotoproduk1Bytes, fotoproduk2Bytes, fotoproduk3Bytes);

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                INSERT INTO UMKM (umkm_id, deskripsi, lokasi, nama_umkm, foto_header, foto_produk, wisata_id_wisata)
                VALUES (DEFAULT, @deskripsi, @lokasi, @judul, @fotoheader, @fotoproduk, @idwisata)";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);

                    command.Parameters.AddWithValue("@deskripsi", deskripsi);
                    command.Parameters.AddWithValue("@lokasi", lokasi);
                    command.Parameters.AddWithValue("@judul", judul);
                    command.Parameters.AddWithValue("@fotoheader", NpgsqlDbType.Bytea, fotoheaderBytes);
                    command.Parameters.AddWithValue("@fotoproduk", NpgsqlDbType.Bytea, fotoprodukBytes);
                    command.Parameters.AddWithValue("@idwisata", idwisata);


                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Data telah disimpan ke database.");


                    }
                    else
                    {
                        MessageBox.Show("Gagal menyimpan data ke database.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string umkmNameToDelete = Microsoft.VisualBasic.Interaction.InputBox("Masukkan nama UMKM yang ingin dihapus:", "Hapus UMKM", "");

            if (string.IsNullOrEmpty(umkmNameToDelete))
            {
                MessageBox.Show("Nama UMKM tidak valid.");
                return;
            }

            DialogResult confirmationResult = MessageBox.Show("Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmationResult == DialogResult.Yes)
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        string query = "DELETE FROM UMKM WHERE nama_umkm = @judul";
                        NpgsqlCommand command = new NpgsqlCommand(query, connection);
                        command.Parameters.AddWithValue("@judul", umkmNameToDelete);

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Data telah dihapus dari database.");
                        }
                        else
                        {
                            MessageBox.Show("Gagal menghapus data dari database.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Penghapusan data dibatalkan.");
            }
        }
    }
}