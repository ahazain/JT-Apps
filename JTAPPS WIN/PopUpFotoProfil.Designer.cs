namespace JT_APPS__Final_Setting_
{
    partial class PopUpFotoProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpFotoProfil));
            PBprofil = new PictureBox();
            label1 = new Label();
            BtnBatal = new Button();
            BtnSimpan = new Button();
            ((System.ComponentModel.ISupportInitialize)PBprofil).BeginInit();
            SuspendLayout();
            // 
            // PBprofil
            // 
            PBprofil.Image = (Image)resources.GetObject("PBprofil.Image");
            PBprofil.Location = new Point(16, 37);
            PBprofil.Name = "PBprofil";
            PBprofil.Size = new Size(294, 289);
            PBprofil.SizeMode = PictureBoxSizeMode.StretchImage;
            PBprofil.TabIndex = 0;
            PBprofil.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins SemiBold", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(86, 8);
            label1.Name = "label1";
            label1.Size = new Size(138, 28);
            label1.TabIndex = 1;
            label1.Text = "Ubah Foto Profil";
            // 
            // BtnBatal
            // 
            BtnBatal.BackColor = Color.Transparent;
            BtnBatal.FlatAppearance.BorderColor = Color.SlateGray;
            BtnBatal.FlatStyle = FlatStyle.Flat;
            BtnBatal.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnBatal.ForeColor = Color.White;
            BtnBatal.Location = new Point(179, 342);
            BtnBatal.Name = "BtnBatal";
            BtnBatal.Size = new Size(94, 29);
            BtnBatal.TabIndex = 2;
            BtnBatal.Text = "Batal";
            BtnBatal.UseVisualStyleBackColor = false;
            // 
            // BtnSimpan
            // 
            BtnSimpan.BackColor = Color.Transparent;
            BtnSimpan.BackgroundImage = (Image)resources.GetObject("BtnSimpan.BackgroundImage");
            BtnSimpan.FlatAppearance.BorderColor = Color.SlateGray;
            BtnSimpan.FlatStyle = FlatStyle.Flat;
            BtnSimpan.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnSimpan.ForeColor = Color.White;
            BtnSimpan.Location = new Point(51, 342);
            BtnSimpan.Name = "BtnSimpan";
            BtnSimpan.Size = new Size(94, 29);
            BtnSimpan.TabIndex = 3;
            BtnSimpan.Text = "Simpan";
            BtnSimpan.UseVisualStyleBackColor = false;
            // 
            // PopUpFotoProfil
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(327, 398);
            Controls.Add(BtnSimpan);
            Controls.Add(BtnBatal);
            Controls.Add(label1);
            Controls.Add(PBprofil);
            DoubleBuffered = true;
            MaximumSize = new Size(345, 445);
            Name = "PopUpFotoProfil";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUpFotoProfil";
            ((System.ComponentModel.ISupportInitialize)PBprofil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox PBprofil;
        private Label label1;
        private Button BtnBatal;
        private Button BtnSimpan;
    }
}