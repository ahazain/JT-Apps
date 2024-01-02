namespace membership5
{
    partial class popmembership
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(popmembership));
            Btnkembali = new Button();
            panelheader = new Panel();
            labelket = new Label();
            labelselamat = new Label();
            panel1 = new Panel();
            labelnama = new Label();
            panelheader.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            Btnkembali.Location = new Point(302, 383);
            Btnkembali.Name = "Btnkembali";
            Btnkembali.Size = new Size(213, 55);
            Btnkembali.TabIndex = 20;
            Btnkembali.Text = "Kembali";
            Btnkembali.UseVisualStyleBackColor = false;
            Btnkembali.Click += Btnkembali_Click;
            // 
            // panelheader
            // 
            panelheader.Anchor = AnchorStyles.Top;
            panelheader.Controls.Add(labelket);
            panelheader.Controls.Add(labelselamat);
            panelheader.Location = new Point(71, 6);
            panelheader.Name = "panelheader";
            panelheader.Size = new Size(675, 96);
            panelheader.TabIndex = 21;
            // 
            // labelket
            // 
            labelket.Anchor = AnchorStyles.Top;
            labelket.AutoSize = true;
            labelket.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelket.Location = new Point(212, 68);
            labelket.Name = "labelket";
            labelket.Size = new Size(249, 28);
            labelket.TabIndex = 2;
            labelket.Text = "Membership Anda telah aktif";
            // 
            // labelselamat
            // 
            labelselamat.Anchor = AnchorStyles.Top;
            labelselamat.AutoSize = true;
            labelselamat.Font = new Font("Poppins SemiBold", 40F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelselamat.Location = new Point(230, 0);
            labelselamat.Name = "labelselamat";
            labelselamat.Size = new Size(216, 70);
            labelselamat.TabIndex = 1;
            labelselamat.Text = "Selamat!";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(labelnama);
            panel1.Cursor = Cursors.Hand;
            panel1.Location = new Point(71, 101);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 215);
            panel1.TabIndex = 22;
            panel1.Paint += panel1_Paint;
            // 
            // labelnama
            // 
            labelnama.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            labelnama.AutoSize = true;
            labelnama.BackColor = Color.Transparent;
            labelnama.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelnama.ForeColor = Color.White;
            labelnama.Location = new Point(22, 172);
            labelnama.Name = "labelnama";
            labelnama.Size = new Size(195, 23);
            labelnama.TabIndex = 10;
            labelnama.Text = "Dinda Rachma Ayu Mauliza";
            // 
            // popmembership
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(panelheader);
            Controls.Add(Btnkembali);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "popmembership";
            panelheader.ResumeLayout(false);
            panelheader.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Btnkembali;
        private Panel panelheader;
        private Label labelselamat;
        private Label labelket;
        private Panel panel1;
        private Label labelnama;
        private Label label1;
    }
}