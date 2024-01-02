using static Siticone.Desktop.UI.WinForms.Suite.Descriptions;

namespace JTAPPS_WIN
{
    partial class home_page_bantuan
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_page_bantuan));
            sidebar = new Panel();
            btnchekcout = new Button();
            btnHistory = new Button();
            btnVoucher = new Button();
            btnPaket = new Button();
            btnHomepage = new Button();
            pictureBoxlogo = new PictureBox();
            panel2 = new Panel();
            NAVbar = new Panel();
            btnBantuan = new Button();
            btnkritikdanSaran = new Button();
            MAIN = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            PNgaris2 = new Panel();
            PNgaris = new Panel();
            btnFaq = new Button();
            btnKritik = new Button();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            NAVbar.SuspendLayout();
            MAIN.SuspendLayout();
            SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.White;
            sidebar.Controls.Add(btnchekcout);
            sidebar.Controls.Add(btnHistory);
            sidebar.Controls.Add(btnVoucher);
            sidebar.Controls.Add(btnPaket);
            sidebar.Controls.Add(btnHomepage);
            sidebar.Controls.Add(pictureBoxlogo);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(169, 548);
            sidebar.TabIndex = 0;
            // 
            // btnchekcout
            // 
            btnchekcout.FlatAppearance.BorderSize = 0;
            btnchekcout.FlatStyle = FlatStyle.Flat;
            btnchekcout.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnchekcout.Location = new Point(0, 225);
            btnchekcout.Name = "btnchekcout";
            btnchekcout.Size = new Size(169, 29);
            btnchekcout.TabIndex = 5;
            btnchekcout.Text = "Wishlist";
            btnchekcout.UseVisualStyleBackColor = true;
            btnchekcout.Click += btnchekcout_Click;
            // 
            // btnHistory
            // 
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnHistory.Location = new Point(0, 192);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(169, 29);
            btnHistory.TabIndex = 4;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.FlatAppearance.BorderSize = 0;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnVoucher.Location = new Point(0, 159);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(169, 29);
            btnVoucher.TabIndex = 3;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnPaket
            // 
            btnPaket.FlatAppearance.BorderSize = 0;
            btnPaket.FlatStyle = FlatStyle.Flat;
            btnPaket.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnPaket.Location = new Point(0, 125);
            btnPaket.Name = "btnPaket";
            btnPaket.Size = new Size(169, 29);
            btnPaket.TabIndex = 2;
            btnPaket.Text = "Paket";
            btnPaket.UseVisualStyleBackColor = true;
            btnPaket.Click += btnPaket_Click;
            // 
            // btnHomepage
            // 
            btnHomepage.FlatAppearance.BorderSize = 0;
            btnHomepage.FlatStyle = FlatStyle.Flat;
            btnHomepage.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnHomepage.Location = new Point(0, 93);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(169, 29);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.Artboard_2_4x2;
            pictureBoxlogo.Location = new Point(62, 27);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(43, 28);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxlogo.TabIndex = 0;
            pictureBoxlogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 231, 231);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(169, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(5, 548);
            panel2.TabIndex = 1;
            // 
            // NAVbar
            // 
            NAVbar.BackColor = Color.FromArgb(255, 255, 128);
            NAVbar.BackgroundImage = (Image)resources.GetObject("NAVbar.BackgroundImage");
            NAVbar.BackgroundImageLayout = ImageLayout.Stretch;
            NAVbar.Controls.Add(btnBantuan);
            NAVbar.Controls.Add(btnkritikdanSaran);
            NAVbar.Dock = DockStyle.Top;
            NAVbar.Location = new Point(174, 0);
            NAVbar.Name = "NAVbar";
            NAVbar.Size = new Size(785, 59);
            NAVbar.TabIndex = 2;
            // 
            // btnBantuan
            // 
            btnBantuan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnBantuan.BackColor = Color.Transparent;
            btnBantuan.FlatAppearance.BorderSize = 0;
            btnBantuan.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnBantuan.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnBantuan.FlatStyle = FlatStyle.Flat;
            btnBantuan.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnBantuan.ForeColor = Color.White;
            btnBantuan.Location = new Point(222, 3);
            btnBantuan.Name = "btnBantuan";
            btnBantuan.Size = new Size(303, 53);
            btnBantuan.TabIndex = 1;
            btnBantuan.Text = "Bantuan";
            btnBantuan.UseVisualStyleBackColor = false;
            // 
            // btnkritikdanSaran
            // 
            btnkritikdanSaran.BackColor = Color.Transparent;
            btnkritikdanSaran.BackgroundImage = Properties.Resources.arrow_back__1_2;
            btnkritikdanSaran.BackgroundImageLayout = ImageLayout.Zoom;
            btnkritikdanSaran.FlatAppearance.BorderSize = 0;
            btnkritikdanSaran.FlatStyle = FlatStyle.Flat;
            btnkritikdanSaran.Location = new Point(31, 20);
            btnkritikdanSaran.Name = "btnkritikdanSaran";
            btnkritikdanSaran.Size = new Size(15, 17);
            btnkritikdanSaran.TabIndex = 0;
            btnkritikdanSaran.UseVisualStyleBackColor = false;
            btnkritikdanSaran.Click += btnkritikdanSaran_Click;
            // 
            // MAIN
            // 
            MAIN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MAIN.AutoScroll = true;
            MAIN.AutoScrollMinSize = new Size(787, 1688);
            MAIN.BackColor = Color.White;
            MAIN.Controls.Add(panel1);
            MAIN.Controls.Add(button1);
            MAIN.Controls.Add(PNgaris2);
            MAIN.Controls.Add(PNgaris);
            MAIN.Controls.Add(btnFaq);
            MAIN.Controls.Add(btnKritik);
            MAIN.Location = new Point(173, 59);
            MAIN.Name = "MAIN";
            MAIN.Size = new Size(787, 491);
            MAIN.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = Properties.Resources.Line_182;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Location = new Point(17, 187);
            panel1.Name = "panel1";
            panel1.Size = new Size(737, 11);
            panel1.TabIndex = 5;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            button1.Location = new Point(17, 153);
            button1.Name = "button1";
            button1.Size = new Size(129, 44);
            button1.TabIndex = 4;
            button1.Text = "Nomor Darurat";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PNgaris2
            // 
            PNgaris2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PNgaris2.BackColor = Color.Transparent;
            PNgaris2.BackgroundImage = Properties.Resources.Line_182;
            PNgaris2.BackgroundImageLayout = ImageLayout.Zoom;
            PNgaris2.Location = new Point(17, 121);
            PNgaris2.Name = "PNgaris2";
            PNgaris2.Size = new Size(737, 11);
            PNgaris2.TabIndex = 3;
            // 
            // PNgaris
            // 
            PNgaris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PNgaris.BackColor = Color.Transparent;
            PNgaris.BackgroundImage = Properties.Resources.Line_182;
            PNgaris.BackgroundImageLayout = ImageLayout.Zoom;
            PNgaris.Location = new Point(17, 55);
            PNgaris.Name = "PNgaris";
            PNgaris.Size = new Size(737, 11);
            PNgaris.TabIndex = 2;
            // 
            // btnFaq
            // 
            btnFaq.FlatAppearance.BorderSize = 0;
            btnFaq.FlatStyle = FlatStyle.Flat;
            btnFaq.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnFaq.ImageAlign = ContentAlignment.MiddleLeft;
            btnFaq.Location = new Point(21, 21);
            btnFaq.Name = "btnFaq";
            btnFaq.Size = new Size(58, 44);
            btnFaq.TabIndex = 0;
            btnFaq.Text = "FAQ";
            btnFaq.UseVisualStyleBackColor = true;
            btnFaq.Click += btnFaq_Click;
            // 
            // btnKritik
            // 
            btnKritik.FlatAppearance.BorderSize = 0;
            btnKritik.FlatStyle = FlatStyle.Flat;
            btnKritik.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnKritik.Location = new Point(1, 85);
            btnKritik.Name = "btnKritik";
            btnKritik.Size = new Size(163, 44);
            btnKritik.TabIndex = 1;
            btnKritik.Text = "Kritik dan Saran";
            btnKritik.UseVisualStyleBackColor = true;
            btnKritik.Click += btnKritik_Click;
            // 
            // home_page_bantuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 548);
            Controls.Add(MAIN);
            Controls.Add(NAVbar);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            MinimumSize = new Size(975, 584);
            Name = "home_page_bantuan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load_1;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            NAVbar.ResumeLayout(false);
            MAIN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Panel panel2;
        private Panel NAVbar;
        private Panel MAIN;
        private PictureBox pictureBoxlogo;
        private Button btnchekcout;
        private Button btnHistory;
        private Button btnVoucher;
        private Button btnPaket;
        private Button btnHomepage;
        private Button btnkritikdanSaran;
        private Button btnBantuan;
        private Button btnKritik;
        private Button btnFaq;
        private Panel PNgaris;
        private Panel PNgaris2;
        private Panel panel1;
        private Button button1;
    }
}