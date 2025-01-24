using MySql.Data.MySqlClient;
using System.Collections.Generic;
using otelYonetimFinal.DOMAİN;
using System;

namespace otelYonetimFinal.DAL
{
    public class DurumDAL
    {
        dbBaglanti db = new dbBaglanti();

        // Durumları Getir
        public List<Durum> GetDurumlar()
        {
            List<Durum> durumlar = new List<Durum>();
            using (MySqlConnection conn = db.BaglantiAc())
            {
                MySqlCommand cmd = new MySqlCommand("SELECT * FROM TblDurum", conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Durum durum = new Durum
                    {
                        DurumID = dr.GetInt32("DurumID"),
                        DurumAd = dr.GetString("DurumAd")
                    };
                    durumlar.Add(durum);
                }
                db.BaglantiKapat(conn);
            }
            return durumlar;
        }

        public List<Durum> GetAll()
        {

            List<Durum> durumlar = new List<Durum>();
            using (MySqlConnection conn = db.BaglantiAc())
            {
                string query = "SELECT DurumID, DurumAd FROM TblDurum";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    durumlar.Add(new Durum
                    {
                        DurumID = Convert.ToInt32(reader["DurumID"]),
                        DurumAd = reader["DurumAd"].ToString()
                    });
                }
            }
            return durumlar;
        }

        public List<KeyValuePair<int, string>> GetAllDurum()
        {
            var durumListesi = new List<KeyValuePair<int, string>>();
            using (MySqlConnection conn = db.BaglantiAc())
            {
                string query = "SELECT DurumID, DurumAd FROM TblDurum";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            durumListesi.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["DurumID"]),
                                reader["DurumAd"].ToString()));
                        }
                    }
                }
            }
            return durumListesi;
        }

        // Durum Ekle
        public void AddDurum(Durum durum)
        {
            using (MySqlConnection conn = db.BaglantiAc())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO TblDurum (DurumAd) VALUES (@DurumAd)", conn);
                cmd.Parameters.AddWithValue("@DurumAd", durum.DurumAd);
                cmd.ExecuteNonQuery();
                db.BaglantiKapat(conn);
            }
        }

        // Durum Sil
        public void DeleteDurum(int id)
        {
            using (MySqlConnection conn = db.BaglantiAc())
            {
                MySqlCommand cmd = new MySqlCommand("DELETE FROM TblDurum WHERE DurumID = @DurumID", conn);
                cmd.Parameters.AddWithValue("@DurumID", id);
                cmd.ExecuteNonQuery();
                db.BaglantiKapat(conn);
            }
        }

        // Durum Güncelle
        public void UpdateDurum(Durum durum)
        {
            using (MySqlConnection conn = db.BaglantiAc())
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE TblDurum SET DurumAd = @DurumAd WHERE DurumID = @DurumID", conn);
                cmd.Parameters.AddWithValue("@DurumAd", durum.DurumAd);
                cmd.Parameters.AddWithValue("@DurumID", durum.DurumID);
                cmd.ExecuteNonQuery();
                db.BaglantiKapat(conn);
            }
        }

    }
}
