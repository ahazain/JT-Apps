using Npgsql;

namespace Change_UsernPw
{
    public partial class Kata_Sandi : Form
    {
        string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
        public Kata_Sandi()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kata_Sandi_Load(object sender, EventArgs e)
        {

        }

        private void btn_ganti_Click(object sender, EventArgs e)
        {

            try
            {
                using (var con = new NpgsqlConnection(connectionString))
                {
                    if (!string.IsNullOrEmpty(konfirmasi_password.Text) && !string.IsNullOrEmpty(kata_sandi_baru.Text))
                    {
                        if (kata_sandi_baru.Text == konfirmasi_password.Text)
                        {
                            if (kata_sandi_baru.Text.Length >= 6 && konfirmasi_password.Text.Length >= 6)
                            {
                                if (kata_sandi_baru.Text.Length <= 12 && konfirmasi_password.Text.Length <= 12)
                                {
                                    con.Open();
                                    string sqll = "UPDATE akun_admin SET kata_sandi = @kata_sandi WHERE id_akunadmin = @id_akunadmin";
                                    using (var cmdd = new NpgsqlCommand(sqll, con))
                                    {
                                        cmdd.Parameters.AddWithValue("@id_akunadmin", "ADM01");
                                        cmdd.Parameters.AddWithValue("@kata_sandi", kata_sandi_baru.Text);
                                        int rowsAffected = cmdd.ExecuteNonQuery();
                                        if (rowsAffected > 0)
                                        {
                                            MessageBox.Show("Berhasil mengubah  tsandi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            kata_sandi_baru.Text = "";
                                            konfirmasi_password.Text = "";
                                        }
                                        else
                                        {
                                            MessageBox.Show("Gagal mengubah sandi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                        }
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Sandi tidak boleh lebih dari 12 karakter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Sandi harus terdiri dari setidaknya 6 karakter.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tolong masukkan kedua sandi dengan benar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mohon isi seluruh kolom terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan, tolong masukkan data dengan benar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kata_sandi_baru_TextChanged(object sender, EventArgs e)
        {
            kata_sandi_baru.UseSystemPasswordChar = true;

        }

        private void konfirmasi_password_TextChanged(object sender, EventArgs e)
        {
            konfirmasi_password.UseSystemPasswordChar = true;

        }

        private void kata_sandi_baru_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            kata_sandi_baru.UseSystemPasswordChar = true;
            button6.Visible = false;
            button8.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            konfirmasi_password.UseSystemPasswordChar = true;
            button7.Visible = false;
            button9.Visible = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            kata_sandi_baru.UseSystemPasswordChar = false;
            button8.Visible = false;
            button6.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            konfirmasi_password.UseSystemPasswordChar = false;
            button9.Visible = false;
            button7.Visible = true;
        }
    }
}
