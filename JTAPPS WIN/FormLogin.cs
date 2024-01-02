using Npgsql;
using HomepageUser;
using JT_APPS__Final_Voucher_;
using Login_dan_Register_Project_PBO_A;
using Microsoft.VisualBasic.ApplicationServices;
using Inap;

namespace DesktopApp
{

    public partial class Formlogin : Form
    {
        public static string TempEmail { get; private set; }
        public static string TempPassword { get; private set; }

        public Formlogin()
        {
            InitializeComponent();
        }

        private int userId; // Variabel untuk menyimpan ID pengguna
        string CnS = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
        string selectQuery = "SELECT user_id FROM \"User\" WHERE (email = email Or nama_lengkap = nama_lengkap) AND kata_sandi = @kata_sandi";
        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormRegister().Show();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    // Get values 
                    string email = txtEmail.Text;
                    string password = txtPassword.Text;

                    // ngecek empty input
                    if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                    {
                        MessageBox.Show("Please enter your email and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // ngeset parameter values
                    command.Parameters.AddWithValue("email", email);
                    command.Parameters.AddWithValue("kata_sandi", password);

                    try
                    {
                        // eksekuasi query
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            TempEmail = email;
                            TempPassword = password;

                            userId = Convert.ToInt32(result);

                            // Clear TextBoxes
                            txtEmail.Text = "";
                            txtPassword.Text = "";

                            // Cek jika pengguna adalah admin
                            if (email == "admin@jtapps.com" && password == "4dm1ndotcom")
                            {
                                MessageBox.Show("Login successful as admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                new Homepage_Admin_Penginapan().Show();
                            }
                            else
                            {
                                MessageBox.Show("Login successful as regular user.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.Hide();
                                new HomepageUtama().Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please check your email and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }



        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            new FormForgetPassword().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '\0')
            {
                button3.BringToFront();
                txtPassword.PasswordChar = '*';
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar == '*')
            {
                button2.BringToFront();
                txtPassword.PasswordChar = '\0';
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

