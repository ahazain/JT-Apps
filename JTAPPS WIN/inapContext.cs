using Npgsql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inap
{
    internal class InapContext
    {
        public List<Inap> listInap = new List<Inap>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = "Server=localhost;Port=5432;Database=JT-Apps;User Id=postgres;Password=timotius";
            byte[] imageBytes;

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                conn.Open();
                string sql = "SELECT * FROM paket_kamar pk JOIN jenis_kamar jk ON pk.jenis_kamar_id_jeniskamar = jk.id_jeniskamar";

                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    using (NpgsqlDataReader Reader = cmd.ExecuteReader())
                    {
                        listInap.Clear();
                        while (Reader.Read())
                        {
                            imageBytes = (byte[])Reader["foto"];
                            try
                            {
                                using (MemoryStream ms = new MemoryStream(imageBytes))
                                {
                                    Image image = Image.FromStream(ms);

                                    Inap inap1 = new Inap();

                                    inap1.IdJenisKamar = (string)Reader["id_jeniskamar"];
                                    inap1.IdPaketKamar = (int)Reader["paket_kamar_id"];
                                    inap1.NamaJenisKamar = (string)Reader["nama_jeniskamar"];
                                    inap1.NomorKamar = (string)Reader["nomor_kamar"];
                                    inap1.HargaPaket = Decimal.Parse(Reader["harga_paket"].ToString());
                                    inap1.DeskripsiPaket = (string)Reader["deskripsi_paket"];
                                    inap1.Status = (int)Reader["status"];
                                    inap1.Image = image;

                                    listInap.Add(inap1);
                                }
                            }
                            catch (ArgumentException ex)
                            {
                                MessageBox.Show("Error loading image: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            }
                        }
                    }
                }
            }
            return isSuccess;
        }
    }
}