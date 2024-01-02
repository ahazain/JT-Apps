using JTAPPS_WIN;
using static Siticone.Desktop.UI.WinForms.Suite.Descriptions;

namespace JTAPPS_WIN
{
    partial class homaFAQ
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homaFAQ));
            sidebar = new Panel();
            btnchekcout = new Button();
            btnHistory = new Button();
            btnVoucher = new Button();
            btnPaket = new Button();
            btnHomepage = new Button();
            pictureBoxlogo = new PictureBox();
            panel2 = new Panel();
            NAVbar = new Panel();
            btnFAQ = new Button();
            btnkritikdanSaran = new Button();
            MAIN = new Panel();
            panel13 = new Panel();
            label10 = new Label();
            panel12 = new Panel();
            label9 = new Label();
            panel11 = new Panel();
            label8 = new Label();
            panel10 = new Panel();
            label5 = new Label();
            panel9 = new Panel();
            label4 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            linkLabel1 = new LinkLabel();
            label1 = new Label();
            panel1 = new Panel();
            panel8 = new Panel();
            button6 = new Button();
            panel7 = new Panel();
            button5 = new Button();
            panel6 = new Panel();
            button4 = new Button();
            panel5 = new Panel();
            button3 = new Button();
            panel4 = new Panel();
            button2 = new Button();
            PNgaris = new Panel();
            label3 = new Label();
            button1 = new Button();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            NAVbar.SuspendLayout();
            MAIN.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            sidebar.TabIndex = 1;
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
            btnVoucher.Click += btnVoucher_Click_1;
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
            btnHomepage.Click += btnHomepage_Click_1;
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
            panel2.TabIndex = 2;
            // 
            // NAVbar
            // 
            NAVbar.BackColor = Color.FromArgb(255, 255, 128);
            NAVbar.BackgroundImage = (Image)resources.GetObject("NAVbar.BackgroundImage");
            NAVbar.BackgroundImageLayout = ImageLayout.Stretch;
            NAVbar.Controls.Add(btnFAQ);
            NAVbar.Controls.Add(btnkritikdanSaran);
            NAVbar.Dock = DockStyle.Top;
            NAVbar.Location = new Point(174, 0);
            NAVbar.Name = "NAVbar";
            NAVbar.Size = new Size(785, 59);
            NAVbar.TabIndex = 3;
            // 
            // btnFAQ
            // 
            btnFAQ.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnFAQ.BackColor = Color.Transparent;
            btnFAQ.FlatAppearance.BorderSize = 0;
            btnFAQ.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnFAQ.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnFAQ.FlatStyle = FlatStyle.Flat;
            btnFAQ.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnFAQ.ForeColor = Color.White;
            btnFAQ.Location = new Point(222, 3);
            btnFAQ.Name = "btnFAQ";
            btnFAQ.Size = new Size(303, 53);
            btnFAQ.TabIndex = 2;
            btnFAQ.Text = "FAQ";
            btnFAQ.UseVisualStyleBackColor = false;
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
            btnkritikdanSaran.TabIndex = 1;
            btnkritikdanSaran.UseVisualStyleBackColor = false;
            btnkritikdanSaran.Click += btnkritikdanSaran_Click;
            // 
            // MAIN
            // 
            MAIN.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MAIN.AutoScroll = true;
            MAIN.AutoScrollMinSize = new Size(787, 1688);
            MAIN.BackColor = Color.White;
            MAIN.BackgroundImageLayout = ImageLayout.None;
            MAIN.BorderStyle = BorderStyle.FixedSingle;
            MAIN.Controls.Add(panel13);
            MAIN.Controls.Add(panel12);
            MAIN.Controls.Add(panel11);
            MAIN.Controls.Add(panel10);
            MAIN.Controls.Add(panel9);
            MAIN.Controls.Add(panel3);
            MAIN.Controls.Add(linkLabel1);
            MAIN.Controls.Add(label1);
            MAIN.Controls.Add(panel1);
            MAIN.Location = new Point(173, 59);
            MAIN.Name = "MAIN";
            MAIN.Size = new Size(787, 490);
            MAIN.TabIndex = 4;
            // 
            // panel13
            // 
            panel13.BackColor = Color.LightGray;
            panel13.Controls.Add(label10);
            panel13.Location = new Point(31, 850);
            panel13.Name = "panel13";
            panel13.Size = new Size(695, 112);
            panel13.TabIndex = 7;
            panel13.Paint += panel13_Paint;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(30, 33);
            label10.Name = "label10";
            label10.Size = new Size(95, 38);
            label10.TabIndex = 0;
            label10.Text = "FAQ 6";
            // 
            // panel12
            // 
            panel12.BackColor = Color.LightGray;
            panel12.Controls.Add(label9);
            panel12.Location = new Point(31, 714);
            panel12.Name = "panel12";
            panel12.Size = new Size(695, 112);
            panel12.TabIndex = 6;
            panel12.Paint += panel12_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(30, 33);
            label9.Name = "label9";
            label9.Size = new Size(95, 38);
            label9.TabIndex = 0;
            label9.Text = "FAQ 5";
            // 
            // panel11
            // 
            panel11.BackColor = Color.LightGray;
            panel11.Controls.Add(label8);
            panel11.Location = new Point(31, 581);
            panel11.Name = "panel11";
            panel11.Size = new Size(695, 112);
            panel11.TabIndex = 5;
            panel11.Paint += panel11_Paint;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(30, 33);
            label8.Name = "label8";
            label8.Size = new Size(95, 38);
            label8.TabIndex = 0;
            label8.Text = "FAQ 4";
            // 
            // panel10
            // 
            panel10.BackColor = Color.LightGray;
            panel10.Controls.Add(label5);
            panel10.Location = new Point(31, 447);
            panel10.Name = "panel10";
            panel10.Size = new Size(695, 112);
            panel10.TabIndex = 4;
            panel10.Paint += panel10_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(30, 33);
            label5.Name = "label5";
            label5.Size = new Size(95, 38);
            label5.TabIndex = 0;
            label5.Text = "FAQ 3";
            // 
            // panel9
            // 
            panel9.BackColor = Color.LightGray;
            panel9.Controls.Add(label4);
            panel9.Location = new Point(31, 314);
            panel9.Name = "panel9";
            panel9.Size = new Size(695, 112);
            panel9.TabIndex = 3;
            panel9.Paint += panel9_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(30, 33);
            label4.Name = "label4";
            label4.Size = new Size(95, 38);
            label4.TabIndex = 0;
            label4.Text = "FAQ 2";
            // 
            // panel3
            // 
            panel3.BackColor = Color.LightGray;
            panel3.Controls.Add(label2);
            panel3.Location = new Point(31, 168);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 112);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(30, 33);
            label2.Name = "label2";
            label2.Size = new Size(95, 38);
            label2.TabIndex = 0;
            label2.Text = "FAQ 1";
            label2.Click += label2_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.Anchor = AnchorStyles.None;
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.Location = new Point(285, 1648);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(120, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Butuh Bantuan";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.Location = new Point(40, 1651);
            label1.Name = "label1";
            label1.Size = new Size(248, 16);
            label1.TabIndex = 0;
            label1.Text = "Tidak Menemukan Jawapan Anda?";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(787, 125);
            panel1.TabIndex = 0;
            // 
            // panel8
            // 
            panel8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel8.BackColor = Color.Transparent;
            panel8.BackgroundImage = Properties.Resources.Line_182;
            panel8.BackgroundImageLayout = ImageLayout.Zoom;
            panel8.Location = new Point(19, 317);
            panel8.Name = "panel8";
            panel8.Size = new Size(633, 11);
            panel8.TabIndex = 7;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button6.BackgroundImageLayout = ImageLayout.None;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.BottomRight;
            button6.Location = new Point(19, 295);
            button6.Name = "button6";
            button6.Size = new Size(635, 32);
            button6.TabIndex = 9;
            button6.Text = "Bagaimana cara membatakan pesanan?";
            button6.TextAlign = ContentAlignment.MiddleLeft;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // panel7
            // 
            panel7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel7.BackColor = Color.Transparent;
            panel7.BackgroundImage = Properties.Resources.Line_182;
            panel7.BackgroundImageLayout = ImageLayout.Zoom;
            panel7.Location = new Point(19, 267);
            panel7.Name = "panel7";
            panel7.Size = new Size(633, 11);
            panel7.TabIndex = 6;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button5.BackgroundImageLayout = ImageLayout.None;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.BottomRight;
            button5.Location = new Point(19, 245);
            button5.Name = "button5";
            button5.Size = new Size(635, 32);
            button5.TabIndex = 8;
            button5.Text = "Berapa lamakah batas waktu pembayaran?";
            button5.TextAlign = ContentAlignment.MiddleLeft;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panel6
            // 
            panel6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel6.BackColor = Color.Transparent;
            panel6.BackgroundImage = Properties.Resources.Line_182;
            panel6.BackgroundImageLayout = ImageLayout.Zoom;
            panel6.Location = new Point(19, 217);
            panel6.Name = "panel6";
            panel6.Size = new Size(633, 11);
            panel6.TabIndex = 6;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button4.BackgroundImageLayout = ImageLayout.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.BottomRight;
            button4.Location = new Point(19, 195);
            button4.Name = "button4";
            button4.Size = new Size(635, 32);
            button4.TabIndex = 7;
            button4.Text = "Apakah saya perlu melakukan proses check-in?";
            button4.TextAlign = ContentAlignment.MiddleLeft;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.Transparent;
            panel5.BackgroundImage = Properties.Resources.Line_182;
            panel5.BackgroundImageLayout = ImageLayout.Zoom;
            panel5.Location = new Point(19, 167);
            panel5.Name = "panel5";
            panel5.Size = new Size(633, 11);
            panel5.TabIndex = 5;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.BottomRight;
            button3.Location = new Point(19, 145);
            button3.Name = "button3";
            button3.Size = new Size(635, 32);
            button3.TabIndex = 5;
            button3.Text = "Kapan tiket wisata dapat di pesan?";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.Transparent;
            panel4.BackgroundImage = Properties.Resources.Line_182;
            panel4.BackgroundImageLayout = ImageLayout.Zoom;
            panel4.Location = new Point(19, 117);
            panel4.Name = "panel4";
            panel4.Size = new Size(633, 11);
            panel4.TabIndex = 4;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.BottomRight;
            button2.Location = new Point(19, 95);
            button2.Name = "button2";
            button2.Size = new Size(635, 32);
            button2.TabIndex = 4;
            button2.Text = "Dimanakah pemesanan tiket wisata dapat dilakukan?";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // PNgaris
            // 
            PNgaris.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            PNgaris.BackColor = Color.Transparent;
            PNgaris.BackgroundImage = Properties.Resources.Line_182;
            PNgaris.BackgroundImageLayout = ImageLayout.Zoom;
            PNgaris.Location = new Point(19, 67);
            PNgaris.Name = "PNgaris";
            PNgaris.Size = new Size(633, 11);
            PNgaris.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            label3.Location = new Point(19, 11);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 0;
            label3.Text = "Topik Populer";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.BottomRight;
            button1.Location = new Point(19, 45);
            button1.Name = "button1";
            button1.Size = new Size(635, 32);
            button1.TabIndex = 1;
            button1.Text = "Apakah diperbolehkan membawa makanan dan minuman dari luar?";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(206, 11);
            label7.Name = "label7";
            label7.Size = new Size(372, 28);
            label7.TabIndex = 13;
            label7.Text = "                                                                        ";
            label7.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.FlatStyle = FlatStyle.Flat;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(176, 176, 176);
            label6.Location = new Point(59, 11);
            label6.Name = "label6";
            label6.Size = new Size(129, 20);
            label6.TabIndex = 12;
            label6.Text = "Ketuk untuk cari";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vector2;
            pictureBox1.Location = new Point(11, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 20);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Pixel);
            textBox1.ForeColor = Color.FromArgb(176, 176, 176);
            textBox1.Location = new Point(59, 11);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(539, 19);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // homaFAQ
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(959, 548);
            Controls.Add(MAIN);
            Controls.Add(NAVbar);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            MinimumSize = new Size(975, 584);
            Name = "homaFAQ";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "homeFaq";
            WindowState = FormWindowState.Maximized;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            NAVbar.ResumeLayout(false);
            MAIN.ResumeLayout(false);
            MAIN.PerformLayout();
            panel13.ResumeLayout(false);
            panel13.PerformLayout();
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel sidebar;
        private Button btnchekcout;
        private Button btnHistory;
        private Button btnVoucher;
        private Button btnPaket;
        private Button btnHomepage;
        private PictureBox pictureBoxlogo;
        private Panel panel2;
        private Panel NAVbar;
        private Panel MAIN;
        private Button btnkritikdanSaran;
        private Button btnFAQ;
        private Panel panel1;
        private reundedPNClass1 reundedpnClass12;
        private Label label1;
        private Label label3;
        private Button button1;
        private Panel PNgaris;
        private Button button2;
        private Panel panel8;
        private Button button6;
        private Panel panel7;
        private Button button5;
        private Panel panel6;
        private Button button4;
        private Panel panel5;
        private Button button3;
        private Panel panel4;
        private reundedPNClass1 reundedpnClass11;
        private Label label7;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private LinkLabel linkLabel1;
        private Panel panel13;
        private Label label10;
        private Panel panel12;
        private Label label9;
        private Panel panel11;
        private Label label8;
        private Panel panel10;
        private Label label5;
        private Panel panel9;
        private Label label4;
        private Panel panel3;
        private Label label2;
    }
}