using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAIN;

namespace otelYonetimFinal.DAL
{
    public class KasaDAL
    {
        private readonly dbBaglanti _dbBaglanti = new dbBaglanti();

        public List<Kasa> GetAll()
        {
            List<Kasa> kasalar = new List<Kasa>();
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"SELECT k.KasaID, k.KasaAdi, k.Bakiye, k.Giren, k.Cikan, dur.DurumAd AS Durum
                                 FROM TblKasa k
                                 LEFT JOIN TblDurum dur ON k.Durum = dur.DurumID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kasalar.Add(new Kasa
                    {
                        KasaID = Convert.ToInt32(reader["KasaID"]),
                        KasaAdi = reader["KasaAdi"].ToString(),
                        Bakiye = Convert.ToDecimal(reader["Bakiye"]),
                        Giren = Convert.ToDecimal(reader["Giren"]),
                        Cikan = Convert.ToDecimal(reader["Cikan"]),
                        Durum = reader["Durum"].ToString()
                    });
                }
            }
            return kasalar;
        }

        public void Add(Kasa kasa)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = "INSERT INTO TblKasa (KasaAdi, Bakiye, Giren, Cikan, Durum) VALUES (@KasaAdi, @Bakiye, @Giren, @Cikan, @Durum)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KasaAdi", kasa.KasaAdi);
                cmd.Parameters.AddWithValue("@Bakiye", kasa.Bakiye);
                cmd.Parameters.AddWithValue("@Giren", kasa.Giren);
                cmd.Parameters.AddWithValue("@Cikan", kasa.Cikan);
                cmd.Parameters.AddWithValue("@Durum", kasa.DurumID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(Kasa kasa)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"UPDATE TblKasa 
                                 SET KasaAdi = @KasaAdi, Bakiye = @Bakiye, Giren = @Giren, Cikan = @Cikan, Durum = @Durum 
                                 WHERE KasaID = @KasaID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KasaAdi", kasa.KasaAdi);
                cmd.Parameters.AddWithValue("@Bakiye", kasa.Bakiye);
                cmd.Parameters.AddWithValue("@Giren", kasa.Giren);
                cmd.Parameters.AddWithValue("@Cikan", kasa.Cikan);
                cmd.Parameters.AddWithValue("@Durum", kasa.DurumID);
                cmd.Parameters.AddWithValue("@KasaID", kasa.KasaID);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int kasaID)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblKasa WHERE KasaID = @KasaID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KasaID", kasaID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
