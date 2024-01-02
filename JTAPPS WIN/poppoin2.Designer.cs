namespace Fitur_Poin
{
    partial class poppoin2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(poppoin2));
            panelheader = new Panel();
            labelket = new Label();
            labelselamat = new Label();
            Btnkembali = new Button();
            labellihatvcr = new Label();
            panelvcr2 = new Panel();
            pictureBoxdollar2 = new PictureBox();
            labelvcrharga2 = new Label();
            labelvcrket2 = new Label();
            labelvcrjudul2 = new Label();
            panelheader.SuspendLayout();
            panelvcr2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdollar2).BeginInit();
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
            // panelvcr2
            // 
            panelvcr2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelvcr2.BackColor = Color.White;
            panelvcr2.BackgroundImage = (Image)resources.GetObject("panelvcr2.BackgroundImage");
            panelvcr2.BackgroundImageLayout = ImageLayout.Stretch;
            panelvcr2.BorderStyle = BorderStyle.FixedSingle;
            panelvcr2.Controls.Add(pictureBoxdollar2);
            panelvcr2.Controls.Add(labelvcrharga2);
            panelvcr2.Controls.Add(labelvcrket2);
            panelvcr2.Controls.Add(labelvcrjudul2);
            panelvcr2.Location = new Point(55, 88);
            panelvcr2.Margin = new Padding(3, 2, 3, 2);
            panelvcr2.MinimumSize = new Size(591, 77);
            panelvcr2.Name = "panelvcr2";
            panelvcr2.Size = new Size(591, 77);
            panelvcr2.TabIndex = 25;
            // 
            // pictureBoxdollar2
            // 
            pictureBoxdollar2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxdollar2.BackColor = Color.Transparent;
            pictureBoxdollar2.Image = (Image)resources.GetObject("pictureBoxdollar2.Image");
            pictureBoxdollar2.Location = new Point(449, 18);
            pictureBoxdollar2.Margin = new Padding(3, 2, 3, 2);
            pictureBoxdollar2.Name = "pictureBoxdollar2";
            pictureBoxdollar2.Size = new Size(24, 24);
            pictureBoxdollar2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxdollar2.TabIndex = 11;
            pictureBoxdollar2.TabStop = false;
            // 
            // labelvcrharga2
            // 
            labelvcrharga2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelvcrharga2.AutoSize = true;
            labelvcrharga2.BackColor = Color.Transparent;
            labelvcrharga2.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrharga2.ForeColor = Color.White;
            labelvcrharga2.Location = new Point(485, 19);
            labelvcrharga2.Name = "labelvcrharga2";
            labelvcrharga2.Size = new Size(56, 28);
            labelvcrharga2.TabIndex = 10;
            labelvcrharga2.Text = "5.000";
            // 
            // labelvcrket2
            // 
            labelvcrket2.Anchor = AnchorStyles.Left;
            labelvcrket2.AutoSize = true;
            labelvcrket2.BackColor = Color.Transparent;
            labelvcrket2.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrket2.ForeColor = Color.Black;
            labelvcrket2.Location = new Point(56, 53);
            labelvcrket2.Name = "labelvcrket2";
            labelvcrket2.Size = new Size(294, 22);
            labelvcrket2.TabIndex = 7;
            labelvcrket2.Text = "Voucher tiket masuk dan parkir di rembangan";
            // 
            // labelvcrjudul2
            // 
            labelvcrjudul2.Anchor = AnchorStyles.Left;
            labelvcrjudul2.AutoSize = true;
            labelvcrjudul2.BackColor = Color.Transparent;
            labelvcrjudul2.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelvcrjudul2.ForeColor = Color.Black;
            labelvcrjudul2.Location = new Point(56, 11);
            labelvcrjudul2.Name = "labelvcrjudul2";
            labelvcrjudul2.Size = new Size(123, 56);
            labelvcrjudul2.TabIndex = 6;
            labelvcrjudul2.Text = "Patemon Gift \r\nVoucher";
            // 
            // poppoin2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 338);
            Controls.Add(panelvcr2);
            Controls.Add(labellihatvcr);
            Controls.Add(panelheader);
            Controls.Add(Btnkembali);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "poppoin2";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            panelheader.ResumeLayout(false);
            panelheader.PerformLayout();
            panelvcr2.ResumeLayout(false);
            panelvcr2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxdollar2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelheader;
        private Label labelket;
        private Label labelselamat;
        private Button Btnkembali;
        private Label labellihatvcr;
        private Panel panelvcr2;
        private PictureBox pictureBoxdollar2;
        private Label labelvcrharga2;
        private Label labelvcrket2;
        private Label labelvcrjudul2;
    }
}