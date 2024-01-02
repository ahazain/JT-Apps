using JTAPPS_WIN.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTAPPS_WIN
{

    public partial class Kritik_SaranForm2 : Form
    {
        KritikSaranContext kritiksarancontext;
        public Kritik_SaranForm2()
        {
            InitializeComponent();
            kritiksarancontext = new KritikSaranContext();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnkritikdanSaran_Click(object sender, EventArgs e)
        {
            
        }

        private void Kritik_SaranForm2_Load(object sender, EventArgs e)
        {

        }
    }
}
