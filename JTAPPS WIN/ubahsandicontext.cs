using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JTAPPS_WIN
{
    internal class ubahsandicontext
    {
        public List<ubahsandiprop> ubahsandiProp = new List<ubahsandiprop>();
        public bool IsPasswordValid(ubahsandiprop ubahsandiProps)
        {
            bool IsSuccess = false;
            string connectionString = "Host=localhost:5432;Username=postgres;Password=timotius;Database=JT-Apps";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string readSandiQuery = "SELECT COUNT(*) FROM \"User\" WHERE email = @email AND kata_sandi = @Sandi";
                using (var command = new NpgsqlCommand(readSandiQuery, connection))
                {
                    command.Parameters.AddWithValue("email", ubahsandiProps.email);
                    command.Parameters.AddWithValue("Sandi", ubahsandiProps.passwordlama);
                    command.CommandType = System.Data.CommandType.Text;
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 1)
                    {
                        IsSuccess = true;
                        ubahsandiProp.Add(ubahsandiProps);
                    }
                }
            }
            return IsSuccess;
        }
        public bool UpdatePassword(ubahsandiprop ubahsandiProps)
        {
            bool IsSuccess = false;
            string connectionString = "Host=localhost:5432;Username=postgres;Password=timotius;Database=JT-Apps";
            using (var connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string updateSandiQuery = "UPDATE \"User\" SET kata_sandi = @Sandi WHERE email = @Email";
                using (var command = new NpgsqlCommand(updateSandiQuery, connection))
                {
                    command.Parameters.AddWithValue("Sandi", ubahsandiProps.passwordbaru);
                    command.Parameters.AddWithValue("Email", ubahsandiProps.email);
                    command.CommandType = System.Data.CommandType.Text;
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        IsSuccess = true;
                        ubahsandiProp.Add(ubahsandiProps);
                    }

                }
            }
            return IsSuccess;

        }
    }
}
