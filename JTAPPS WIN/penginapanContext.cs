using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ListPenginapan;

namespace ListPenginapan
{
    internal class penginapanContext
    {
        public List<penginapan> penginapanList = new List<penginapan>();

        public bool Read()
        {
            bool isSuccess = false;
            string constr = "Host=localhost;Port=5432;Database='JT-Apps';Username=postgres;Password=timotius";

            using (NpgsqlConnection conn = new NpgsqlConnection(constr))
            {
                string sql =
                    @"SELECT pk.nomor_kamar, pk.harga_paket, pk.deskripsi_paket, jk.id_jeniskamar, jk.nama_jeniskamar FROM paket_kamar pk JOIN jenis_kamar jk ON pk.jenis_kamar_id_jeniskamar = jk.id_jeniskamar";

                conn.Open();
                using NpgsqlCommand cmd = new NpgsqlCommand(sql, conn);
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader Reader = cmd.ExecuteReader();
                    penginapanList.Clear();
                    while (Reader.Read())
                    {
                        penginapan newPenginapan = new penginapan();

                        newPenginapan.Nama = (string)Reader["nama_jeniskamar"];
                        newPenginapan.label_navbar = (string)Reader["nama_jeniskamar"];
                        newPenginapan.nomor_kamar = (string)Reader["nomor_kamar"];
                        newPenginapan.deskripsi_paket = (string)Reader["deskripsi_paket"];
                        newPenginapan.harga_paket = Decimal.Parse(Reader["harga_paket"].ToString());

                        penginapanList.Add(newPenginapan);
                    }
                }
            }
            return isSuccess;
        }
    }
}
