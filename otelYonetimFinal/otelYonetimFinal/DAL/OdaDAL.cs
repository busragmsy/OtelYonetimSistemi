using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.DAL
{
    public class OdaDAL
    {
        private dbBaglanti _dbBaglanti = new dbBaglanti();

        public List<Oda> GetAll()
        {
            List<Oda> odaListesi = new List<Oda>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = @"
            SELECT o.OdaID, o.OdaNo, o.Kat, o.Kapasite, o.Telefon, d.DurumAd 
            FROM TblOda o 
            INNER JOIN TblDurum d ON o.Durum = d.DurumID";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                odaListesi.Add(new Oda
                                {
                                    OdaID = Convert.ToInt32(reader["OdaID"]),
                                    OdaNo = reader["OdaNo"].ToString(),
                                    Kat = reader["Kat"].ToString(),
                                    Kapasite = reader["Kapasite"].ToString(),
                                    Telefon = reader["Telefon"].ToString(),
                                    DurumAd = reader["DurumAd"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Veri okuma sırasında hata oluştu: " + ex.Message);
                }
            }
            return odaListesi;
        }

        public void AddOda(Oda oda)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "INSERT INTO TblOda (OdaNo, Kat, Kapasite, Aciklama, Telefon, Durum) VALUES (@OdaNo, @Kat, @Kapasite, @Aciklama, @Telefon, @Durum)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OdaNo", oda.OdaNo);
                cmd.Parameters.AddWithValue("@Kat", oda.Kat);
                cmd.Parameters.AddWithValue("@Kapasite", oda.Kapasite);
                cmd.Parameters.AddWithValue("@Aciklama", oda.Aciklama);
                cmd.Parameters.AddWithValue("@Telefon", oda.Telefon);
                cmd.Parameters.AddWithValue("@Durum", oda.DurumID);
                cmd.ExecuteNonQuery();
            }
        }

        // Oda güncelleme metodu
        public void UpdateOdaByOdaNo(string odaNo, int durumId)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "UPDATE TblOda SET Durum = @Durum WHERE OdaNo = @OdaNo";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Durum", durumId);
                    cmd.Parameters.AddWithValue("@OdaNo", odaNo);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Veritabanında güncelleme sırasında bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public void DeleteOda(int odaID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblOda WHERE OdaID = @OdaID";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OdaID", odaID);
                cmd.ExecuteNonQuery();
            }
        }

        public DataTable GetBosOdalar()
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT 
                O.OdaID, 
                O.OdaNo, 
                O.Kat, 
                O.Kapasite, 
                O.Telefon, 
                O.Aciklama 
            FROM TblOda O
            WHERE O.Durum = 4"; // Durum = 4 (Temiz)

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable bosOdalar = new DataTable();
                        adapter.Fill(bosOdalar);
                        return bosOdalar;
                    }
                }
            }
        }
        public DataTable GetTemizOdalar()
        {
            string query = "SELECT OdaID, OdaNo, Kat, Kapasite, Telefon, Aciklama FROM TblOda WHERE Durum = 4";
            return ExecuteQuery(query); // ExecuteQuery doğru bir şekilde tanımlandı mı kontrol edin
        }


        private DataTable ExecuteQuery(string query)
        {
            using (var conn = new MySqlConnection("Server=172.21.54.253;Database=25_132330029; User=25_132330029; Password=!nif.ogr29GU;"))
            {
                conn.Open();
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

    }
}
