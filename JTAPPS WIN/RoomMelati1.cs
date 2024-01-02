using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JT_APPS__Final_Setting_
{
    public partial class Melati1 : Form
    {
        public Melati1()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            Melatihome form1 = new Melatihome();
            form1.Show();
            this.Close();
        }

        private void labelJudulNavBar_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Melatihome homeMelati = new Melatihome();
            homeMelati.Show();
            this.Close();
        }
    }
}
