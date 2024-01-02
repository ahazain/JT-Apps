using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace membership5
{
    public partial class membershipbelum : Form
    {
        NpgsqlConnection koneksi = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
        public membershipbelum()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            beli beli = new beli();
            beli.Show();
        }

        private void membershipbelum_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        // this.Hide(); //jangan pake hide karena masih jalan di background procces
    }


}

