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
using Npgsql;

namespace data_staf
{
    public partial class HapusStafAdmin : Form
    {
        NpgsqlConnection koneksi = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius");
        public HapusStafAdmin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            NpgsqlCommand cmd = new NpgsqlCommand();
            koneksi.Open();
            cmd.Connection = koneksi;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from staff where nama = '" + tb_hapus_idstaf.Text + "'";


            if (tb_hapus_idstaf.Text == "")
            {
                MessageBox.Show("Masukan Staf Id Terlebih Dahulu");

            }
            else
            {
                cmd.ExecuteNonQuery();
                this.Hide();
                MessageBox.Show("Data Berhasil Dihapus");
                this.Close();
            }
            koneksi.Close();

        }

        private void tb_hapus_idstaf_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
