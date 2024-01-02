namespace CheckOutHotel
{
    partial class ReservasiHotel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservasiHotel));
            panel1 = new Panel();
            Checkoutbtn = new Button();
            Historybtn = new Button();
            Voucherbtn = new Button();
            paketbtn = new Button();
            Homepagebtn = new Button();
            logo = new PictureBox();
            panel2 = new Panel();
            label6 = new Label();
            label3 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            textBox5 = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            textBox4 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Checkoutbtn);
            panel1.Controls.Add(Historybtn);
            panel1.Controls.Add(Voucherbtn);
            panel1.Controls.Add(paketbtn);
            panel1.Controls.Add(Homepagebtn);
            panel1.Controls.Add(logo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(169, 548);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // Checkoutbtn
            // 
            Checkoutbtn.Cursor = Cursors.Hand;
            Checkoutbtn.FlatAppearance.BorderSize = 0;
            Checkoutbtn.FlatStyle = FlatStyle.Flat;
            Checkoutbtn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Checkoutbtn.Location = new Point(10, 173);
            Checkoutbtn.Margin = new Padding(3, 2, 3, 2);
            Checkoutbtn.Name = "Checkoutbtn";
            Checkoutbtn.Size = new Size(148, 22);
            Checkoutbtn.TabIndex = 24;
            Checkoutbtn.Text = "Checkout";
            Checkoutbtn.UseVisualStyleBackColor = false;
            Checkoutbtn.Click += Checkoutbtn_Click;
            // 
            // Historybtn
            // 
            Historybtn.Cursor = Cursors.Hand;
            Historybtn.FlatAppearance.BorderSize = 0;
            Historybtn.FlatStyle = FlatStyle.Flat;
            Historybtn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Historybtn.Location = new Point(10, 148);
            Historybtn.Margin = new Padding(3, 2, 3, 2);
            Historybtn.Name = "Historybtn";
            Historybtn.Size = new Size(148, 22);
            Historybtn.TabIndex = 23;
            Historybtn.Text = "History";
            Historybtn.UseVisualStyleBackColor = false;
            Historybtn.Click += Historybtn_Click;
            // 
            // Voucherbtn
            // 
            Voucherbtn.Cursor = Cursors.Hand;
            Voucherbtn.FlatAppearance.BorderSize = 0;
            Voucherbtn.FlatStyle = FlatStyle.Flat;
            Voucherbtn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Voucherbtn.Location = new Point(10, 123);
            Voucherbtn.Margin = new Padding(3, 2, 3, 2);
            Voucherbtn.Name = "Voucherbtn";
            Voucherbtn.Size = new Size(148, 22);
            Voucherbtn.TabIndex = 22;
            Voucherbtn.Text = "Voucher";
            Voucherbtn.UseVisualStyleBackColor = false;
            Voucherbtn.Click += Voucherbtn_Click;
            // 
            // paketbtn
            // 
            paketbtn.Cursor = Cursors.Hand;
            paketbtn.FlatAppearance.BorderSize = 0;
            paketbtn.FlatStyle = FlatStyle.Flat;
            paketbtn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            paketbtn.Location = new Point(10, 98);
            paketbtn.Margin = new Padding(3, 2, 3, 2);
            paketbtn.Name = "paketbtn";
            paketbtn.Size = new Size(148, 22);
            paketbtn.TabIndex = 21;
            paketbtn.Text = "Paket";
            paketbtn.UseVisualStyleBackColor = false;
            paketbtn.Click += paketbtn_Click;
            // 
            // Homepagebtn
            // 
            Homepagebtn.Cursor = Cursors.Hand;
            Homepagebtn.FlatAppearance.BorderSize = 0;
            Homepagebtn.FlatStyle = FlatStyle.Flat;
            Homepagebtn.Font = new Font("Poppins SemiBold", 10F, FontStyle.Bold, GraphicsUnit.Pixel);
            Homepagebtn.Location = new Point(10, 74);
            Homepagebtn.Margin = new Padding(3, 2, 3, 2);
            Homepagebtn.Name = "Homepagebtn";
            Homepagebtn.Size = new Size(148, 22);
            Homepagebtn.TabIndex = 20;
            Homepagebtn.Text = "Homepage";
            Homepagebtn.UseVisualStyleBackColor = false;
            Homepagebtn.Click += Homepagebtn_Click;
            // 
            // logo
            // 
            logo.Image = (Image)resources.GetObject("logo.Image");
            logo.Location = new Point(64, 24);
            logo.Margin = new Padding(3, 2, 3, 2);
            logo.Name = "logo";
            logo.Size = new Size(38, 21);
            logo.SizeMode = PictureBoxSizeMode.StretchImage;
            logo.TabIndex = 19;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.AutoScroll = true;
            panel2.AutoScrollMinSize = new Size(787, 1688);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Location = new Point(173, 58);
            panel2.Name = "panel2";
            panel2.Size = new Size(787, 490);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(17, 274);
            label6.Name = "label6";
            label6.Size = new Size(56, 22);
            label6.TabIndex = 36;
            label6.Text = "Alamat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(17, 58);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 35;
            label3.Text = "Nama";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(55, 163, 165);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Poppins SemiBold", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(487, 446);
            button1.Name = "button1";
            button1.Size = new Size(163, 26);
            button1.TabIndex = 34;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(17, 231);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(559, 23);
            dateTimePicker1.TabIndex = 33;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 16);
            label2.Name = "label2";
            label2.Size = new Size(158, 28);
            label2.TabIndex = 32;
            label2.Text = "Informasi Personal";
            label2.Click += label2_Click;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.LightGray;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(17, 372);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(559, 23);
            textBox5.TabIndex = 31;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(17, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(559, 23);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(15, 347);
            label7.Name = "label7";
            label7.Size = new Size(190, 22);
            label7.TabIndex = 30;
            label7.Text = "Community Mode (Opsional)";
            label7.Click += label7_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(17, 154);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(559, 23);
            textBox2.TabIndex = 26;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.LightGray;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(17, 303);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(559, 23);
            textBox4.TabIndex = 29;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(17, 129);
            label4.Name = "label4";
            label4.Size = new Size(72, 22);
            label4.TabIndex = 27;
            label4.Text = "Nomor HP";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(17, 206);
            label5.Name = "label5";
            label5.Size = new Size(122, 22);
            label5.TabIndex = 28;
            label5.Text = "Tanggal Reservasi";
            label5.Click += label5_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(55, 163, 165);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(173, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(787, 58);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Poppins SemiBold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(338, 17);
            label1.Name = "label1";
            label1.Size = new Size(91, 28);
            label1.TabIndex = 2;
            label1.Text = "Reservasi";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // ReservasiHotel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 548);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(978, 587);
            Name = "ReservasiHotel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += ReservasiHotel_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button Checkoutbtn;
        private Button Historybtn;
        private Button Voucherbtn;
        private Button paketbtn;
        private Button Homepagebtn;
        private PictureBox logo;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private TextBox textBox5;
        private TextBox textBox1;
        private Label label7;
        private TextBox textBox2;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private Label label3;
        private Label label6;
    }
}
