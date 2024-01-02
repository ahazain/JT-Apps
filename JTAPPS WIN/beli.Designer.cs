namespace membership5
{
    partial class beli
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(beli));
            panelsidebar = new Panel();
            Checkoutbtn = new Button();
            Historybtn = new Button();
            Voucherbtn = new Button();
            paketbtn = new Button();
            Homepagebtn = new Button();
            logo = new PictureBox();
            panelsisip = new Panel();
            panelnavbar = new Panel();
            labelnavbar = new Label();
            backbtnnavbar = new Button();
            panelmain = new Panel();
            panel1 = new Panel();
            labelnama = new Label();
            panelmembership = new Panel();
            BtnSimpan = new Button();
            labelisimembership = new Label();
            panelsidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panelnavbar.SuspendLayout();
            panelmain.SuspendLayout();
            panel1.SuspendLayout();
            panelmembership.SuspendLayout();
            SuspendLayout();
            // 
            // panelsidebar
            // 
            panelsidebar.BackColor = Color.White;
            panelsidebar.Controls.Add(Checkoutbtn);
            panelsidebar.Controls.Add(Historybtn);
            panelsidebar.Controls.Add(Voucherbtn);
            panelsidebar.Controls.Add(paketbtn);
            panelsidebar.Controls.Add(Homepagebtn);
            panelsidebar.Controls.Add(logo);
            panelsidebar.Dock = DockStyle.Left;
            panelsidebar.Location = new Point(0, 0);
            panelsidebar.Margin = new Padding(3, 2, 3, 2);
            panelsidebar.Name = "panelsidebar";
            panelsidebar.Size = new Size(148, 411);
            panelsidebar.TabIndex = 0;
            // 
            // Checkoutbtn
            // 
            Checkoutbtn.Cursor = Cursors.Hand;
            Checkoutbtn.FlatAppearance.BorderSize = 0;
            Checkoutbtn.FlatStyle = FlatStyle.Flat;
            Checkoutbtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Checkoutbtn.Location = new Point(0, 169);
            Checkoutbtn.Margin = new Padding(3, 2, 3, 2);
            Checkoutbtn.Name = "Checkoutbtn";
            Checkoutbtn.Size = new Size(148, 22);
            Checkoutbtn.TabIndex = 6;
            Checkoutbtn.Text = "Wishlist";
            Checkoutbtn.UseVisualStyleBackColor = false;
            Checkoutbtn.Click += Checkoutbtn_Click;
            // 
            // Historybtn
            // 
            Historybtn.Cursor = Cursors.Hand;
            Historybtn.FlatAppearance.BorderSize = 0;
            Historybtn.FlatStyle = FlatStyle.Flat;
            Historybtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Historybtn.Location = new Point(0, 144);
            Historybtn.Margin = new Padding(3, 2, 3, 2);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(148, 22);
            Historybtn.TabIndex = 5;
            Historybtn.Text = "History";
            Historybtn.UseVisualStyleBackColor = false;
            Historybtn.Click += Historybtn_Click;
            // 
            // Voucherbtn
            // 
            Voucherbtn.Cursor = Cursors.Hand;
            Voucherbtn.FlatAppearance.BorderSize = 0;
            Voucherbtn.FlatStyle = FlatStyle.Flat;
            Voucherbtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Voucherbtn.Location = new Point(0, 119);
            Voucherbtn.Margin = new Padding(3, 2, 3, 2);
            Voucherbtn.Name = "Voucherbtn";
            Voucherbtn.Size = new Size(148, 22);
            Voucherbtn.TabIndex = 4;
            Voucherbtn.Text = "Voucher";
            Voucherbtn.UseVisualStyleBackColor = false;
            Voucherbtn.Click += Voucherbtn_Click;
            // 
            // paketbtn
            // 
            paketbtn.Cursor = Cursors.Hand;
            paketbtn.FlatAppearance.BorderSize = 0;
            paketbtn.FlatStyle = FlatStyle.Flat;
            paketbtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            paketbtn.Location = new Point(0, 94);
            paketbtn.Margin = new Padding(3, 2, 3, 2);
            paketbtn.Name = "paketbtn";
            paketbtn.Size = new Size(148, 22);
            paketbtn.TabIndex = 3;
            paketbtn.Text = "Paket";
            paketbtn.UseVisualStyleBackColor = false;
            paketbtn.Click += paketbtn_Click;
            // 
            // Homepagebtn
            // 
            Homepagebtn.Cursor = Cursors.Hand;
            Homepagebtn.FlatAppearance.BorderSize = 0;
            Homepagebtn.FlatStyle = FlatStyle.Flat;
            Homepagebtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Homepagebtn.Location = new Point(0, 70);
            Homepagebtn.Margin = new Padding(3, 2, 3, 2);
            Homepagebtn.Name = "Homepagebtn";
            Homepagebtn.Size = new Size(148, 22);
            Homepagebtn.TabIndex = 2;
            Homepagebtn.Text = "Homepage";
            Homepagebtn.UseVisualStyleBackColor = false;
            Homepagebtn.Click += Homepagebtn_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(54, 20);
            logo.Margin = new Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new Size(38, 21);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 1;
            logo.TabStop = false;
            // 
            // panelsisip
            // 
            panelsisip.BackColor = SystemColors.AppWorkspace;
            panelsisip.Dock = DockStyle.Left;
            panelsisip.Location = new Point(148, 0);
            panelsisip.Margin = new Padding(0);
            panelsisip.Name = "panelsisip";
            panelsisip.Size = new Size(4, 411);
            panelsisip.TabIndex = 2;
            // 
            // panelnavbar
            // 
            panelnavbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelnavbar.BackgroundImage = (Image)resources.GetObject("panelnavbar.BackgroundImage");
            panelnavbar.BackgroundImageLayout = ImageLayout.Stretch;
            panelnavbar.Controls.Add(labelnavbar);
            panelnavbar.Controls.Add(backbtnnavbar);
            panelnavbar.Location = new Point(151, 0);
            panelnavbar.Margin = new Padding(3, 2, 3, 2);
            panelnavbar.MinimumSize = new Size(689, 44);
            panelnavbar.Name = "panelnavbar";
            panelnavbar.Size = new Size(689, 44);
            panelnavbar.TabIndex = 2;
            // 
            // labelnavbar
            // 
            labelnavbar.Anchor = AnchorStyles.None;
            labelnavbar.AutoSize = true;
            labelnavbar.BackColor = Color.Transparent;
            labelnavbar.Font = new Font("Microsoft Sans Serif", 22F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelnavbar.ForeColor = Color.White;
            labelnavbar.Location = new Point(272, 13);
            labelnavbar.Name = "labelnavbar";
            labelnavbar.Size = new Size(142, 26);
            labelnavbar.TabIndex = 0;
            labelnavbar.Text = "Membership";
            labelnavbar.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // backbtnnavbar
            // 
            backbtnnavbar.BackColor = Color.Transparent;
            backbtnnavbar.FlatAppearance.BorderSize = 0;
            backbtnnavbar.FlatStyle = FlatStyle.Flat;
            backbtnnavbar.Image = (Image)resources.GetObject("backbtnnavbar.Image");
            backbtnnavbar.Location = new Point(10, 13);
            backbtnnavbar.Margin = new Padding(3, 2, 3, 2);
            backbtnnavbar.Name = "backbtnnavbar";
            backbtnnavbar.Size = new Size(15, 22);
            backbtnnavbar.TabIndex = 0;
            backbtnnavbar.UseVisualStyleBackColor = false;
            backbtnnavbar.Click += backbtnnavbar_Click;
            // 
            // panelmain
            // 
            panelmain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelmain.BackColor = Color.White;
            panelmain.Controls.Add(panel1);
            panelmain.Controls.Add(panelmembership);
            panelmain.Location = new Point(151, 44);
            panelmain.Margin = new Padding(3, 2, 3, 2);
            panelmain.MinimumSize = new Size(689, 368);
            panelmain.Name = "panelmain";
            panelmain.Size = new Size(689, 368);
            panelmain.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labelnama);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(49, 20);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(591, 161);
            panel1.TabIndex = 11;
            panel1.Paint += panel1_Paint;
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelnama.AutoSize = true;
            labelnama.BackColor = Color.Transparent;
            labelnama.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelnama.ForeColor = Color.White;
            labelnama.Location = new Point(12, 127);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(183, 15);
            labelnama.TabIndex = 9;
            labelnama.Text = "Dinda Rachma Ayu Mauliza";
            // 
            // panelmembership
            // 
            panelmembership.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panelmembership.Controls.Add(BtnSimpan);
            panelmembership.Controls.Add(labelisimembership);
            panelmembership.Location = new Point(49, 193);
            panelmembership.Margin = new Padding(3, 2, 3, 2);
            panelmembership.Name = "panelmembership";
            panelmembership.Size = new Size(591, 172);
            panelmembership.TabIndex = 3;
            // 
            // BtnSimpan
            // 
            BtnSimpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSimpan.BackColor = Color.Transparent;
            BtnSimpan.BackgroundImage = (Image)resources.GetObject("BtnSimpan.BackgroundImage");
            BtnSimpan.BackgroundImageLayout = ImageLayout.Stretch;
            BtnSimpan.Cursor = Cursors.Hand;
            BtnSimpan.FlatAppearance.BorderSize = 0;
            BtnSimpan.FlatStyle = FlatStyle.Flat;
            BtnSimpan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnSimpan.ForeColor = SystemColors.ButtonHighlight;
            BtnSimpan.Location = new Point(446, 121);
            BtnSimpan.Margin = new Padding(3, 2, 3, 2);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(140, 41);
            BtnSimpan.TabIndex = 19;
            BtnSimpan.Text = "Beli Membership";
            BtnSimpan.UseVisualStyleBackColor = false;
            BtnSimpan.Click += BtnSimpan_Click;
            // 
            // labelisimembership
            // 
            labelisimembership.AutoSize = true;
            labelisimembership.Dock = DockStyle.Left;
            labelisimembership.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelisimembership.Location = new Point(0, 0);
            labelisimembership.Name = "labelisimembership";
            labelisimembership.Size = new Size(199, 40);
            labelisimembership.TabIndex = 1;
            labelisimembership.Text = "JT-Apps MEMBERSHIP\nRp50.000";
            // 
            // beli
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 411);
            Controls.Add(panelmain);
            Controls.Add(panelnavbar);
            Controls.Add(panelsisip);
            Controls.Add(panelsidebar);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(858, 448);
            Name = "beli";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Membership";
            WindowState = FormWindowState.Maximized;
            Load += beli_Load;
            panelsidebar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panelnavbar.ResumeLayout(false);
            panelnavbar.PerformLayout();
            panelmain.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelmembership.ResumeLayout(false);
            panelmembership.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelsidebar;
        private PictureBox logo;
        private Panel panelsisip;
        private Panel panelnavbar;
        private Button Homepagebtn;
        private Button Checkoutbtn;
        private Button Historybtn;
        private Button Voucherbtn;
        private Button paketbtn;
        private Panel panelmain;
        private Button backbtnnavbar;
        private Label labelnavbar;
        private Label labelisimembership;
        private Panel panelmembership;
        private Button BtnSimpan;
        private Panel panel1;
        private Label labelnama;
    }
}