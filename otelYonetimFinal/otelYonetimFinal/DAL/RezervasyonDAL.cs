using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.DAL
{
    public class RezervasyonDAL
    {
        private dbBaglanti _dbBaglanti = new dbBaglanti();

        public RezervasyonDAL()
        {

        }

        public void AddRezervasyon(Rezervasyon rezervasyon)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "INSERT INTO TblRezervasyon (Misafir, Oda, GirisTarih, CikisTarih, Kisi, Telefon, Aciklama, RezervasyonAdSoyad, Durum) " +
                "VALUES (@Misafir, @Oda, @GirisTarih, @CikisTarih, @Kisi, @Telefon, @Aciklama, @RezervasyonAdSoyad, @Durum)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Misafir", rezervasyon.MisafirID);
                    cmd.Parameters.AddWithValue("@Oda", rezervasyon.OdaID);
                    cmd.Parameters.AddWithValue("@GirisTarih", rezervasyon.GirisTarih);
                    cmd.Parameters.AddWithValue("@CikisTarih", rezervasyon.CikisTarih);
                    cmd.Parameters.AddWithValue("@Kisi", rezervasyon.Kisi);
                    cmd.Parameters.AddWithValue("@Telefon", rezervasyon.Telefon);
                    cmd.Parameters.AddWithValue("@Aciklama", rezervasyon.Aciklama);
                    cmd.Parameters.AddWithValue("@RezervasyonAdSoyad", rezervasyon.RezervasyonAdSoyad);
                    cmd.Parameters.AddWithValue("@Durum", rezervasyon.Durum);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<KeyValuePair<int, string>> GetAllMisafir()
        {
            var misafirListesi = new List<KeyValuePair<int, string>>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT MisafirID, AdSoyad FROM TblMisafir";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            misafirListesi.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["MisafirID"]),
                                reader["AdSoyad"].ToString()));
                        }
                    }
                }
            }
            return misafirListesi;
        }

        public List<KeyValuePair<int, string>> GetAllOda()
        {
            var odaListesi = new List<KeyValuePair<int, string>>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT OdaID, OdaNo FROM TblOda";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            odaListesi.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["OdaID"]),
                                reader["OdaNo"].ToString()));
                        }
                    }
                }
            }
            return odaListesi;
        }

        public List<KeyValuePair<int, string>> GetAllDurum()
        {
            var durumListesi = new List<KeyValuePair<int, string>>();
            using (var conn = _dbBaglanti.BaglantiAc())
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

        public DataTable GetRezervasyonListWithDetails()
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT 
                r.RezervasyonID,
                m.AdSoyad AS MisafirAdSoyad,
                r.GirisTarih,
                r.CikisTarih,
                r.Kisi,
                o.OdaNo AS Oda,
                r.RezervasyonAdSoyad,
                r.Aciklama
            FROM 
                TblRezervasyon r
            INNER JOIN 
                TblMisafir m ON r.Misafir = m.MisafirID
            INNER JOIN 
                TblOda o ON r.Oda = o.OdaID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var rezervasyonTable = new DataTable();
                        adapter.Fill(rezervasyonTable);
                        return rezervasyonTable;
                    }
                }
            }
        }

        public void DeleteRezervasyon(int rezervasyonID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblRezervasyon WHERE RezervasyonID = @RezervasyonID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    // Parametre ekleniyor
                    cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonID);

                    // Sorgu çalıştırılıyor
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateRezervasyon(Rezervasyon rezervasyon)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"UPDATE TblRezervasyon 
                         SET Misafir = @MisafirID, 
                             Oda = @OdaID, 
                             GirisTarih = @GirisTarih, 
                             CikisTarih = @CikisTarih, 
                             Kisi = @Kisi, 
                             Telefon = @Telefon, 
                             Aciklama = @Aciklama, 
                             Durum = @DurumID
                         WHERE RezervasyonID = @RezervasyonID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyon.RezervasyonID);
                    cmd.Parameters.AddWithValue("@MisafirID", rezervasyon.MisafirID);
                    cmd.Parameters.AddWithValue("@OdaID", rezervasyon.OdaID);
                    cmd.Parameters.AddWithValue("@GirisTarih", rezervasyon.GirisTarih);
                    cmd.Parameters.AddWithValue("@CikisTarih", rezervasyon.CikisTarih);
                    cmd.Parameters.AddWithValue("@Kisi", rezervasyon.Kisi);
                    cmd.Parameters.AddWithValue("@Telefon", rezervasyon.Telefon);
                    cmd.Parameters.AddWithValue("@Aciklama", rezervasyon.Aciklama);
                    cmd.Parameters.AddWithValue("@DurumID", rezervasyon.Durum);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAktifRezervasyonlar()
        {
            DataTable dt = new DataTable();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT R.RezervasyonID, M.AdSoyad AS Misafir, R.GirisTarih, R.CikisTarih, 
                   R.Kisi, O.OdaNo AS Oda, R.RezervasyonAdSoyad, R.Telefon, R.Aciklama
            FROM TblRezervasyon R
            INNER JOIN TblMisafir M ON R.Misafir = M.MisafirID
            INNER JOIN TblOda O ON R.Oda = O.OdaID
            WHERE R.Durum IN (1, 4)"; // DurumID 1 olanları getir
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetIptalEdilenRezervasyonlar()
        {
            DataTable dt = new DataTable();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT R.RezervasyonID, M.AdSoyad AS Misafir, R.GirisTarih, R.CikisTarih, 
                   R.Kisi, O.OdaNo AS Oda, R.RezervasyonAdSoyad, R.Telefon, R.Aciklama
            FROM TblRezervasyon R
            INNER JOIN TblMisafir M ON R.Misafir = M.MisafirID
            INNER JOIN TblOda O ON R.Oda = O.OdaID
            WHERE R.Durum IN (2, 3, 5)"; // DurumID 24 olanları getir
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetGecmisRezervasyonlar()
        {
            DataTable dt = new DataTable();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT R.RezervasyonID, M.AdSoyad AS Misafir, R.GirisTarih, R.CikisTarih, 
                   R.Kisi, O.OdaNo AS Oda, R.RezervasyonAdSoyad, R.Telefon, R.Aciklama
            FROM TblRezervasyon R
            INNER JOIN TblMisafir M ON R.Misafir = M.MisafirID
            INNER JOIN TblOda O ON R.Oda = O.OdaID
            WHERE R.CikisTarih < CURDATE()"; // Çıkış tarihi bugünden küçük olanları getir
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataTable GetGelecekRezervasyonlar()
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
                    SELECT R.RezervasyonID, M.AdSoyad AS Misafir, R.GirisTarih, R.CikisTarih, R.Kisi, 
                           O.OdaNo AS Oda, R.RezervasyonAdSoyad, R.Telefon, R.Aciklama
                    FROM TblRezervasyon R
                    INNER JOIN TblMisafir M ON R.Misafir = M.MisafirID
                    INNER JOIN TblOda O ON R.Oda = O.OdaID
                    WHERE R.CikisTarih > @Bugun
                    ORDER BY R.CikisTarih ASC";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Bugun", DateTime.Now.Date);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
        }

        public DataTable GetBugunGelecekMisafirler()
        {
            DataTable dt = new DataTable();
            using (var conn = new dbBaglanti().BaglantiAc())
            {
                string query = @"
            SELECT 
                R.RezervasyonID,
                R.RezervasyonAdSoyad AS 'Ad Soyad',
                R.Telefon,
                R.GirisTarih AS 'Giriş Tarihi',
                R.CikisTarih AS 'Çıkış Tarihi',
                O.OdaNo AS 'Oda Numarası',
                R.Aciklama
            FROM TblRezervasyon R
            JOIN TblOda O ON R.Oda = O.OdaID
            WHERE DATE(R.GirisTarih) = CURDATE() AND R.Durum = 1";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        public DataRow GetRezervasyonDetailsById(int rezervasyonID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT * FROM TblRezervasyon WHERE RezervasyonID = @RezervasyonID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@RezervasyonID", rezervasyonID);

                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            return dt.Rows[0];
                        }
                        return null;
                    }
                }
            }
        }

    }
}
