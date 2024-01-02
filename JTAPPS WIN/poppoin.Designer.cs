namespace Fitur_Poin
{
    partial class poppoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poppoin));
            panelheader = new Panel();
            labelket = new Label();
            labelselamat = new Label();
            Btnkembali = new Button();
            labellihatvcr = new Label();
            pictureBoxdollar1 = new PictureBox();
            labelvcrharga1 = new Label();
            panelvcr1 = new Panel();
            labelvcrket1 = new Label();
            labelvcrjudul1 = new Label();
            panelheader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdollar1).BeginInit();
            panelvcr1.SuspendLayout();
            SuspendLayout();
            // 
            // panelheader
            // 
            panelheader.Anchor = AnchorStyles.Top;
            panelheader.Controls.Add(labelket);
            panelheader.Controls.Add(labelselamat);
            panelheader.Location = new Point(55, 2);
            panelheader.Margin = new Padding(3, 2, 3, 2);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(591, 84);
            panelheader.TabIndex = 23;
            // 
            // labelket
            // 
            labelket.Anchor = AnchorStyles.Top;
            labelket.AutoSize = true;
            labelket.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelket.Location = new Point(135, 51);
            labelket.Name = "labelket";
            labelket.Size = new Size(367, 28);
            labelket.TabIndex = 2;
            labelket.Text = "Anda telah berhasil mendapatkan voucher";
            // 
            // labelselamat
            // 
            labelselamat.Anchor = AnchorStyles.Top;
            labelselamat.AutoSize = true;
            labelselamat.Font = new Font("Poppins SemiBold", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelselamat.Location = new Point(200, 0);
            labelselamat.Name = "labelselamat";
            labelselamat.Size = new Size(216, 70);
            labelselamat.TabIndex = 1;
            labelselamat.Text = "Selamat!";
            // 
            // Btnkembali
            // 
            Btnkembali.Anchor = AnchorStyles.Bottom;
            Btnkembali.BackColor = Color.Transparent;
            Btnkembali.BackgroundImage = (Image)resources.GetObject("Btnkembali.BackgroundImage");
            Btnkembali.BackgroundImageLayout = ImageLayout.Zoom;
            Btnkembali.Cursor = Cursors.Hand;
            Btnkembali.FlatAppearance.BorderSize = 0;
            Btnkembali.FlatStyle = FlatStyle.Flat;
            Btnkembali.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            Btnkembali.ForeColor = SystemColors.ButtonHighlight;
            Btnkembali.Location = new Point(242, 275);
            Btnkembali.Margin = new Padding(3, 2, 3, 2);
            Btnkembali.Name = "Btnkembali";
            Btnkembali.Size = new Size(192, 41);
            Btnkembali.TabIndex = 22;
            Btnkembali.Text = "Kembali";
            Btnkembali.UseVisualStyleBackColor = false;
            Btnkembali.Click += Btnkembali_Click;
            // 
            // labellihatvcr
            // 
            labellihatvcr.Anchor = AnchorStyles.Top;
            labellihatvcr.AutoSize = true;
            labellihatvcr.Cursor = Cursors.Hand;
            labellihatvcr.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Pixel);
            labellihatvcr.Location = new Point(56, 171);
            labellihatvcr.Name = "labellihatvcr";
            labellihatvcr.Size = new Size(146, 22);
            labellihatvcr.TabIndex = 3;
            labellihatvcr.Text = "Lihat di menu voucher";
            labellihatvcr.Click += labellihatvcr_Click;
            // 
            // pictureBoxdollar1
            // 
            pictureBoxdollar1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxdollar1.BackColor = Color.Transparent;
            pictureBoxdollar1.Image = (Image)resources.GetObject("pictureBoxdollar1.Image");
            pictureBoxdollar1.Location = new Point(449, 18);
            pictureBoxdollar1.Margin = new Padding(3, 2, 3, 2);
            pictureBoxdollar1.Name = "pictureBoxdollar1";
            pictureBoxdollar1.Size = new Size(24, 24);
            pictureBoxdollar1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxdollar1.TabIndex = 11;
            pictureBoxdollar1.TabStop = false;
            // 
            // labelvcrharga1
            // 
            labelvcrharga1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            labelvcrharga1.AutoSize = true;
            labelvcrharga1.BackColor = Color.Transparent;
            labelvcrharga1.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrharga1.ForeColor = Color.White;
            labelvcrharga1.Location = new Point(485, 19);
            labelvcrharga1.Name = "labelvcrharga1";
            labelvcrharga1.Size = new Size(62, 28);
            labelvcrharga1.TabIndex = 10;
            labelvcrharga1.Text = "10.000";
            // 
            // panelvcr1
            // 
            panelvcr1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelvcr1.BackColor = Color.White;
            panelvcr1.BackgroundImage = (Image)resources.GetObject("panelvcr1.BackgroundImage");
            panelvcr1.BackgroundImageLayout = ImageLayout.Stretch;
            panelvcr1.BorderStyle = BorderStyle.FixedSingle;
            panelvcr1.Controls.Add(pictureBoxdollar1);
            panelvcr1.Controls.Add(labelvcrharga1);
            panelvcr1.Controls.Add(labelvcrket1);
            panelvcr1.Controls.Add(labelvcrjudul1);
            panelvcr1.Location = new Point(55, 88);
            panelvcr1.Margin = new Padding(3, 2, 3, 2);
            panelvcr1.MinimumSize = new Size(591, 77);
            panelvcr1.Name = "panelvcr1";
            panelvcr1.Size = new Size(591, 77);
            panelvcr1.TabIndex = 25;
            // 
            // labelvcrket1
            // 
            labelvcrket1.Anchor = AnchorStyles.Left;
            labelvcrket1.AutoSize = true;
            labelvcrket1.BackColor = Color.Transparent;
            labelvcrket1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrket1.ForeColor = Color.Black;
            labelvcrket1.Location = new Point(56, 53);
            labelvcrket1.Name = "labelvcrket1";
            labelvcrket1.Size = new Size(250, 22);
            labelvcrket1.TabIndex = 7;
            labelvcrket1.Text = "Voucher makan malam di Rembangan";
            // 
            // labelvcrjudul1
            // 
            labelvcrjudul1.Anchor = AnchorStyles.Left;
            labelvcrjudul1.AutoSize = true;
            labelvcrjudul1.BackColor = Color.Transparent;
            labelvcrjudul1.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrjudul1.ForeColor = Color.Black;
            labelvcrjudul1.Location = new Point(56, 11);
            labelvcrjudul1.Name = "labelvcrjudul1";
            labelvcrjudul1.Size = new Size(151, 56);
            labelvcrjudul1.TabIndex = 6;
            labelvcrjudul1.Text = "Rembangan Gift \r\nVoucher";
            // 
            // poppoin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(panelvcr1);
            Controls.Add(labellihatvcr);
            Controls.Add(panelheader);
            Controls.Add(Btnkembali);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "poppoin";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panelheader.ResumeLayout(false);
            panelheader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdollar1).EndInit();
            panelvcr1.ResumeLayout(false);
            panelvcr1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelheader;
        private Label labelket;
        private Label labelselamat;
        private Button Btnkembali;
        private Label labellihatvcr;
        private PictureBox pictureBoxdollar1;
        private Label labelvcrharga1;
        private Panel panelvcr1;
        private Label labelvcrket1;
        private Label labelvcrjudul1;
    }
}