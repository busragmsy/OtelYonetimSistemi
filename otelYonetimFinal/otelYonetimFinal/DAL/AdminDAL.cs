using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DAL
{
    public class AdminDAL
    {
        private dbBaglanti _dbBaglanti;

        public AdminDAL()
        {
            _dbBaglanti = new dbBaglanti();
        }

        public bool GirisYap(string kullaniciAd, string sifre)
        {
            bool girisBasarili = false;

            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT COUNT(*) FROM TblAdmin WHERE KullaniciAd = @KullaniciAd AND Sifre = @Sifre";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);
                    cmd.Parameters.AddWithValue("@Sifre", sifre);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    girisBasarili = count > 0;
                }
            }

            return girisBasarili;
        }

        public void UpdatePassword(string kullaniciAd, string yeniSifre)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "UPDATE TblAdmin SET Sifre = @YeniSifre WHERE KullaniciAd = @KullaniciAd";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@YeniSifre", yeniSifre);
                    cmd.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool KullaniciVarMi(string kullaniciAd)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT COUNT(*) FROM TblAdmin WHERE KullaniciAd = @KullaniciAd";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@KullaniciAd", kullaniciAd);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool CheckUser(string kullaniciAdi, string sifre)
        {
            using (var conn = _dbBaglanti.BaglantiAc())
            {
                string query = "SELECT COUNT(*) FROM TblAdmin WHERE KullaniciAd = @KullaniciAd AND Sifre = @Sifre";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@KullaniciAd", kullaniciAdi);
                cmd.Parameters.AddWithValue("@Sifre", sifre);

                int result = Convert.ToInt32(cmd.ExecuteScalar());
                return result > 0;
            }
        }
    }
}
