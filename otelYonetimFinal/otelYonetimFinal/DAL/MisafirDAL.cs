using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.DAL
{
    public class MisafirDAL
    {
        private dbBaglanti _dbBaglanti = new dbBaglanti();

        public void AddMisafir(Misafir misafir)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
                INSERT INTO TblMisafir 
                (AdSoyad, TC, Mail, Telefon, Adres, Aciklama, Ulke, Sehir, Ilce, Durum)
                VALUES 
                (@AdSoyad, @TC, @Mail, @Telefon, @Adres, @Aciklama, @Ulke, @Sehir, @Ilce, @Durum)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AdSoyad", misafir.AdSoyad);
                    cmd.Parameters.AddWithValue("@TC", misafir.TC);
                    cmd.Parameters.AddWithValue("@Mail", misafir.Mail);
                    cmd.Parameters.AddWithValue("@Telefon", misafir.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", misafir.Adres);
                    cmd.Parameters.AddWithValue("@Aciklama", misafir.Aciklama);
                    cmd.Parameters.AddWithValue("@Ulke", misafir.Ulke);
                    cmd.Parameters.AddWithValue("@Sehir", misafir.Sehir);
                    cmd.Parameters.AddWithValue("@Ilce", misafir.Ilce);
                    cmd.Parameters.AddWithValue("@Durum", 1); // Durum her zaman 1

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetAllMisafir()
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
                SELECT 
                    MisafirID, AdSoyad, TC, Mail, Telefon, Adres, Aciklama, Ulke, Sehir, Ilce, Durum 
                FROM TblMisafir";

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

        public void UpdateMisafir(Misafir misafir)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = @"
            UPDATE TblMisafir
            SET AdSoyad = @AdSoyad, 
                TC = @TC, 
                Mail = @Mail, 
                Telefon = @Telefon, 
                Adres = @Adres, 
                Aciklama = @Aciklama, 
                Ulke = @Ulke, 
                Sehir = @Sehir, 
                Ilce = @Ilce
            WHERE MisafirID = @MisafirID";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MisafirID", misafir.MisafirID);
                    cmd.Parameters.AddWithValue("@AdSoyad", misafir.AdSoyad);
                    cmd.Parameters.AddWithValue("@TC", misafir.TC);
                    cmd.Parameters.AddWithValue("@Mail", misafir.Mail);
                    cmd.Parameters.AddWithValue("@Telefon", misafir.Telefon);
                    cmd.Parameters.AddWithValue("@Adres", misafir.Adres);
                    cmd.Parameters.AddWithValue("@Aciklama", misafir.Aciklama);
                    cmd.Parameters.AddWithValue("@Ulke", misafir.Ulke);
                    cmd.Parameters.AddWithValue("@Sehir", misafir.Sehir);
                    cmd.Parameters.AddWithValue("@Ilce", misafir.Ilce);

                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void DeleteMisafir(int misafirID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "DELETE FROM TblMisafir WHERE MisafirID = @MisafirID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MisafirID", misafirID);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public Misafir GetMisafirByID(int misafirID)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT * FROM TblMisafir WHERE MisafirID = @MisafirID";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@MisafirID", misafirID);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Misafir
                            {
                                MisafirID = Convert.ToInt32(reader["MisafirID"]),
                                AdSoyad = reader["AdSoyad"].ToString(),
                                TC = reader["TC"].ToString(),
                                Mail = reader["Mail"].ToString(),
                                Telefon = reader["Telefon"].ToString(),
                                Adres = reader["Adres"].ToString(),
                                Aciklama = reader["Aciklama"].ToString(),
                                Ulke = reader["Ulke"].ToString(),
                                Sehir = reader["Sehir"].ToString(),
                                Ilce = reader["Ilce"].ToString(),
                                Durum = Convert.ToInt32(reader["Durum"])
                            };
                        }
                    }
                }
            }
            return null;
        }

    }
}
