using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fitur_Poin
{
    public partial class poppoin3 : Form
    {
        public poppoin3()
        {
            InitializeComponent();
        }


        private void Btnkembali_Click(object sender, EventArgs e)
        {
            Form form = new poin();
            form.Show();
            this.Hide();
        }

        private void labellihatvcr_Click(object sender, EventArgs e)
        {
            //tombol buat ke menu voucher
        }
    }
}
