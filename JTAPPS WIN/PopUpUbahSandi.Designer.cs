namespace JT_APPS__Final_Setting_
{
    partial class PopUpUbahSandi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpUbahSandi));
            label1 = new Label();
            BtnTidak = new Button();
            BtnYa = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            label1.ForeColor = Color.White;
            label1.Location = new Point(59, 37);
            label1.Name = "label1";
            label1.Size = new Size(312, 23);
            label1.TabIndex = 0;
            label1.Text = "Apakah anda yakin ingin menghapus akun?";
            // 
            // BtnTidak
            // 
            BtnTidak.BackColor = Color.Transparent;
            BtnTidak.FlatAppearance.BorderColor = Color.SlateGray;
            BtnTidak.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnTidak.ForeColor = Color.Black;
            BtnTidak.Location = new Point(223, 86);
            BtnTidak.Name = "BtnTidak";
            BtnTidak.Size = new Size(94, 29);
            BtnTidak.TabIndex = 3;
            BtnTidak.Text = "Tidak";
            BtnTidak.UseVisualStyleBackColor = false;
            // 
            // BtnYa
            // 
            BtnYa.BackColor = Color.Transparent;
            BtnYa.FlatAppearance.BorderColor = Color.SlateGray;
            BtnYa.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            BtnYa.ForeColor = Color.Black;
            BtnYa.Location = new Point(108, 86);
            BtnYa.Name = "BtnYa";
            BtnYa.Size = new Size(94, 29);
            BtnYa.TabIndex = 4;
            BtnYa.Text = "Ya";
            BtnYa.UseVisualStyleBackColor = false;
            BtnYa.Click += BtnYa_Click;
            // 
            // PopUpUbahSandi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(430, 157);
            Controls.Add(BtnYa);
            Controls.Add(BtnTidak);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "PopUpUbahSandi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PopUpUbahSandi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button BtnTidak;
        private Button BtnYa;
    }
}