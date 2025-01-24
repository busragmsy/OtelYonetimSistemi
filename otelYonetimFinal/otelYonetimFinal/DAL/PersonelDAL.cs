using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.DAL
{
    public class PersonelDAL
    {
        private dbBaglanti _dbBaglanti = new dbBaglanti();

        public void AddPersonel(Personel personel)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            INSERT INTO TblPersonel 
            (AdSoyad, TC, Sifre, Departman, Gorev, IseGirisTarih, IstenCikisTarih, Adres, Telefon, Mail, Aciklama, Durum, KimlikOn, KimlikArka) 
            VALUES 
            (@AdSoyad, @TC, @Sifre, @Departman, @Gorev, @IseGirisTarih, @IstenCikisTarih, @Adres, @Telefon, @Mail, @Aciklama, @Durum, @KimlikOn, @KimlikArka)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AdSoyad", personel.AdSoyad);
                    cmd.Parameters.AddWithValue("@TC", personel.TC);
                    cmd.Parameters.AddWithValue("@Sifre", personel.Sifre);
                    cmd.Parameters.AddWithValue("@Departman", personel.DepartmanID);
                    cmd.Parameters.AddWithValue("@Gorev", personel.GorevID);
                    cmd.Parameters.AddWithValue("@IseGirisTarih", personel.IseGirisTarihi);
                    cmd.Parameters.AddWithValue("@IstenCikisTarih", personel.IstenCikisTarihi);
                    cmd.Parameters.AddWithValue("@Adres", personel.Adres);
                    cmd.Parameters.AddWithValue("@Telefon", personel.Telefon);
                    cmd.Parameters.AddWithValue("@Mail", personel.Mail);
                    cmd.Parameters.AddWithValue("@Aciklama", personel.Aciklama);
                    cmd.Parameters.AddWithValue("@Durum", personel.Durum);
                    cmd.Parameters.AddWithValue("@KimlikOn", personel.KimlikOn); // Kimlik ön URL
                    cmd.Parameters.AddWithValue("@KimlikArka", personel.KimlikArka); // Kimlik arka URL
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<KeyValuePair<int, string>> GetAllDepartman()
        {
            List<KeyValuePair<int, string>> departmanListesi = new List<KeyValuePair<int, string>>();
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT DepartmanID, DepartmanAd FROM TblDepartman";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            departmanListesi.Add(new KeyValuePair<int, string>(
                                Convert.ToInt32(reader["DepartmanID"]),
                                reader["DepartmanAd"].ToString()
                            ));
                        }
                    }
                }
            }
            return departmanListesi;
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

        public DataTable GetAllPersonel()
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            SELECT 
                p.PersonelID,
                p.AdSoyad,
                p.TC,
                d.DepartmanAd AS Departman,
                g.GorevAd AS Gorev,
                du.DurumAd AS Durum
            FROM 
                TblPersonel p
            LEFT JOIN TblDepartman d ON p.Departman = d.DepartmanID
            LEFT JOIN TblGorev g ON p.Gorev = g.GorevID
            LEFT JOIN TblDurum du ON p.Durum = du.DurumID;";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (var reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                    return dt;
                }
            }
        }

        public void DeletePersonel(int personelID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblPersonel WHERE PersonelID = @PersonelID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonelID", personelID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Personel GetPersonelByID(int personelID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT * FROM TblPersonel WHERE PersonelID = @PersonelID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonelID", personelID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Personel
                            {
                                PersonelID = Convert.ToInt32(reader["PersonelID"]),
                                AdSoyad = reader["AdSoyad"].ToString(),
                                TC = reader["TC"].ToString(),
                                Sifre = reader["Sifre"].ToString(),
                                DepartmanID = Convert.ToInt32(reader["Departman"]),
                                GorevID = Convert.ToInt32(reader["Gorev"]),
                                //IseGirisTarihi = reader["IseGirisTarih"] != DBNull.Value ? Convert.ToDateTime(reader["IseGirisTarih"]) : (DateTime?)null,
                                IstenCikisTarihi = reader["IstenCikisTarih"] != DBNull.Value ? Convert.ToDateTime(reader["IstenCikisTarih"]) : (DateTime?)null,
                                Adres = reader["Adres"].ToString(),
                                Telefon = reader["Telefon"].ToString(),
                                Mail = reader["Mail"].ToString(),
                                Aciklama = reader["Aciklama"].ToString(),
                                Durum = Convert.ToInt32(reader["Durum"]),
                                KimlikOn = reader["KimlikOn"].ToString(),
                                KimlikArka = reader["KimlikArka"].ToString()
                            };
                        }
                    }
                }
            }
            return null;
        }

        public void UpdatePersonel(Personel personel)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            UPDATE TblPersonel
            SET AdSoyad = @AdSoyad, TC = @TC, Sifre = @Sifre, Departman = @Departman, Gorev = @Gorev,
                IseGirisTarih = @IseGirisTarih, IstenCikisTarih = @IstenCikisTarih, Adres = @Adres,
                Telefon = @Telefon, Mail = @Mail, Aciklama = @Aciklama, Durum = @Durum,
                KimlikOn = @KimlikOn, KimlikArka = @KimlikArka
            WHERE PersonelID = @PersonelID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PersonelID", personel.PersonelID);
                    cmd.Parameters.AddWithValue("@AdSoyad", personel.AdSoyad);
                    cmd.Parameters.AddWithValue("@TC", personel.TC);
                    cmd.Parameters.AddWithValue("@Sifre", personel.Sifre);
                    cmd.Parameters.AddWithValue("@Departman", personel.DepartmanID);
                    cmd.Parameters.AddWithValue("@Gorev", personel.GorevID);
                    cmd.Parameters.AddWithValue("@IseGirisTarih", personel.IseGirisTarihi);
                    cmd.Parameters.AddWithValue("@IstenCikisTarih", personel.IstenCikisTarihi);
                    cmd.Parameters.AddWithValue("@Adres", personel.Adres);
                    cmd.Parameters.AddWithValue("@Telefon", personel.Telefon);
                    cmd.Parameters.AddWithValue("@Mail", personel.Mail);
                    cmd.Parameters.AddWithValue("@Aciklama", personel.Aciklama);
                    cmd.Parameters.AddWithValue("@Durum", personel.Durum);
                    cmd.Parameters.AddWithValue("@KimlikOn", personel.KimlikOn);
                    cmd.Parameters.AddWithValue("@KimlikArka", personel.KimlikArka);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
