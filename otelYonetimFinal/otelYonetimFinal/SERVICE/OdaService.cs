using System;
using System.Collections.Generic;
using System.Data;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.Service
{
    public class OdaService
    {
        private OdaDAL _odaDal;

        public OdaService()
        {
            _odaDal = new OdaDAL();
        }

        public List<Oda> GetAllOda()
        {
            return _odaDal.GetAll();
        }

        public void AddOda(Oda oda)
        {
            if (!string.IsNullOrWhiteSpace(oda.OdaNo) && !string.IsNullOrWhiteSpace(oda.Kat))
            {
                _odaDal.AddOda(oda);
            }
            else
            {
                throw new System.Exception("Oda bilgileri eksik.");
            }
        }

        // Oda güncelleme metodu
        public void UpdateOdaByOdaNo(string odaNo, int durumId)
        {
            if (string.IsNullOrWhiteSpace(odaNo))
            {
                throw new Exception("Oda numarası boş olamaz.");
            }

            if (durumId <= 0)
            {
                throw new Exception("Geçerli bir durum ID'si girilmelidir.");
            }

            _odaDal.UpdateOdaByOdaNo(odaNo, durumId);
        }

        public void DeleteOda(int odaID)
        {
            if (odaID > 0)
            {
                _odaDal.DeleteOda(odaID);
            }
            else
            {
                throw new System.Exception("Geçersiz Oda ID.");
            }
        }

        public DataTable GetTemizOdalar()
        {
            return _odaDal.GetTemizOdalar();
        }

    }
}
