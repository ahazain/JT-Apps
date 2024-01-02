using JTAPPS_WIN;
using static Siticone.Desktop.UI.WinForms.Suite.Descriptions;

namespace JTAPPS_WIN
{
    partial class FAQ1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAQ1));
            sidebar = new Panel();
            btnchekcout = new Button();
            btnHistory = new Button();
            btnVoucher = new Button();
            btnPaket = new Button();
            btnHomepage = new Button();
            pictureBoxlogo = new PictureBox();
            panel2 = new Panel();
            panel1 = new Panel();
            button3 = new Button();
            btnkritikdanSaran = new Button();
            panel3 = new Panel();
            reundedpnClass12 = new reundedPNClass1();
            panel5 = new Panel();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            labeljawaban = new Label();
            panel9 = new Panel();
            labelpertanyaan = new Label();
            panel4 = new Panel();
            reundedpnClass11 = new reundedPNClass1();
            label7 = new Label();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).BeginInit();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            reundedpnClass12.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            reundedpnClass11.SuspendLayout();
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
            sidebar.Margin = new Padding(3, 2, 3, 2);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(148, 411);
            sidebar.TabIndex = 2;
            // 
            // btnchekcout
            // 
            btnchekcout.FlatAppearance.BorderSize = 0;
            btnchekcout.FlatStyle = FlatStyle.Flat;
            btnchekcout.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            btnchekcout.Location = new Point(0, 169);
            btnchekcout.Margin = new Padding(3, 2, 3, 2);
            btnchekcout.Name = "btnchekcout";
            btnchekcout.Size = new Size(148, 22);
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
            btnHistory.Location = new Point(0, 144);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Size = new Size(148, 22);
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
            btnVoucher.Location = new Point(0, 119);
            btnVoucher.Margin = new Padding(3, 2, 3, 2);
            btnVoucher.Name = "btnVoucher";
            btnVoucher.Size = new Size(148, 22);
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
            btnPaket.Location = new Point(0, 94);
            btnPaket.Margin = new Padding(3, 2, 3, 2);
            btnPaket.Name = "btnPaket";
            btnPaket.Size = new Size(148, 22);
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
            btnHomepage.Location = new Point(0, 70);
            btnHomepage.Margin = new Padding(3, 2, 3, 2);
            btnHomepage.Name = "btnHomepage";
            btnHomepage.Size = new Size(148, 22);
            btnHomepage.TabIndex = 1;
            btnHomepage.Text = "Homepage";
            btnHomepage.UseVisualStyleBackColor = true;
            btnHomepage.Click += btnHomepage_Click;
            // 
            // pictureBoxlogo
            // 
            pictureBoxlogo.Image = Properties.Resources.Artboard_2_4x2;
            pictureBoxlogo.Location = new Point(54, 20);
            pictureBoxlogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxlogo.Name = "pictureBoxlogo";
            pictureBoxlogo.Size = new Size(38, 21);
            pictureBoxlogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxlogo.TabIndex = 0;
            pictureBoxlogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(231, 231, 231);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(148, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(4, 411);
            panel2.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnkritikdanSaran);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(152, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(687, 440);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Pixel);
            button3.ForeColor = Color.White;
            button3.Location = new Point(57, 8);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(288, 30);
            button3.TabIndex = 3;
            button3.Text = "Membawa makanan dan minuman";
            button3.UseVisualStyleBackColor = false;
            // 
            // btnkritikdanSaran
            // 
            btnkritikdanSaran.BackColor = Color.Transparent;
            btnkritikdanSaran.BackgroundImage = Properties.Resources.arrow_back__1_2;
            btnkritikdanSaran.BackgroundImageLayout = ImageLayout.Zoom;
            btnkritikdanSaran.FlatAppearance.BorderSize = 0;
            btnkritikdanSaran.FlatStyle = FlatStyle.Flat;
            btnkritikdanSaran.Location = new Point(27, 15);
            btnkritikdanSaran.Margin = new Padding(3, 2, 3, 2);
            btnkritikdanSaran.Name = "btnkritikdanSaran";
            btnkritikdanSaran.Size = new Size(13, 13);
            btnkritikdanSaran.TabIndex = 2;
            btnkritikdanSaran.UseVisualStyleBackColor = false;
            btnkritikdanSaran.Click += btnkritikdanSaran_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.AutoScroll = true;
            panel3.AutoScrollMinSize = new Size(787, 1688);
            panel3.BackColor = Color.White;
            panel3.Controls.Add(reundedpnClass12);
            panel3.Controls.Add(panel4);
            panel3.Location = new Point(151, 44);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(686, 362);
            panel3.TabIndex = 5;
            // 
            // reundedpnClass12
            // 
            reundedpnClass12.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            reundedpnClass12.BackColor = Color.White;
            reundedpnClass12.BorderStyle = BorderStyle.Fixed3D;
            reundedpnClass12.Controls.Add(panel5);
            reundedpnClass12.Controls.Add(label5);
            reundedpnClass12.Controls.Add(labeljawaban);
            reundedpnClass12.Controls.Add(panel9);
            reundedpnClass12.Controls.Add(labelpertanyaan);
            reundedpnClass12.CornerRadius = 18;
            reundedpnClass12.Location = new Point(40, 75);
            reundedpnClass12.Margin = new Padding(3, 2, 3, 2);
            reundedpnClass12.Name = "reundedpnClass12";
            reundedpnClass12.Size = new Size(609, 288);
            reundedpnClass12.TabIndex = 4;
            reundedpnClass12.Paint += reundedpnClass12_Paint;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.None;
            panel5.Controls.Add(button1);
            panel5.Controls.Add(button2);
            panel5.Location = new Point(243, 178);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(146, 28);
            panel5.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Left;
            button1.FlatAppearance.BorderColor = Color.Black;
            button1.FlatAppearance.MouseDownBackColor = Color.Green;
            button1.FlatAppearance.MouseOverBackColor = Color.Lime;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            button1.Image = Properties.Resources.Vector__1_2;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(60, 28);
            button1.TabIndex = 9;
            button1.Text = "   Ya";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Right;
            button2.FlatAppearance.MouseDownBackColor = Color.Maroon;
            button2.FlatAppearance.MouseOverBackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            button2.ForeColor = Color.FromArgb(33, 43, 54);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(70, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(76, 28);
            button2.TabIndex = 10;
            button2.Text = "   Tidak";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            label5.Location = new Point(224, 158);
            label5.Name = "label5";
            label5.Size = new Size(168, 15);
            label5.TabIndex = 8;
            label5.Text = "Apakah jawaban membantu?";
            // 
            // labeljawaban
            // 
            labeljawaban.AutoSize = true;
            labeljawaban.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Pixel);
            labeljawaban.Location = new Point(3, 60);
            labeljawaban.Name = "labeljawaban";
            labeljawaban.Size = new Size(378, 15);
            labeljawaban.TabIndex = 5;
            labeljawaban.Text = "Membawa makanan dan minuman dari luar diperbolehkan selama \r\n";
            // 
            // panel9
            // 
            panel9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel9.BackColor = Color.Transparent;
            panel9.BackgroundImage = Properties.Resources.Line_182;
            panel9.BackgroundImageLayout = ImageLayout.Zoom;
            panel9.Location = new Point(3, 116);
            panel9.Margin = new Padding(3, 2, 3, 2);
            panel9.Name = "panel9";
            panel9.Size = new Size(599, 8);
            panel9.TabIndex = 4;
            // 
            // labelpertanyaan
            // 
            labelpertanyaan.AutoSize = true;
            labelpertanyaan.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelpertanyaan.Location = new Point(3, 26);
            labelpertanyaan.Name = "labelpertanyaan";
            labelpertanyaan.Size = new Size(554, 20);
            labelpertanyaan.TabIndex = 0;
            labelpertanyaan.Text = "Apakah diperbolehkan membawa makanan dan minuman dari luar";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackgroundImage = Properties.Resources._55Group_88122;
            panel4.Controls.Add(reundedpnClass11);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(689, 94);
            panel4.TabIndex = 0;
            // 
            // reundedpnClass11
            // 
            reundedpnClass11.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reundedpnClass11.BackColor = Color.White;
            reundedpnClass11.BackgroundImageLayout = ImageLayout.None;
            reundedpnClass11.Controls.Add(label7);
            reundedpnClass11.Controls.Add(label6);
            reundedpnClass11.Controls.Add(pictureBox1);
            reundedpnClass11.Controls.Add(textBox1);
            reundedpnClass11.CornerRadius = 18;
            reundedpnClass11.Location = new Point(78, 29);
            reundedpnClass11.Margin = new Padding(3, 2, 3, 2);
            reundedpnClass11.Name = "reundedpnClass11";
            reundedpnClass11.Size = new Size(533, 34);
            reundedpnClass11.TabIndex = 2;
            reundedpnClass11.Paint += reundedpnClass11_Paint;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(179, 8);
            label7.Name = "label7";
            label7.Size = new Size(298, 21);
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
            label6.Location = new Point(52, 8);
            label6.Name = "label6";
            label6.Size = new Size(110, 17);
            label6.TabIndex = 12;
            label6.Text = "Ketuk untuk cari";
            label6.Click += label6_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Vector2;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 15);
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
            textBox1.Location = new Point(52, 8);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(473, 19);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // FAQ1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 411);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(sidebar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(855, 450);
            Name = "FAQ1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAQ1";
            WindowState = FormWindowState.Maximized;
            Load += FAQ1_Load;
            sidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxlogo).EndInit();
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            reundedpnClass12.ResumeLayout(false);
            reundedpnClass12.PerformLayout();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            reundedpnClass11.ResumeLayout(false);
            reundedpnClass11.PerformLayout();
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
        private Panel panel1;
        private Panel panel3;
        private Panel panel4;
        private reundedPNClass1 reundedpnClass11;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private reundedPNClass1 reundedpnClass12;
        private Label label5;
        private Label label4;
        private Label labeljawaban;
        private Label label2;
        private Panel panel9;
        private Label labelpertanyaan;
        private Button button2;
        private Button button1;
        private Panel panel5;
        private Button btnkritikdanSaran;
        private Button button3;
        private Label label6;
        private Label label7;
    }
}