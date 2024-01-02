namespace UbahUnamePw
{
    partial class AdminUbahUsername
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminUbahUsername));
            panel1 = new Panel();
            btnVoucher = new Button();
            btnPaket = new Button();
            Homepage = new Button();
            pictureBoxLogo = new PictureBox();
            panel2 = new Panel();
            panel4 = new Panel();
            button1 = new Button();
            panel3 = new Panel();
            BtnBack = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(btnVoucher);
            panel1.Controls.Add(btnPaket);
            panel1.Controls.Add(Homepage);
            panel1.Controls.Add(pictureBoxLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(193, 731);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            btnVoucher.TabIndex = 22;
            btnVoucher.Text = "Faq";
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
            btnPaket.TabIndex = 21;
            btnPaket.Text = "Booking Hotel";
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
            Homepage.TabIndex = 20;
            Homepage.Text = "Destinasi";
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
            pictureBoxLogo.TabIndex = 1;
            pictureBoxLogo.TabStop = false;
            pictureBoxLogo.Click += pictureBoxLogo_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(198, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(899, 653);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackgroundImage = (Image)resources.GetObject("panel4.BackgroundImage");
            panel4.BackgroundImageLayout = ImageLayout.Stretch;
            panel4.Controls.Add(button1);
            panel4.Location = new Point(15, 47);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(871, 84);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 0);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(871, 73);
            button1.TabIndex = 0;
            button1.Text = "             Ubah Username dan Kata Sandi";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(55, 163, 165);
            panel3.Controls.Add(BtnBack);
            panel3.Location = new Point(198, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(902, 77);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // BtnBack
            // 
            BtnBack.BackColor = Color.Transparent;
            BtnBack.Cursor = Cursors.Hand;
            BtnBack.FlatAppearance.BorderSize = 0;
            BtnBack.FlatStyle = FlatStyle.Flat;
            BtnBack.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnBack.ForeColor = SystemColors.ButtonHighlight;
            BtnBack.Image = (Image)resources.GetObject("BtnBack.Image");
            BtnBack.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBack.Location = new Point(15, 17);
            BtnBack.Name = "BtnBack";
            BtnBack.Size = new Size(161, 40);
            BtnBack.TabIndex = 5;
            BtnBack.Text = "Pengaturan";
            BtnBack.TextAlign = ContentAlignment.MiddleRight;
            BtnBack.UseVisualStyleBackColor = false;
            BtnBack.Click += BtnBack_Click;
            // 
            // AdminUbahUsername
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 731);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminUbahUsername";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnVoucher;
        private Button btnPaket;
        private Button Homepage;
        private PictureBox pictureBoxLogo;
        private Panel panel2;
        private Panel panel3;
        private Button BtnBack;
        private Panel panel4;
        private Button button1;
    }
}