using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.DAL
{
    public class DepartmanDAL
    {
        private readonly dbBaglanti _dbBaglanti = new dbBaglanti();

        public List<Departman> GetDepartmanlar()
        {
            List<Departman> departmanlar = new List<Departman>();

            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "SELECT d.DepartmanID, d.DepartmanAd, d.Telefon, d.Durum, dur.DurumAd " +
                                   "FROM TblDepartman d " +
                                   "LEFT JOIN TblDurum dur ON d.Durum = dur.DurumID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    using (var dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            departmanlar.Add(new Departman
                            {
                                DepartmanID = dr.GetInt32("DepartmanID"),
                                DepartmanAd = dr.GetString("DepartmanAd"),
                                Telefon = dr.GetString("Telefon"),
                                Durum = dr.GetInt32("Durum"),
                                DurumAd = dr.IsDBNull(dr.GetOrdinal("DurumAd")) ? "Bilinmiyor" : dr.GetString("DurumAd")
                            });
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Departman verileri alınırken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }

            return departmanlar;
        }

        public DataTable GetDurumlar()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "SELECT DurumID, DurumAd FROM TblDurum";
                    MySqlDataAdapter da = new MySqlDataAdapter(query, conn);
                    da.Fill(dt);
                }
                catch (Exception ex)
                {
                    throw new Exception("Durum verileri alınırken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }

            return dt;
        }
        //*******************************************************
        public DataTable GetDataTable()
        {
            MySqlConnection conn = _dbBaglanti.BaglantiAc();
            string query = "SELECT  d.DepartmanAd, d.Telefon, d.Durum " +
                                   "FROM TblDepartman d " +
                                   "Inner Join TblDurum dur ON d.Durum = dur.DurumID";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable ds = new DataTable();
            adapter.Fill(ds);
            return ds;
        }
        //*****************************************************************
        public void AddDepartman(Departman departman)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "INSERT INTO TblDepartman (DepartmanAd, Telefon, Durum) VALUES (@DepartmanAd, @Telefon, @Durum)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartmanAd", departman.DepartmanAd);
                    cmd.Parameters.AddWithValue("@Telefon", departman.Telefon);
                    cmd.Parameters.AddWithValue("@Durum", departman.Durum);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Departman eklenirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public void UpdateDepartman(Departman departman)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "UPDATE TblDepartman SET DepartmanAd = @DepartmanAd, Telefon = @Telefon, Durum = @Durum WHERE DepartmanID = @DepartmanID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartmanAd", departman.DepartmanAd);
                    cmd.Parameters.AddWithValue("@Telefon", departman.Telefon);
                    cmd.Parameters.AddWithValue("@Durum", departman.Durum);
                    cmd.Parameters.AddWithValue("@DepartmanID", departman.DepartmanID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Departman güncellenirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
                }
            }
        }

        public void DeleteDepartman(int departmanID)
        {
            using (MySqlConnection conn = _dbBaglanti.BaglantiAc())
            {
                try
                {
                    string query = "DELETE FROM TblDepartman WHERE DepartmanID = @DepartmanID";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DepartmanID", departmanID);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("Departman silinirken hata oluştu: " + ex.Message);
                }
                finally
                {
                    _dbBaglanti.BaglantiKapat(conn);
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
    }
}
