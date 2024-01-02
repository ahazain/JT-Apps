using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListPenginapan;
using Npgsql;

namespace ListPenginapan
{
    public partial class Mawar1 : Form

    {
        public Mawar1()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Close();
        }

        public void Setpenginapan(penginapan penginapan)
        {
            labelJudulNavBar.Text = penginapan.label_navbar;
            label2.Text = penginapan.deskripsi_paket;
            label9.Text = penginapan.nomor_kamar;
            label13.Text = penginapan.harga_paket.ToString();
        }


        private void Mawar1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

    }
}
