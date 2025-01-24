using System;
using System.Collections.Generic;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;

namespace otelYonetimFinal.SERVICE
{
    public class KurService
    {
        private readonly KurDAL _kurDal = new KurDAL();

        public List<Kur> GetAllKur()
        {
            return _kurDal.GetAll();
        }

        public void AddKur(Kur kur)
        {
            _kurDal.Add(kur);
        }

        public void UpdateKur(Kur kur)
        {
            if (kur == null || kur.KurID <= 0)
                throw new ArgumentException("Geçersiz Kur bilgileri.");

            _kurDal.Update(kur);
        }


        public void DeleteKur(int kurID)
        {
            _kurDal.Delete(kurID);
        }
    }
}
