using JTAPPS_WIN;
using UbahUnamePw;

namespace JTAPPS_WIN
{
    partial class MyTicketRembangan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyTicketRembangan));
            panelSidebar = new Panel();
            btnWishlist = new Button();
            btnHistory = new Button();
            btnVoucher = new Button();
            btnPaket = new Button();
            Homepage = new Button();
            pictureBoxLogo = new PictureBox();
            panelMain = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            namaDeskripsi = new Label();
            labeldeskripsiIsi = new Label();
            lbDeskripsi = new Label();
            customRoundedButton1 = new CustomRoundedButton();
            panelGambarWisata = new Panel();
            pbRating5 = new PictureBox();
            pbRating4 = new PictureBox();
            pbRating3 = new PictureBox();
            pbRating2 = new PictureBox();
            pbRating1 = new PictureBox();
            roundedPanel1 = new RoundedPanel();
            label6 = new Label();
            labelnamaWisata = new Label();
            labelharga = new Label();
            panelNavbar = new Panel();
            button1 = new Button();
            labelMyTicket = new Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panelMain.SuspendLayout();
            panel1.SuspendLayout();
            panelGambarWisata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbRating5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRating4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRating3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRating2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRating1).BeginInit();
            roundedPanel1.SuspendLayout();
            panelNavbar.SuspendLayout();
            SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = Color.White;
            panelSidebar.Controls.Add(btnWishlist);
            panelSidebar.Controls.Add(btnHistory);
            panelSidebar.Controls.Add(btnVoucher);
            panelSidebar.Controls.Add(btnPaket);
            panelSidebar.Controls.Add(Homepage);
            panelSidebar.Controls.Add(pictureBoxLogo);
            panelSidebar.Dock = DockStyle.Left;
            panelSidebar.Location = new Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new Size(193, 731);
            panelSidebar.TabIndex = 3;
            // 
            // btnWishlist
            // 
            btnWishlist.Cursor = Cursors.Hand;
            btnWishlist.FlatAppearance.BorderSize = 0;
            btnWishlist.FlatStyle = FlatStyle.Flat;
            btnWishlist.Location = new Point(3, 296);
            btnWishlist.Margin = new Padding(3, 4, 3, 4);
            btnWishlist.Name = "btnWishlist";
            btnWishlist.Size = new Size(162, 33);
            btnWishlist.TabIndex = 19;
            btnWishlist.Text = "Wishlist";
            btnWishlist.UseVisualStyleBackColor = true;
            btnWishlist.Click += btnWishlist_Click;
            // 
            // btnHistory
            // 
            btnHistory.Cursor = Cursors.Hand;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Location = new Point(3, 252);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(162, 36);
            btnHistory.TabIndex = 18;
            btnHistory.Text = "History";
            btnHistory.UseVisualStyleBackColor = true;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnVoucher
            // 
            btnVoucher.Cursor = Cursors.Hand;
            btnVoucher.FlatAppearance.BorderSize = 0;
            btnVoucher.FlatStyle = FlatStyle.Flat;
            btnVoucher.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVoucher.Location = new Point(3, 208);
            btnVoucher.Margin = new Padding(3, 4, 3, 4);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(162, 31);
            btnVoucher.TabIndex = 17;
            btnVoucher.Text = "Voucher";
            btnVoucher.UseVisualStyleBackColor = true;
            btnVoucher.Click += btnVoucher_Click;
            // 
            // btnPaket
            // 
            btnPaket.Cursor = Cursors.Hand;
            btnPaket.FlatAppearance.BorderSize = 0;
            btnPaket.FlatStyle = FlatStyle.Flat;
            btnPaket.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnPaket.Location = new Point(3, 164);
            btnPaket.Margin = new Padding(3, 4, 3, 4);
            btnPaket.Name = "btnPaket";
            btnPaket.Size = new Size(162, 31);
            btnPaket.TabIndex = 16;
            btnPaket.Text = "Paket";
            btnPaket.UseVisualStyleBackColor = true;
            btnPaket.Click += btnPaket_Click;
            // 
            // Homepage
            // 
            Homepage.Cursor = Cursors.Hand;
            Homepage.FlatAppearance.BorderSize = 0;
            Homepage.FlatStyle = FlatStyle.Flat;
            Homepage.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Homepage.Location = new Point(3, 119);
            Homepage.Margin = new Padding(3, 4, 3, 4);
            Homepage.Name = "Homepage";
            Homepage.Size = new Size(162, 33);
            Homepage.TabIndex = 15;
            Homepage.Text = "Homepage";
            Homepage.UseVisualStyleBackColor = true;
            Homepage.Click += Homepage_Click;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.Image = (Image)resources.GetObject("pictureBoxLogo.Image");
            pictureBoxLogo.Location = new Point(62, 27);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(43, 28);
            pictureBoxLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelMain.BackColor = Color.White;
            panelMain.Controls.Add(panel1);
            panelMain.Location = new Point(198, 77);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(899, 653);
            panelMain.TabIndex = 4;
            panelMain.Paint += panelMain_Paint;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(namaDeskripsi);
            panel1.Controls.Add(labeldeskripsiIsi);
            panel1.Controls.Add(lbDeskripsi);
            panel1.Controls.Add(customRoundedButton1);
            panel1.Controls.Add(panelGambarWisata);
            panel1.Controls.Add(labelharga);
            panel1.Location = new Point(32, 41);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(841, 552);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(685, 57);
            label1.Name = "label1";
            label1.Size = new Size(38, 25);
            label1.TabIndex = 14;
            label1.Text = "Rp";
            // 
            // namaDeskripsi
            // 
            namaDeskripsi.AutoSize = true;
            namaDeskripsi.BackColor = Color.Transparent;
            namaDeskripsi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            namaDeskripsi.Location = new Point(135, 167);
            namaDeskripsi.Name = "namaDeskripsi";
            namaDeskripsi.Size = new Size(97, 18);
            namaDeskripsi.TabIndex = 13;
            namaDeskripsi.Text = "Rembangan";
            // 
            // labeldeskripsiIsi
            // 
            labeldeskripsiIsi.AutoSize = true;
            labeldeskripsiIsi.BackColor = Color.Transparent;
            labeldeskripsiIsi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labeldeskripsiIsi.Location = new Point(61, 220);
            labeldeskripsiIsi.Name = "labeldeskripsiIsi";
            labeldeskripsiIsi.Size = new Size(90, 18);
            labeldeskripsiIsi.TabIndex = 12;
            labeldeskripsiIsi.Text = "DESKRIPSI ";
            // 
            // lbDeskripsi
            // 
            lbDeskripsi.AutoSize = true;
            lbDeskripsi.BackColor = Color.Transparent;
            lbDeskripsi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbDeskripsi.Location = new Point(61, 167);
            lbDeskripsi.Name = "lbDeskripsi";
            lbDeskripsi.Size = new Size(79, 18);
            lbDeskripsi.TabIndex = 11;
            lbDeskripsi.Text = "Deskripsi";
            // 
            // customRoundedButton1
            // 
            customRoundedButton1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customRoundedButton1.BackColor = Color.FromArgb(55, 163, 165);
            customRoundedButton1.CornerRadius = 10;
            customRoundedButton1.FlatAppearance.BorderSize = 0;
            customRoundedButton1.FlatStyle = FlatStyle.Flat;
            customRoundedButton1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            customRoundedButton1.ForeColor = Color.White;
            customRoundedButton1.HoverColor = Color.FromArgb(55, 163, 165);
            customRoundedButton1.Location = new Point(685, 448);
            customRoundedButton1.Margin = new Padding(3, 4, 3, 4);
            customRoundedButton1.Name = "customRoundedButton1";
            customRoundedButton1.PressColor = Color.Transparent;
            customRoundedButton1.Size = new Size(101, 45);
            customRoundedButton1.TabIndex = 10;
            customRoundedButton1.Text = "Tutup";
            customRoundedButton1.UseVisualStyleBackColor = false;
            customRoundedButton1.Click += customRoundedButton1_Click;
            // 
            // panelGambarWisata
            // 
            panelGambarWisata.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelGambarWisata.BackColor = Color.Transparent;
            panelGambarWisata.BackgroundImage = (Image)resources.GetObject("panelGambarWisata.BackgroundImage");
            panelGambarWisata.BackgroundImageLayout = ImageLayout.Stretch;
            panelGambarWisata.Controls.Add(pbRating5);
            panelGambarWisata.Controls.Add(pbRating4);
            panelGambarWisata.Controls.Add(pbRating3);
            panelGambarWisata.Controls.Add(pbRating2);
            panelGambarWisata.Controls.Add(pbRating1);
            panelGambarWisata.Controls.Add(roundedPanel1);
            panelGambarWisata.Controls.Add(labelnamaWisata);
            panelGambarWisata.Location = new Point(1, 0);
            panelGambarWisata.Margin = new Padding(3, 4, 3, 4);
            panelGambarWisata.Name = "panelGambarWisata";
            panelGambarWisata.Size = new Size(657, 119);
            panelGambarWisata.TabIndex = 9;
            // 
            // pbRating5
            // 
            pbRating5.Image = Properties.Resources.lop2Group_8;
            pbRating5.Location = new Point(195, 75);
            pbRating5.Margin = new Padding(3, 4, 3, 4);
            pbRating5.Name = "pbRating5";
            pbRating5.Size = new Size(25, 25);
            pbRating5.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRating5.TabIndex = 26;
            pbRating5.TabStop = false;
            // 
            // pbRating4
            // 
            pbRating4.Image = Properties.Resources.lop2Group_8;
            pbRating4.Location = new Point(171, 75);
            pbRating4.Margin = new Padding(3, 4, 3, 4);
            pbRating4.Name = "pbRating4";
            pbRating4.Size = new Size(25, 25);
            pbRating4.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRating4.TabIndex = 25;
            pbRating4.TabStop = false;
            // 
            // pbRating3
            // 
            pbRating3.Image = Properties.Resources.lop2Group_8;
            pbRating3.Location = new Point(149, 75);
            pbRating3.Margin = new Padding(3, 4, 3, 4);
            pbRating3.Name = "pbRating3";
            pbRating3.Size = new Size(25, 25);
            pbRating3.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRating3.TabIndex = 24;
            pbRating3.TabStop = false;
            // 
            // pbRating2
            // 
            pbRating2.Image = Properties.Resources.lop2Group_8;
            pbRating2.Location = new Point(125, 75);
            pbRating2.Margin = new Padding(3, 4, 3, 4);
            pbRating2.Name = "pbRating2";
            pbRating2.Size = new Size(25, 25);
            pbRating2.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRating2.TabIndex = 23;
            pbRating2.TabStop = false;
            // 
            // pbRating1
            // 
            pbRating1.Image = Properties.Resources.lop2Group_8;
            pbRating1.Location = new Point(103, 75);
            pbRating1.Margin = new Padding(3, 4, 3, 4);
            pbRating1.Name = "pbRating1";
            pbRating1.Size = new Size(25, 25);
            pbRating1.SizeMode = PictureBoxSizeMode.StretchImage;
            pbRating1.TabIndex = 22;
            pbRating1.TabStop = false;
            // 
            // roundedPanel1
            // 
            roundedPanel1.BackColor = Color.FromArgb(34, 87, 121);
            roundedPanel1.Controls.Add(label6);
            roundedPanel1.CornerRadius = 5;
            roundedPanel1.Location = new Point(34, 75);
            roundedPanel1.Margin = new Padding(3, 4, 3, 4);
            roundedPanel1.Name = "roundedPanel1";
            roundedPanel1.Size = new Size(57, 20);
            roundedPanel1.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(2, 0);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "E - Ticket";
            // 
            // labelnamaWisata
            // 
            labelnamaWisata.AutoSize = true;
            labelnamaWisata.BackColor = Color.Transparent;
            labelnamaWisata.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelnamaWisata.ForeColor = Color.White;
            labelnamaWisata.Location = new Point(23, 33);
            labelnamaWisata.Name = "labelnamaWisata";
            labelnamaWisata.Size = new Size(159, 31);
            labelnamaWisata.TabIndex = 5;
            labelnamaWisata.Text = "rembangan";
            // 
            // labelharga
            // 
            labelharga.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelharga.AutoSize = true;
            labelharga.BackColor = Color.Transparent;
            labelharga.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelharga.Location = new Point(721, 57);
            labelharga.Name = "labelharga";
            labelharga.Size = new Size(78, 25);
            labelharga.TabIndex = 8;
            labelharga.Text = "10.000";
            // 
            // panelNavbar
            // 
            panelNavbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelNavbar.BackColor = Color.FromArgb(55, 163, 165);
            panelNavbar.BackgroundImageLayout = ImageLayout.Stretch;
            panelNavbar.Controls.Add(button1);
            panelNavbar.Controls.Add(labelMyTicket);
            panelNavbar.Location = new Point(198, 0);
            panelNavbar.Name = "panelNavbar";
            panelNavbar.Size = new Size(902, 77);
            panelNavbar.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(15, 27);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(21, 24);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelMyTicket
            // 
            labelMyTicket.Anchor = AnchorStyles.Top;
            labelMyTicket.AutoSize = true;
            labelMyTicket.BackColor = Color.Transparent;
            labelMyTicket.FlatStyle = FlatStyle.Flat;
            labelMyTicket.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            labelMyTicket.ForeColor = Color.White;
            labelMyTicket.Location = new Point(402, 20);
            labelMyTicket.Name = "labelMyTicket";
            labelMyTicket.Size = new Size(106, 25);
            labelMyTicket.TabIndex = 0;
            labelMyTicket.Text = " MyTicket";
            // 
            // MyTicketRembangan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 731);
            Controls.Add(panelNavbar);
            Controls.Add(panelSidebar);
            Controls.Add(panelMain);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1095, 702);
            Name = "MyTicketRembangan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MyTicketRembangan";
            WindowState = FormWindowState.Maximized;
            Load += MyTicketRembangan_Load;
            panelSidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panelMain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelGambarWisata.ResumeLayout(false);
            panelGambarWisata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbRating5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRating4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRating3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRating2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRating1).EndInit();
            roundedPanel1.ResumeLayout(false);
            roundedPanel1.PerformLayout();
            panelNavbar.ResumeLayout(false);
            panelNavbar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSidebar;
        private Button btnWishlist;
        private Button btnHistory;
        private Button btnVoucher;
        private Button btnPaket;
        private Button Homepage;
        private PictureBox pictureBoxLogo;
        private Panel panelMain;
        private Panel panelNavbar;
        private Label labelMyTicket;
        private Button button1;
        private Panel panel1;
        private Label labelharga;
        private Label labelnamaWisata;
        private Panel panelGambarWisata;
        private RoundedPanel roundedPanel1;
        private Label label6;
        private CustomRoundedButton customRoundedButton1;
        private Label lbDeskripsi;
        private Label labeldeskripsiIsi;
        private Label namaDeskripsi;
        private PictureBox pbRating5;
        private PictureBox pbRating4;
        private PictureBox pbRating3;
        private PictureBox pbRating2;
        private PictureBox pbRating1;
        private Label label1;
    }
}