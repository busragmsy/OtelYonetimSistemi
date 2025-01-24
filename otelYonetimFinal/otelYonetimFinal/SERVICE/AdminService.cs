using otelYonetimFinal.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.SERVICE
{
    public class AdminService
    {
        private readonly AdminDAL _adminDAL;

        public AdminService()
        {
            _adminDAL = new AdminDAL();
        }

        public bool GirisYap(string kullaniciAd, string sifre)
        {
            return _adminDAL.GirisYap(kullaniciAd, sifre);
        }

        public void UpdatePassword(string kullaniciAd, string yeniSifre)
        {
            _adminDAL.UpdatePassword(kullaniciAd, yeniSifre);
        }

        public bool KullaniciVarMi(string kullaniciAd)
        {
            return _adminDAL.KullaniciVarMi(kullaniciAd);
        }

        public bool ValidateUser(string kullaniciAdi, string sifre)
        {
            return _adminDAL.CheckUser(kullaniciAdi, sifre);
        }
    }
}
