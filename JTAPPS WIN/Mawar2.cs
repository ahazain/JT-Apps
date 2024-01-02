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
    public partial class Mawar2 : Form
    {
        public Mawar2()
        {
            InitializeComponent();
        }

        private void PanelNavBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeMawar homeMawar = new HomeMawar();
            homeMawar.Show();
            this.Close();
        }

        private void Mawar2_Load(object sender, EventArgs e)
        {

        }
    }
}

