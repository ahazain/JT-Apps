using static Siticone.Desktop.UI.WinForms.Suite.Descriptions;

namespace JTAPPS_WIN
{
    partial class No_Darurat
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
            btnkritikdanSaran = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // btnkritikdanSaran
            // 
            btnkritikdanSaran.BackColor = Color.Black;
            btnkritikdanSaran.BackgroundImage = Properties.Resources.arrow_back__1_2;
            btnkritikdanSaran.BackgroundImageLayout = ImageLayout.Zoom;
            btnkritikdanSaran.FlatAppearance.BorderSize = 0;
            btnkritikdanSaran.FlatStyle = FlatStyle.Flat;
            btnkritikdanSaran.ForeColor = SystemColors.ActiveCaptionText;
            btnkritikdanSaran.Location = new Point(23, 25);
            btnkritikdanSaran.Name = "btnkritikdanSaran";
            btnkritikdanSaran.Size = new Size(31, 23);
            btnkritikdanSaran.TabIndex = 2;
            btnkritikdanSaran.UseVisualStyleBackColor = false;
            btnkritikdanSaran.Click += btnkritikdanSaran_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 113);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(116, 173);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 4;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 242);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 5;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Bold, GraphicsUnit.Pixel);
            label5.Location = new Point(116, 40);
            label5.Name = "label5";
            label5.Size = new Size(287, 20);
            label5.TabIndex = 7;
            label5.Text = "Daftar No Darurat Yang Tersedia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(296, 242);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 10;
            label4.Text = "label4";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(296, 173);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 9;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 113);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 8;
            label7.Text = "label7";
            label7.Click += label7_Click;
            // 
            // No_Darurat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnkritikdanSaran);
            Name = "No_Darurat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "No_Darurat";
            WindowState = FormWindowState.Maximized;
            Load += No_Darurat_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnkritikdanSaran;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label label6;
        private Label label7;
    }
}