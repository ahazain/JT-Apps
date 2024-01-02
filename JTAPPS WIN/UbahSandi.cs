using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Npgsql;
using DesktopApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics.Tracing;
using Login_dan_Register_Project_PBO_A;
using JTAPPS_WIN;
using HomepageUser;
using ListPenginapan;
using JT_APPS__Final_Voucher_;
using History_Fix;

namespace JT_APPS__Final_Setting_
{
    public partial class UbahSandi : Form
    {
        ubahsandicontext Ubahsandicontext;
        public UbahSandi()
        {
            Ubahsandicontext = new ubahsandicontext();
            InitializeComponent();

        }
        private bool ValidateInputs()
        {
            return !string.IsNullOrEmpty(TBKonfirmasiSandi.Text) &&
                   !string.IsNullOrEmpty(TBSandiBaru.Text) &&
                   !string.IsNullOrEmpty(TBKataSandiLama.Text) &&
                   TBSandiBaru.Text == TBKonfirmasiSandi.Text &&
                   TBSandiBaru.Text.Length >= 6 && TBSandiBaru.Text.Length <= 12 &&
                   TBKataSandiLama.Text.Length >= 6 && TBKataSandiLama.Text.Length <= 12;
        }
        private void ClearInputs()
        {
            TBKonfirmasiSandi.Text = "";
            TBSandiBaru.Text = "";
            TBKataSandiLama.Text = "";
        }
        private void BtnBack_Click(object sender, EventArgs e)
        {
            HomeSetting homeSetting = new HomeSetting();
            homeSetting.Show();
            this.Hide();
        }

        private void BtnGanti_Click(object sender, EventArgs e)
        {
            string passwordlama = TBKataSandiLama.Text;
            string passwordbaru = TBSandiBaru.Text;
            string email = Formlogin.TempEmail;
            ubahsandiprop ubahsandiProps = new ubahsandiprop()
            {
                passwordlama = passwordlama,
                passwordbaru = passwordbaru,
                email = email


            };
            try
            {
                if (ValidateInputs())
                {
                    bool IsSuccess = Ubahsandicontext.IsPasswordValid(ubahsandiProps);
                    if (IsSuccess)
                    {
                        bool isSuccess = Ubahsandicontext.UpdatePassword(ubahsandiProps);
                        if (isSuccess)
                        {
                            MessageBox.Show("Berhasil mengubah sandi.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearInputs();
                        }
                        else
                        {
                            MessageBox.Show("Gagal mengubah sandi.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sandi yang Anda masukkan salah.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearInputs();
                    }
                }
                else
                {
                    MessageBox.Show("Mohon isi seluruh kolom dengan lengkap terlebih dahulu.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan, tolong masukkan data dengan benar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearInputs();

            }
        }

        private void TBSandiBaru_Click(object sender, EventArgs e)
        {
            if (TBSandiBaru.Text == "Kata sandi (min. 6 karakter)")
            {
                TBSandiBaru.Text = string.Empty;
                TBSandiBaru.ForeColor = Color.Black;
            }
        }

        private void TBKonfirmasiSandi_Click(object sender, EventArgs e)
        {
            if (TBKonfirmasiSandi.Text == "Kata sandi (min. 6 karakter)")
            {
                TBKonfirmasiSandi.Text = string.Empty;
                TBKonfirmasiSandi.ForeColor = Color.Black;
            }
        }

        private void panelSandi_Click(object sender, EventArgs e)
        {
            if (TBSandiBaru.Text == "")
            {
                TBSandiBaru.Text = "Kata sandi (min. 6 karakter)";
                TBSandiBaru.ForeColor = Color.DimGray;
            }
            if (TBKonfirmasiSandi.Text == "")
            {
                TBKonfirmasiSandi.Text = "Kata sandi (min. 6 karakter)";
                TBKonfirmasiSandi.ForeColor = Color.DimGray;
            }
            if (TBKataSandiLama.Text == "")
            {
                TBKataSandiLama.Text = "Kata sandi (min. 6 karakter)";
                TBKataSandiLama.ForeColor = Color.DimGray;
            }
        }

        private void PanelMain_Click(object sender, EventArgs e)
        {
            if (TBSandiBaru.Text == "")
            {
                TBSandiBaru.Text = "Kata sandi (min. 6 karakter)";
                TBSandiBaru.ForeColor = Color.DimGray;
            }
            if (TBKonfirmasiSandi.Text == "")
            {
                TBKonfirmasiSandi.Text = "Kata sandi (min. 6 karakter)";
                TBKonfirmasiSandi.ForeColor = Color.DimGray;
            }
            if (TBKataSandiLama.Text == "")
            {
                TBKataSandiLama.Text = "Kata sandi (min. 6 karakter)";
                TBKataSandiLama.ForeColor = Color.DimGray;
            }
        }

        private void panelGanti_Click(object sender, EventArgs e)
        {
            if (TBSandiBaru.Text == "")
            {
                TBSandiBaru.Text = "Kata sandi (min. 6 karakter)";
                TBSandiBaru.ForeColor = Color.DimGray;
            }
            if (TBKonfirmasiSandi.Text == "")
            {
                TBKonfirmasiSandi.Text = "Kata sandi (min. 6 karakter)";
                TBKonfirmasiSandi.ForeColor = Color.DimGray;
            }
            if (TBKataSandiLama.Text == "")
            {
                TBKataSandiLama.Text = "Kata sandi (min. 6 karakter)";
                TBKataSandiLama.ForeColor = Color.DimGray;
            }
        }

        private void TBKataSandiLama_Click(object sender, EventArgs e)
        {
            if (TBKataSandiLama.Text == "Kata sandi (min. 6 karakter)")
            {
                TBKataSandiLama.Text = string.Empty;
                TBKataSandiLama.ForeColor = Color.Black;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TBKataSandiLama.UseSystemPasswordChar = false;
            button3.Visible = false;
            button4.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBSandiBaru.UseSystemPasswordChar = false;
            button1.Visible = false;
            button5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TBKonfirmasiSandi.UseSystemPasswordChar = false;
            button2.Visible = false;
            button6.Visible = true;
        }

        private void TBSandiBaru_TextChanged(object sender, EventArgs e)
        {
            TBSandiBaru.UseSystemPasswordChar = true;
        }

        private void TBKonfirmasiSandi_TextChanged(object sender, EventArgs e)
        {
            TBKonfirmasiSandi.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TBKataSandiLama.UseSystemPasswordChar = true;
            button4.Visible = false;
            button3.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TBSandiBaru.UseSystemPasswordChar = true;
            button5.Visible = false;
            button1.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TBKonfirmasiSandi.UseSystemPasswordChar = true;
            button6.Visible = false;
            button2.Visible = true;
        }

        private void TBKataSandiLama_TextChanged(object sender, EventArgs e)
        {
            TBKataSandiLama.UseSystemPasswordChar = true;
        }

        private void BtnHomePage_Click(object sender, EventArgs e)
        {
            HomepageUtama homepageUtama = new HomepageUtama();
            homepageUtama.Show();
            this.Hide();
        }

        private void BtnPaket_Click(object sender, EventArgs e)
        {
            penginapanMain penginapanMain = new penginapanMain();
            penginapanMain.Show();
            this.Hide();
        }

        private void btnVoucher_Click(object sender, EventArgs e)
        {
            HomeMyVoucher homeMyVoucher = new HomeMyVoucher();
            homeMyVoucher.Show();
            this.Hide();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            Home_History home_History = new Home_History();
            home_History.Show();
            this.Hide();
        }

        private void BtnWishlist_Click(object sender, EventArgs e)
        {
            WishlistTiket wishlistTiket = new WishlistTiket();
            wishlistTiket.Show();
            this.Hide();
        }
    }
}
