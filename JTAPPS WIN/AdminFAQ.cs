using bagianAB;
using Fitur_Homepage_admin_penginapan;
using Npgsql;

namespace Admin__FAQ__V2
{
    public partial class AdminFAQ : Form
    {
        string connectionString = "Host=localhost:5432;Username=postgres;Password=timotius;Database=JT-Apps";
        public static int IDFAQ { get; set; }
        public AdminFAQ()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void LoadFAQs()
        {
            List<FAQ> faqs = new List<FAQ>();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT faq_id, pertanyaan FROM faq ORDER BY faq_id DESC";
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int id = reader.GetInt32(0);
                                string question = reader.GetString(1);

                                FAQ faq = new FAQ(id, question);
                                faqs.Add(faq);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DisplayFAQs(faqs);
        }
        private void DisplayFAQs(List<FAQ> faqs)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (FAQ faq in faqs)
            {
                Label questionLabel = new Label();
                questionLabel.Text = faq.Question;
                questionLabel.Tag = faq.ID;
                questionLabel.Click += QuestionLabel_Click;
                questionLabel.AutoSize = true;
                questionLabel.Font = new Font(questionLabel.Font, FontStyle.Underline);

                flowLayoutPanel1.Controls.Add(questionLabel);
            }
        }
        private void QuestionLabel_Click(object sender, EventArgs e)
        {
            Label clickedLabel = (Label)sender;
            int faqID = (int)clickedLabel.Tag;
            IDFAQ = faqID;
            this.Hide();
            new Form2().Show();
        }
        public class FAQ
        {
            public int ID { get; set; }
            public string Question { get; set; }

            public FAQ(int id, string question)
            {
                ID = id;
                Question = question;
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new Form3().Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFAQs();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Form destinasi_admin = new DestinasiWisataAdmin();
            destinasi_admin.Show();
            this.Hide();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            Form persetujuan_booking = new PersetujuanBookingAdmin();
            persetujuan_booking.Show();
            this.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            Form FAQ_admin = new AdminFAQ();
            FAQ_admin.Show();
            this.Hide();
        }
    }
}