using System;
using Npgsql;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using Fitur_Homepage_admin_penginapan;
using Admin__FAQ__V2;

namespace bagianAB
{
    public partial class PersetujuanBookingAdmin : Form
    {
        public void koneksidatabase()
        {
            string conectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
            NpgsqlConnection connection = new NpgsqlConnection(conectionString);

        }
        public PersetujuanBookingAdmin()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rectangle1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void rectangle3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelNavbar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                int status = 1; // Ubah status sesuai dengan kebutuhan

                string query = "UPDATE booking_hotel SET status = @status WHERE paket_kamar_paket_kamar_id = 1";

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Integer, status);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status berhasil diperbarui.");
                    }

                    else
                    {
                        MessageBox.Show("Gagal memperbarui status.");
                    }
                }
            }
            this.Controls.Remove(groupBox1);
            groupBox1.Dispose();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                int status = 1; // Ubah status sesuai dengan kebutuhan

                string query = "UPDATE booking_hotel SET status = @status WHERE paket_kamar_paket_kamar_id = 2";

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Integer, status);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status.");
                    }
                }
            }
            this.Controls.Remove(groupBox2);
            groupBox2.Dispose();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                int status = 1; // Ubah status sesuai dengan kebutuhan

                string query = "UPDATE booking_hotel SET status = @status WHERE paket_kamar_paket_kamar_id = 3";

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Integer, status);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status.");
                    }
                }
            }
            this.Controls.Remove(groupBox3);
            groupBox3.Dispose();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";

            using (NpgsqlConnection conn = new NpgsqlConnection(connectionString))
            {
                conn.Open();

                int status = 1; // Ubah status sesuai dengan kebutuhan

                string query = "UPDATE booking_hotel SET status = @status WHERE paket_kamar_paket_kamar_id = 4";

                using (NpgsqlCommand command = new NpgsqlCommand(query, conn))
                {
                    command.Parameters.AddWithValue("@status", NpgsqlTypes.NpgsqlDbType.Integer, status);

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Status berhasil diperbarui.");
                    }
                    else
                    {
                        MessageBox.Show("Gagal memperbarui status.");
                    }
                }
            }
            this.Controls.Remove(groupBox4);
            groupBox4.Dispose();
        }

        private void FormPersetujuanbooking_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();

        }
    }
}