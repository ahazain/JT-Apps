using JT_APPS__Final_Voucher_;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VoucherAdmin;

namespace Fitur_Poin
{
    public partial class poppoin : Form
    {
        public poppoin()
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
            HomeMyVoucher homeMyVoucher = new HomeMyVoucher();
            homeMyVoucher.Show();
            this.Hide();
        }
    }
}
