using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListPenginapan;


namespace ListPenginapan
{
    public class penginapanitem
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(penginapanMain));
        Panel panel = new();
        Button btndetails = new();
        Label labelNama = new();
        penginapan penginapan;


        public penginapanitem(penginapan penginapan)

        {
            this.penginapan = penginapan;

            // panellist
            // 
            // panel.Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            panel.Anchor = AnchorStyles.None;
            panel.AutoSize = false;
            panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel.MinimumSize = new Size(892, 117);
            panel.BackColor = Color.Transparent;
            panel.BackgroundImage = (Image)resources.GetObject("panellist.BackgroundImage");
            panel.BackgroundImageLayout = ImageLayout.Stretch;
            panel.Controls.Add(btndetails);
            panel.Controls.Add(labelNama);
            panel.Location = new Point(3, 4);
            panel.Margin = new Padding(3, 4, 3, 4);
            panel.MaximumSize = new Size(1160, 533);
            panel.Name = "panellist";
            panel.Size = new Size(892, 117);
            panel.TabIndex = 12;

            panel.Controls.Add(btndetails);
            panel.Controls.Add(labelNama);
            // 
            // btndetails
            // 
            btndetails.Anchor = AnchorStyles.None;
            btndetails.Cursor = Cursors.Hand;
            btndetails.FlatAppearance.BorderSize = 0;
            btndetails.FlatStyle = FlatStyle.Flat;
            btndetails.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Pixel);
            btndetails.ForeColor = Color.Transparent;
            btndetails.Location = new Point(818, 85);
            btndetails.Margin = new Padding(0);
            btndetails.Name = "btndetails";
            btndetails.Size = new Size(54, 32);
            btndetails.TabIndex = 9;
            btndetails.Text = "Details";
            btndetails.UseVisualStyleBackColor = true;
            btndetails.Click += btndetails_Click;
            // 
            // labelNama
            // 
            labelNama.Anchor = AnchorStyles.Left;
            labelNama.AutoSize = true;
            labelNama.BackColor = Color.Transparent;
            labelNama.Font = new Font("Poppins Black", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            labelNama.ForeColor = Color.White;
            labelNama.Location = new Point(5, 45);
            labelNama.Margin = new Padding(0);
            labelNama.Name = "labelNama";
            labelNama.Size = new Size(112, 44);
            labelNama.TabIndex = 4;

            labelNama.TextAlign = ContentAlignment.MiddleCenter;
            // 


            labelNama.Text = penginapan.Nama;
        }

        private void btndetails_Click(object sender, EventArgs e)
        {
            using (Mawar1 updateForm = new Mawar1())
            {
                penginapanContext mypenginapancontext = new penginapanContext();
                updateForm.Setpenginapan(penginapan);
                DialogResult dr = updateForm.ShowDialog();
            }
        }
        public Panel CreateItem()
        {
            return panel;
        }


    }

}
