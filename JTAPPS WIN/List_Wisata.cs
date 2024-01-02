using HomepageUser;
using JT_APPS__Final_Voucher_;
using Npgsql;
using JTAPPS_WIN;

namespace wisata2
{
    public partial class List_Wisata : Form
    {
        private string connectionString;
        public List_Wisata()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";

        }
        private void panel1_Click(object sender, EventArgs e)
        {
            Detail_Rembangan detail = new Detail_Rembangan();
            detail.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Detail_Rembangan detail = new Detail_Rembangan();
            detail.Show();
            this.Hide();
        }
        //
        private void panel2_Click(object sender, EventArgs e)
        {
            Detail_Watu_Ulo detail2 = new Detail_Watu_Ulo();
            detail2.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            Detail_Watu_Ulo detail2 = new Detail_Watu_Ulo();
            detail2.Show();
            this.Hide();
        }
        //
        private void panel3_Click(object sender, EventArgs e)
        {
            Detail_Patemon detail3 = new Detail_Patemon();
            detail3.Show();
            this.Hide();
        }
        private void label7_Click(object sender, EventArgs e)
        {
            Detail_Patemon detail3 = new Detail_Patemon();
            detail3.Show();
            this.Hide();
        }
        //
        private void panel4_Click(object sender, EventArgs e)
        {
            Detail_Kebon_Agung detail4 = new Detail_Kebon_Agung();
            detail4.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Detail_Kebon_Agung detail4 = new Detail_Kebon_Agung();
            detail4.Show();
            this.Hide();
        }

        private void Homepagebtn_Click(object sender, EventArgs e)
        {
            Form homeutama = new HomepageUtama();
            homeutama.Show();
            this.Hide();
        }

        private void paketbtn_Click(object sender, EventArgs e)
        {

        }

        private void Voucherbtn_Click(object sender, EventArgs e)
        {
            Form voucher = new HomeMyVoucher();
            voucher.Show();
            this.Hide();
        }

        private void Checkoutbtn_Click(object sender, EventArgs e)
        {
            Form penyimpanan = new WishlistTiket();
            penyimpanan.Show();
            this.Hide();
        }

        private void List_Wisata_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;port=5432;database=JT-Apps;user id=postgres;password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select nama_wisata from wisata WHERE id_wisata like 'A01'";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String wisata = reader.GetString(0);
                        label2.Text = wisata;
                    }
                }

                cmd.CommandText = "select nama_wisata from wisata WHERE id_wisata like 'A02'";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String wisata = reader.GetString(0);
                        label5.Text = wisata;
                    }
                }

                cmd.CommandText = "select nama_wisata from wisata WHERE id_wisata like 'A03'";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String wisata = reader.GetString(0);
                        label7.Text = wisata;
                    }
                }

                cmd.CommandText = "select nama_wisata from wisata WHERE id_wisata like 'A04'";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String wisata = reader.GetString(0);
                        label9.Text = wisata;
                    }
                }
            }
        }
        private List<Panel> ReadDataFromDatabase()
        {
            List<Panel> panels = new List<Panel>();

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM image_slider";
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Panel newPanel = CreatePanelFromData(reader);
                    panels.Add(newPanel);
                }

                reader.Close();
            }

            return panels;
        }

        private Panel CreatePanelFromData(NpgsqlDataReader reader)
        {
            Panel newPanel = new Panel();
            newPanel.Size = panel1.Size;

            Label label2 = new Label();
            label2.Text = reader.GetString(0); // Assuming the column index of the label text is 0
            label2.Font = new Font("Poppins Black", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            newPanel.Controls.Add(label2);

            return newPanel;
        }

        private void AddPanelsToPanelMain(List<Panel> panels)
        {
            foreach (Panel panel in panels)
            {
                panelmain.Controls.Add(panel);
            }
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            List<Panel> panels = ReadDataFromDatabase();
            AddPanelsToPanelMain(panels);
        }

        public static void wisata2()
        {
            Application.Run(new List_Wisata());
        }
    }
}
