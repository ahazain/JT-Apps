using JTAPPS_WIN.Models;

namespace JTAPPS_WIN
{
    public partial class NewsletterHomepage : Form
    {
        NewsletterContext newsletterContext = new();

        public NewsletterHomepage()
        {
            InitializeComponent();
        }

        private void NewsletterHomepage_Load(object sender, EventArgs e)
        {
            ShowItems();
        }

        public void NewsItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (NewsletterForm updateForm = new NewsletterForm())
            {
                PictureBox pbNewsletter = sender as PictureBox;
                Newsletter newsletter = pbNewsletter.Tag as Newsletter;
                NewsletterContext newsletterContext = new NewsletterContext();
                updateForm.SetNewsletter(newsletter);

                DialogResult dr = updateForm.ShowDialog();

                if (dr == DialogResult.Ignore)
                {
                    // Code block untuk backend delete (Septi)
                    newsletterContext.Delete(newsletter);
                    ShowItems();
                }

                if (dr == DialogResult.OK)
                {
                    // Code block untuk backend Update (Firman)
                    newsletterContext.Update(newsletter);
                    ShowItems();
                }
            }
            this.Show();
        }

        private void ShowItems()
        {
            newsletterContext.ReadAll();
            List<Newsletter> newsletters;
            newsletters = newsletterContext.Newsletters;

            flpNewsletter.Controls.Clear();

            foreach (var newsletter in newsletters.TakeLast(3))
            {
                PictureBox newsItem = new NewsletterItem(newsletter).CreateItem();
                newsItem.Click += NewsItem_Click;
                flpNewsletter.Controls.Add(newsItem);
            }

            flpNewsletter.Controls.Add(btnAddNews);
        }

        private void BtnAddNews_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (NewsletterForm addNewForm = new())
            {
                DialogResult dr = addNewForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    Newsletter newsletter = addNewForm.GetNewsletter();
                    if (newsletterContext.Insert(newsletter))
                    {
                        newsletterContext.ReadAll();
                        MessageBox.Show(
                        "Berhasil!\n" +
                            "Date: " + newsletterContext.Newsletters.Last().Date +
                            "\nTitle: " + newsletterContext.Newsletters.Last().Title +
                            "\nDescription: " + newsletterContext.Newsletters.Last().Description +
                            "\nLink: " + newsletterContext.Newsletters.Last().Link +
                            "\nID: " + newsletterContext.Newsletters.Last().Id
                        );
                    }
                    else
                        MessageBox.Show("Gagal");
                }
            }
            this.Show();
            ShowItems();
        }

        private void pbgambar1_Click(object sender, EventArgs e)
        {

        }
    }
}