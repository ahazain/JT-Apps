using System;
using System.Data;
using Npgsql;
using DesktopApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using HomepageUser;
using ListPenginapan;
using JT_APPS__Final_Voucher_;
using History_Fix;
using JTAPPS_WIN;

namespace JT_APPS__Final_Setting_
{
    public partial class UbahProfil : Form
    {
        public static string TempEmail { get; set; }
        string imagelocation = " ";
        private NpgsqlConnection connection;
        private string sql;
        private NpgsqlCommand cmd;
        private DataTable dt;
        private string connectionString = "Server=localhost; Port=5432; Database=JT-Apps; User Id=postgres; Password=timotius";

        public UbahProfil()
        {
            InitializeComponent();
            connection = new NpgsqlConnection("Server=localhost; Port=5432; Database=JT-Apps; User Id=postgres; Password=timotius");
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeSetting homeSetting = new HomeSetting();
            homeSetting.Show();
            this.Hide();
        }

        private void UbahProfil_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowData();
        }

        //MENAMPILKAN SEMUA ISI KODE
        private void LoadData()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    string email = Formlogin.TempEmail;
                    connection.Open();

                    string query = "SELECT nama_lengkap, email, nomor_telepon, kota, provinsi FROM \"User\" WHERE email=@email";

                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@email", email);

                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                TBNama.Text = reader["nama_lengkap"].ToString();
                                TBemail.Text = reader["email"].ToString();
                                TBNtelpon.Text = reader["nomor_telepon"].ToString();
                                TBKab.Text = reader["kota"].ToString();
                                TBProfinsi.Text = reader["provinsi"].ToString();
                            }
                        }
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan Loaddata: " + ex.Message);
            }
        }


        //TOMBOL UNTUK MENYIMOAN HASIL UPDATE DATA DAN FOTONYA
        private void BtnSimpan_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream stream = new FileStream(imagelocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(stream);
            images = brs.ReadBytes((int)stream.Length);
            string email = Formlogin.TempEmail;

            connection.Open();
            NpgsqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = ("UPDATE \"User\" SET nama_lengkap=@namaL, email=@Email, nomor_telepon=@Ntelpon, kota=@Kabupaten, provinsi=@Provinsi ,foto_profil=@images WHERE email=@email");
            cmd.Parameters.Add(new NpgsqlParameter("@images", images));
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@namaL", TBNama.Text);
            cmd.Parameters.AddWithValue("@Email", TBemail.Text);

            string nomorTelepon = TBNtelpon.Text;
            if (Int64.TryParse(nomorTelepon, out long nomorTeleponBigInt))
            {
                cmd.Parameters.AddWithValue("@Ntelpon", nomorTeleponBigInt);
            }
            else
            {
                cmd.Parameters.AddWithValue("@Ntelpon", DBNull.Value);
            }

            cmd.Parameters.AddWithValue("@Kabupaten", TBKab.Text);
            cmd.Parameters.AddWithValue("@Provinsi", TBProfinsi.Text);
            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Data berhasil disimpan.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //MENGHAPUS SEMUA DATA DAN FOTO
        private void BtnHapus_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Apakah anda yakin ingin menghapus semua data profil?", "Hapus Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                    {
                        string email = Formlogin.TempEmail;
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "Delete from \"User\" where email=@email";
                        cmd.CommandType = CommandType.Text;
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                        MessageBox.Show("Semua data profil berhasil dihapus.", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Formlogin Form1 = new Formlogin();
                        Form1.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan BTNHapus: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // MEMILIH FOTO YG AKAN DI UPLOAD
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image Files (*.png; *.jpg; *.jpeg; *.gif; *.bmp)|*.png; *.jpg; *.jpeg; *.gif; *.bmp";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imagelocation = dialog.FileName.ToString();
                PBprofil.ImageLocation = imagelocation;
            }
        }

        //MENAMPLIKAN FOTO SETELAH DI PILIH
        private void ShowData()
        {
            try
            {
                string email = Formlogin.TempEmail;
                connection.Open();
                sql = "SELECT foto_profil FROM \"User\" where email=@email";
                cmd = new NpgsqlCommand(sql, connection);
                dt = new DataTable();
                cmd.Parameters.AddWithValue("@email", email);
                dt.Load(cmd.ExecuteReader());
                connection.Close();

                if (dt.Rows.Count > 0 && dt.Rows[0]["foto_profil"] != DBNull.Value)
                {
                    byte[] imageData = (byte[])dt.Rows[0]["foto_profil"];
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        PBprofil.Image = System.Drawing.Image.FromStream(ms);
                    }
                }
                else
                {
                    PBprofil.Image = null;
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show("Error Showdata: " + ex.Message);
            }
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
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

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }
    }
}