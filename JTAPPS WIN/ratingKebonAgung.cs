using JTAPPS_WIN.Models;
using JTAPPS_WIN.Properties;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JTAPPS_WIN
{
    public partial class ratingKebonAgung : Form
    {
        ReviewContext reviewContext;
        private int selectedRating;
        public ratingKebonAgung()
        {
            reviewContext = new ReviewContext();
            InitializeComponent();
        }
        private void ShowItems()
        {
            reviewContext.Read();
            List<Review> reviewList;
            reviewList = reviewContext.reviewList;

            flowLayoutPanel1.Controls.Clear();
            foreach (var review in reviewList)
            {
                string ulasan = review.ulasan;
                int star = review.star;
                //string user = review.user;
                Panel reviewItem = new ReviewItem(ulasan, star).CreateItem();
                flowLayoutPanel1.Controls.Add(reviewItem);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__2___1_;
            star2.Image = Resources.star__2___1_;
            star3.Image = Resources.star__2___1_;
            star4.Image = Resources.star__2___1_;
            star5.Image = Resources.star__2___1_;
            string ulasan = tbUlasan.Text;
            int star = selectedRating;
            string id_wisata = "A04";
            int id_user = 1;

            Review newReview = new Review()
            {
                ulasan = ulasan,
                id_wisata = id_wisata,
                star = star,
                user_id = id_user,

            };

            bool isSuccess = reviewContext.Insert(newReview);

            if (isSuccess)
            {
                MessageBox.Show("Berhasil menambahkan review");
            }
            else
            {
                MessageBox.Show("Review gagal ditambahkan");
            }
            AverageRating();
            RefreshRatingTerakhir();
        }

        private void star1_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__1___1_;
            star2.Image = Resources.star__2___1_;
            star3.Image = Resources.star__2___1_;
            star4.Image = Resources.star__2___1_;
            star5.Image = Resources.star__2___1_;
            selectedRating = 1;
        }

        private void star2_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__1___1_;
            star2.Image = Resources.star__1___1_;
            star3.Image = Resources.star__2___1_;
            star4.Image = Resources.star__2___1_;
            star5.Image = Resources.star__2___1_;
            selectedRating = 2;
        }

        private void star3_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__1___1_;
            star2.Image = Resources.star__1___1_;
            star3.Image = Resources.star__1___1_;
            star4.Image = Resources.star__2___1_;
            star5.Image = Resources.star__2___1_;
            selectedRating = 3;
        }

        private void star4_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__1___1_;
            star2.Image = Resources.star__1___1_;
            star3.Image = Resources.star__1___1_;
            star4.Image = Resources.star__1___1_;
            star5.Image = Resources.star__2___1_;
            selectedRating = 4;
        }

        private void star5_Click(object sender, EventArgs e)
        {
            star1.Image = Resources.star__1___1_;
            star2.Image = Resources.star__1___1_;
            star3.Image = Resources.star__1___1_;
            star4.Image = Resources.star__1___1_;
            star5.Image = Resources.star__1___1_;
            selectedRating = 5;
        }
        private void rating_Load(object sender, EventArgs e)
        {
            AverageRating();
            RefreshRatingTerakhir();
            ShowItems();
        }

        private void AverageRating()
        {
            using (NpgsqlConnection conn = new NpgsqlConnection("host=localhost;port=5432;database=JT-Apps;user id=postgres;password=timotius"))
            {
                conn.Open();
                NpgsqlCommand cmd = conn.CreateCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select AVG(rating_tempat) from penilaian where wisata_id_wisata like'A04'";
                using (NpgsqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        float avgrating = reader.GetFloat(0);
                        label4.Text = avgrating.ToString("0.00");
                        if (avgrating >= 0.5 && avgrating < 1)
                        {
                            Bintang1.Image = Resources.lopGroup_7;
                            bintang2.Image = Resources.lop0Group_9;
                            bintang3.Image = Resources.lop0Group_9;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 1 && avgrating < 1.5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop0Group_9;
                            bintang3.Image = Resources.lop0Group_9;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 1.5 && avgrating < 2)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lopGroup_7;
                            bintang3.Image = Resources.lop0Group_9;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 2 && avgrating < 2.5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop0Group_9;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 2.5 && avgrating < 3)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lopGroup_7;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 3 && avgrating < 3.5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop2Group_8;
                            bintang4.Image = Resources.lop0Group_9;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 3.5 && avgrating < 4)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop2Group_8;
                            bintang4.Image = Resources.lopGroup_7;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 4 && avgrating < 4.5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop2Group_8;
                            bintang4.Image = Resources.lopGroup_7;
                            bintang5.Image = Resources.lop0Group_9;
                        }
                        if (avgrating >= 4.5 && avgrating < 5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop2Group_8;
                            bintang4.Image = Resources.lop2Group_8;
                            bintang5.Image = Resources.lopGroup_7;
                        }
                        if (avgrating == 5)
                        {
                            Bintang1.Image = Resources.lop2Group_8;
                            bintang2.Image = Resources.lop2Group_8;
                            bintang3.Image = Resources.lop2Group_8;
                            bintang4.Image = Resources.lop2Group_8;
                            bintang5.Image = Resources.lop2Group_8;
                        }

                    }

                }
            }
        }

        private void RefreshRatingTerakhir()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=JT-Apps;user id=postgres;password=timotius"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT rating_tempat FROM penilaian ORDER BY penilaian_id DESC LIMIT 1";

                using (NpgsqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int star = reader.GetInt32(0);
                        if (star == 1)
                        {
                            showStar1.Image = Resources.star__1___1_;
                        }
                        if (star == 2)
                        {
                            showStar1.Image = Resources.star__1___1_;
                            showStar2.Image = Resources.star__1___1_;
                        }
                        if (star == 3)
                        {
                            showStar1.Image = Resources.star__1___1_;
                            showStar2.Image = Resources.star__1___1_;
                            showStar3.Image = Resources.star__1___1_;
                        }
                        if (star == 4)
                        {
                            showStar1.Image = Resources.star__1___1_;
                            showStar2.Image = Resources.star__1___1_;
                            showStar3.Image = Resources.star__1___1_;
                            showStar4.Image = Resources.star__1___1_;
                        }
                        if (star == 5)
                        {
                            showStar1.Image = Resources.star__1___1_;
                            showStar2.Image = Resources.star__1___1_;
                            showStar3.Image = Resources.star__1___1_;
                            showStar4.Image = Resources.star__1___1_;
                            showStar5.Image = Resources.star__1___1_;
                        }
                    }
                }
                connection.Close();
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection("host=localhost;port=5432;database=JT-Apps;user id=postgres;password=timotius"))
            {
                connection.Open();
                NpgsqlCommand command = connection.CreateCommand();
                command.Connection = connection;
                command.CommandText = "DELETE FROM penilaian WHERE penilaian_id = @penilaian_id";
                command.Parameters.Add("penilaian_id", NpgsqlTypes.NpgsqlDbType.Integer).Value = 4; //diganti dengan penilaian_id yang ingin dihapus
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Data Berhasil Dihapus");

                lbUlasan.Text = "";
                showStar1.Image = Resources.star__2___1_;
                showStar2.Image = Resources.star__2___1_;
                showStar3.Image = Resources.star__2___1_;
                showStar4.Image = Resources.star__2___1_;
                showStar5.Image = Resources.star__2___1_;
            }
            AverageRating();
            //RefreshUlasanTerakhir();
            RefreshRatingTerakhir();
            //JumlahReview();
        }
    }
}
