﻿using Admin__FAQ__V2;
using bagianAB;
using Fitur_Homepage_admin_penginapan;
using JT_APPS__Final_Setting_;
using Npgsql;
using System.Data;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.IO;

namespace Inap
{
    public partial class Homepage_Admin_Penginapan : Form
    {
        InapContext inapcontext;
        int number;
        public Homepage_Admin_Penginapan()
        {
            InitializeComponent();
            inapcontext = new InapContext();

        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminUMKM adminUMKM = new AdminUMKM();
            adminUMKM.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowItems();
            //using (NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius"))
            //{
            //    connection.Open();
            //    NpgsqlCommand command = connection.CreateCommand();
            //    command.CommandText = "select nama_jenis_kamar from \"Jenis_Kamar\" where id_jenis_kamar like 'SR01'";
            //    using (NpgsqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            string jenis = reader.GetString(0);
            //            label2.Text = jenis;

            //        }
            //    }
            //    NpgsqlCommand command1 = connection.CreateCommand();
            //    command.CommandText = "select nomor_kamar from \"Paket_Kamar\" where id_jenis_kamar like 'SR01'";
            //    using (NpgsqlDataReader reader = command.ExecuteReader())
            //    {
            //        if (reader.Read())
            //        {
            //            string nmrkamar = reader.GetString(0);
            //            label2.Text = nmrkamar;

            //        }
            //    }
            //}
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (Edit_detail_penginapan == null || Edit_detail_penginapan.IsDisposed)
            //{
            //    Edit_detail_penginapan = new Edit_detail_penginapan();
            //}

            //Edit_detail_penginapan.Show();
            //this.Visible = false;

        }

        private void panel4_Paint(object sender, EventArgs e)
        {
            Edit_detail_penginapan penginapan = new Edit_detail_penginapan();
            penginapan.Show();
            this.Hide();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {






            /*NpgsqlConnection conn = new NpgsqlConnection("host=localhost, port=5432, dbname='read penginapan', user=postgres, password=robet123 sslmode=prefer connect_timeout=10");
            conn.Open();
            string query = "SELECT id_jenis_kamar, nomor_kamar, harga_paket, deskripsi_paket, status FROM  Paket_Kamar WHERE id_jenis_kamar = 'SR01' lIMIT 1";
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.CommandText = query;
            NpgsqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                string data = (string)reader["id_jenis_kamar"];
                Judul.Text = data;
            }*/
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            melati();
        }

        public void melati()
        {
            //Edit_detail_penginapan melati = new Edit_detail_penginapan();
            //melati.queryCommand = $"select * from \"Paket_Kamar\" pk join \"Jenis_Kamar\" jk on pk.\"id_jenis_kamar\" = jk.\"id_jenis_kamar\"\r\nwhere jk.\"id_jenis_kamar\" = 'MT01'";
            ////melati.Show();
            ////this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void ShowItems()
        {
            inapcontext.Read();
            List<Inap> listInap;
            listInap = inapcontext.listInap;

            flowLayoutPanel1.Controls.Clear();
            foreach (var inap in listInap)
            {
                string nama = inap.NamaJenisKamar;
                Panel panelkmr = new InapItem(inap).CreateItem();
                panelkmr.BackgroundImage = inap.Image;
                flowLayoutPanel1.Controls.Add(panelkmr);
            }

            //private void button4_Click(object sender, EventArgs e)
            //{
            //    Edit_detail_penginapan = new Edit_detail_penginapan();
            //    Edit_detail_penginapan.Show();        
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint_2(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Click_2(object sender, EventArgs e)
        {
            Edit_detail_penginapan edit = new Edit_detail_penginapan();
            edit.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Homepage_Admin_Penginapan homepage_Admin_Penginapan = new Homepage_Admin_Penginapan();
            homepage_Admin_Penginapan.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DestinasiWisataAdmin destinasiWisataAdmin = new DestinasiWisataAdmin();
            destinasiWisataAdmin.Show();
            this.Hide();
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
    }
}