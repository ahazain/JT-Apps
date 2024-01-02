
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

namespace Fitur_Poin
{
    public partial class poin : Form
    {
        public poin()
        {
            InitializeComponent();
        }




        private void backbtnnavbar_Click(object sender, EventArgs e)
        {
            poin poin = new poin();
            poin.Show();

        }

        private void pictureBoxvcr1_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin poppoin = new poppoin();
                poppoin.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void labelvcrjudul1_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin poppoin = new poppoin();
                poppoin.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Panelvcr1_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin poppoin = new poppoin();
                poppoin.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void pictureBoxvcr2_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin2 poppoin2 = new poppoin2();
                poppoin2.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin2.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelvcrjudul2_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin2 poppoin2 = new poppoin2();
                poppoin2.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin2.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Panelvcr2_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin2 poppoin2 = new poppoin2();
                poppoin2.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin2.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void pictureBoxvcr3_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin3 poppoin3 = new poppoin3();
                poppoin3.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin3.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelvcrjudul3_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin3 poppoin3 = new poppoin3();
                poppoin3.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin3.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Panelvcr3_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin3 poppoin3 = new poppoin3();
                poppoin3.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin3.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void pictureBoxvcr4_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin4 poppoin4 = new poppoin4();
                poppoin4.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin4.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void labelvcrjudul4_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin4 poppoin4 = new poppoin4();
                poppoin4.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin4.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void Panelvcr4_Click(object sender, EventArgs e)
        {
            // Display a message box for payment confirmation
            DialogResult result = MessageBox.Show("Apakah anda yakin akan menukar poin dengan voucher ini?", "Konfirmasi Penukaran", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response
            if (result == DialogResult.Yes)
            {
                poppoin4 poppoin4 = new poppoin4();
                poppoin4.StartPosition = FormStartPosition.CenterScreen; //biar pop upnya center
                poppoin4.Show();
                // User clicked Yes, proceed with the payment logic
                // ...
                //MessageBox.Show("Payment successful!", "Payment Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // User clicked No or closed the message box, cancel the payment or perform any necessary actions
                // ...
                MessageBox.Show("Penukaran dibatalakan.", "Konfirmasi Penukaran", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void poin_Load(object sender, EventArgs e)
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius."))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = "select poin from \"User\"WHERE user_id = 1";

                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        String wisata = reader.GetString(0);
                        Text = wisata;
                    }
                }
            }
        }

        private void panelvcr1_Paint(object sender, PaintEventArgs e)
        {
            poppoin poppoin = new poppoin();
            poppoin.Show();
            this.Hide();
        }

        private void panelvcr2_Paint(object sender, PaintEventArgs e)
        {
            poppoin2 poppoin2 = new poppoin2();
            poppoin2.Show();
            this.Hide();
        }

        private void panelvcr3_Paint(object sender, PaintEventArgs e)
        {
            poppoin3 poppoin3 = new poppoin3();
            poppoin3.Show();
            this.Hide();
        }

        private void panelvcr4_Paint(object sender, PaintEventArgs e)
        {
            poppoin4 poppoin4 = new poppoin4();
            poppoin4.Show();
            this.Hide();
        }
    }
}

