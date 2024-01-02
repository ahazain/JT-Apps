namespace data_staf
{
    partial class HapusStafAdmin
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
            tb_hapus_idstaf = new TextBox();
            btn_ok = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // tb_hapus_idstaf
            // 
            tb_hapus_idstaf.Location = new Point(146, 63);
            tb_hapus_idstaf.Name = "tb_hapus_idstaf";
            tb_hapus_idstaf.Size = new Size(331, 23);
            tb_hapus_idstaf.TabIndex = 0;
            tb_hapus_idstaf.TextChanged += tb_hapus_idstaf_TextChanged;
            // 
            // btn_ok
            // 
            btn_ok.Location = new Point(262, 110);
            btn_ok.Name = "btn_ok";
            btn_ok.Size = new Size(97, 33);
            btn_ok.TabIndex = 1;
            btn_ok.Text = "OK";
            btn_ok.UseVisualStyleBackColor = true;
            btn_ok.Click += btn_ok_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(108, 22);
            label1.Name = "label1";
            label1.Size = new Size(394, 24);
            label1.TabIndex = 2;
            label1.Text = "MASUKAN NAMA YANG INGIN DIHAPUS";
            label1.Click += label1_Click;
            // 
            // HapusStafAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 208);
            Controls.Add(label1);
            Controls.Add(btn_ok);
            Controls.Add(tb_hapus_idstaf);
            Name = "HapusStafAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tb_hapus_idstaf;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Label label1;
    }
}