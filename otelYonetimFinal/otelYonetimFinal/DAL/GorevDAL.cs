using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAIN;

namespace otelYonetimFinal.DAL
{
    public class GorevDAL
    {
        private readonly dbBaglanti _dbBaglanti;

        public GorevDAL()
        {
            _dbBaglanti = new dbBaglanti();
        }

        public List<Gorev> GetAll()
        {
            List<Gorev> gorevler = new List<Gorev>();
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"SELECT g.GorevID, g.GorevAd, 
                                d.DepartmanAd AS Departman, 
                                dur.DurumAd AS Durum
                         FROM TblGorev g
                         LEFT JOIN TblDepartman d ON g.Departman = d.DepartmanID
                         LEFT JOIN TblDurum dur ON g.Durum = dur.DurumID";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    gorevler.Add(new Gorev
                    {
                        GorevId = Convert.ToInt32(reader["GorevID"]),
                        GorevAd = reader["GorevAd"].ToString(),
                        Departman = reader["Departman"].ToString(),
                        Durum = reader["Durum"].ToString()
                    });
                }
            }
            return gorevler;
        }


        public void Add(Gorev gorev)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                string query = "INSERT INTO TblGorev (GorevAd, Departman, Durum) VALUES (@GorevAd, @Departman, @Durum)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@GorevAd", gorev.GorevAd);
                cmd.Parameters.AddWithValue("@Departman", gorev.Departman);
                cmd.Parameters.AddWithValue("@Durum", gorev.Durum);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateGorevAd(Gorev gorev)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "UPDATE TblGorev SET GorevAd = @GorevAd WHERE GorevID = @GorevID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GorevAd", gorev.GorevAd);
                    cmd.Parameters.AddWithValue("@GorevID", gorev.GorevId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Görev Adı güncellenirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public void Delete(int gorevId)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "DELETE FROM TblGorev WHERE GorevID = @GorevID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@GorevID", gorevId);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Görev silinirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public List<KeyValuePair<int, string>> GetAllGorev()
        {
            List<KeyValuePair<int, string>> gorevListesi = new List<KeyValuePair<int, string>>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT GorevID, GorevAd FROM TblGorev";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gorevListesi.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["GorevID"]),
                                reader["GorevAd"].ToString()
                            ));
                        }
                    }
                }
            }
            return gorevListesi;
        }
    }
}
