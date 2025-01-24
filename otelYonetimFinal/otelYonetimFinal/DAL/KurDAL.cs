using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAIN;

namespace otelYonetimFinal.DAL
{
    public class KurDAL
    {
        private readonly dbBaglanti _dbBaglanti = new dbBaglanti();

        public List<Kur> GetAll()
        {
            List<Kur> kurListesi = new List<Kur>();
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
                    SELECT k.KurID, k.KurAd, k.Sembol, k.Deger, k.Tarih, k.Durum, d.DurumAd
                    FROM TblKur k
                    LEFT JOIN TblDurum d ON k.Durum = d.DurumID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    kurListesi.Add(new Kur
                    {
                        KurID = Convert.ToInt32(reader["KurID"]),
                        KurAd = reader["KurAd"].ToString(),
                        Sembol = reader["Sembol"].ToString(),
                        Deger = Convert.ToDecimal(reader["Deger"]),
                        Tarih = Convert.ToDateTime(reader["Tarih"]),
                        DurumID = Convert.ToInt32(reader["Durum"]),
                        DurumAd = reader["DurumAd"].ToString()
                    });
                }
            }
            return kurListesi;
        }

        public void Add(Kur kur)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "INSERT INTO TblKur (KurAd, Sembol, Deger, Tarih, Durum) VALUES (@KurAd, @Sembol, @Deger, @Tarih, @Durum)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KurAd", kur.KurAd);
                        cmd.Parameters.AddWithValue("@Sembol", kur.Sembol);
                        cmd.Parameters.AddWithValue("@Deger", kur.Deger);
                        cmd.Parameters.AddWithValue("@Tarih", kur.Tarih);
                        cmd.Parameters.AddWithValue("@Durum", kur.Durum);
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanına ekleme sırasında bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public void Update(Kur kur)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = @"UPDATE TblKur 
                             SET KurAd = @KurAd, 
                                 Sembol = @Sembol, 
                                 Deger = @Deger, 
                                 Tarih = @Tarih, 
                                 Durum = @Durum 
                             WHERE KurID = @KurID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KurID", kur.KurID);
                        cmd.Parameters.AddWithValue("@KurAd", kur.KurAd);
                        cmd.Parameters.AddWithValue("@Sembol", kur.Sembol);
                        cmd.Parameters.AddWithValue("@Deger", kur.Deger);
                        cmd.Parameters.AddWithValue("@Tarih", kur.Tarih);
                        cmd.Parameters.AddWithValue("@Durum", kur.Durum);

                        cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Güncelleme sırasında bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }


        public void Delete(int kurID)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblKur WHERE KurID = @KurID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KurID", kurID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
