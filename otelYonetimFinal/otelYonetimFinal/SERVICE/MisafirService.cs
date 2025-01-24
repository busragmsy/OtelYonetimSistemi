using System;
using System.Data;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class MisafirService
    {
        private MisafirDAL _misafirDal;

        public MisafirService()
        {
            _misafirDal = new MisafirDAL();
        }

        public void AddMisafir(Misafir misafir)
        {
            if (!string.IsNullOrWhiteSpace(misafir.AdSoyad) && !string.IsNullOrWhiteSpace(misafir.TC))
            {
                _misafirDal.AddMisafir(misafir);
            }
            else
            {
                throw new Exception("Ad Soyad ve TC boş bırakılamaz!");
            }
        }

        public DataTable GetMisafirList()
        {
            return _misafirDal.GetAllMisafir();
        }

        public void UpdateMisafir(Misafir misafir)
        {
            _misafirDal.UpdateMisafir(misafir);
        }

        public void DeleteMisafir(int misafirID)
        {
            _misafirDal.DeleteMisafir(misafirID);
        }

        public Misafir GetMisafirByID(int misafirID)
        {
            return _misafirDal.GetMisafirByID(misafirID);
        }

    }
}
