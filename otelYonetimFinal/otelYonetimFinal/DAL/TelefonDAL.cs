using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAİN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DAL
{
    public class TelefonDAL
    {
        private dbBaglanti _dbBaglanti = new dbBaglanti();

        public List<Telefon> GetAllTelefon()
        {
            List<Telefon> telefonListesi = new List<Telefon>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT TelefonID, Aciklama, Telefon AS TelefonNo FROM TblTelefon";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            telefonListesi.Add(new Telefon
                            {
                                TelefonID = reader.GetInt32("TelefonID"),
                                Aciklama = reader["Aciklama"].ToString(),
                                TelefonNo = reader["TelefonNo"].ToString()
                            });
                        }
                    }
                }
            }
            return telefonListesi;
        }

        public void AddTelefon(Telefon telefon)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "INSERT INTO TblTelefon (Aciklama, Telefon) VALUES (@Aciklama, @Telefon)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Aciklama", telefon.Aciklama);
                cmd.Parameters.AddWithValue("@Telefon", telefon.TelefonNo);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateTelefon(Telefon telefon)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "UPDATE TblTelefon SET Aciklama = @Aciklama, Telefon = @Telefon WHERE TelefonID = @TelefonID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TelefonID", telefon.TelefonID);
                cmd.Parameters.AddWithValue("@Aciklama", telefon.Aciklama);
                cmd.Parameters.AddWithValue("@Telefon", telefon.TelefonNo);
                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteTelefon(int telefonID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblTelefon WHERE TelefonID = @TelefonID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@TelefonID", telefonID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
