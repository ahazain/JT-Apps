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
    public partial class membership : Form
    {
        public membership()
        {
            InitializeComponent();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            beli beli = new beli();
            beli.Show();
            this.Hide();
        }

        private void membership_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


}

