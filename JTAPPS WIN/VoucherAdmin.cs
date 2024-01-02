using Npgsql;

namespace VoucherAdmin
{
    public partial class voucheradmin : Form
    {
        public voucheradmin()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama_voucher = textBox1.Text;
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection("Server = localhost; Port = 5432; Database = JT-Apps; User Id = postgres; Password = timotius")) //kalo mau di push ganti password
                {
                    connection.Open();
                    NpgsqlCommand command = new NpgsqlCommand();
                    command.Connection = connection;
                    command.CommandText = "delete from voucher where deskripsi = @deskripsi";
                    command.Parameters.AddWithValue("@deskripsi", nama_voucher);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Voucher berhasil ditukarkan.");
                    }
                    else
                    {
                        MessageBox.Show("Voucher tidak ditemukan.");
                    }
                    connection.Close();
                    textBox1.Text = "";
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi Kesalahan : " + ex.Message);
            }
        }

        private void VoucherAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}