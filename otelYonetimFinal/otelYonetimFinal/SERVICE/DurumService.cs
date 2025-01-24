using System;
using System.Collections.Generic;
using otelYonetimFinal.DOMAİN;
using otelYonetimFinal.DAL;

namespace otelYonetimFinal.Service
{
    public class DurumService
    {
        private DurumDAL _durumDAL;

        public DurumService()
        {
            _durumDAL = new DurumDAL();
        }
        public List<Durum> GetDurumlar()
        {
            return _durumDAL.GetDurumlar();
        }

        // Yeni Durum Ekle
        public void AddDurum(Durum durum)
        {
            if (!string.IsNullOrEmpty(durum.DurumAd))
            {
                _durumDAL.AddDurum(durum);
            }
            else
            {
                throw new Exception("Durum adı boş olamaz.");
            }
        }

        // Durum Sil
        public void DeleteDurum(int id)
        {
            if (id > 0)
            {
                _durumDAL.DeleteDurum(id);
            }
            else
            {
                throw new Exception("Geçersiz ID.");
            }
        }

        public void UpdateDurum(Durum durum)
        {
            if (durum == null || durum.DurumID <= 0 || string.IsNullOrWhiteSpace(durum.DurumAd))
            {
                throw new ArgumentException("Geçersiz durum bilgileri.");
            }

            _durumDAL.UpdateDurum(durum);
        }

    }
}
