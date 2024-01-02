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
    public partial class Melati2DB : Form
    {
        public Melati2DB()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Melatihome homemelati = new Melatihome();
            homemelati.Show();
            this.Close();
        }
    }
}
