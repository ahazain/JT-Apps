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
    public partial class popmembership : Form
    {
        public popmembership()
        {
            InitializeComponent();
        }

        private void Btnkembali_Click(object sender, EventArgs e)
        {
            beli beli = new beli();
            beli.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
