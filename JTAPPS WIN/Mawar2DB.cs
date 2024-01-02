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
    public partial class Mawar2DB : Form
    {
        public Mawar2DB()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeMawar homeMawar = new HomeMawar();
            homeMawar.Show();
            this.Close();
        }

        private void Mawar2DB_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
