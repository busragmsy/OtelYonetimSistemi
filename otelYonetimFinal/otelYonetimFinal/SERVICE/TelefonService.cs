using System;
using System.Collections.Generic;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class TelefonService
    {
        private TelefonDAL _telefonDal;

        public TelefonService()
        {
            _telefonDal = new TelefonDAL();
        }

        public List<Telefon> GetAllTelefon()
        {
            return _telefonDal.GetAllTelefon();
        }

        public void AddTelefon(Telefon telefon)
        {
            if (!string.IsNullOrWhiteSpace(telefon.Aciklama) && !string.IsNullOrWhiteSpace(telefon.TelefonNo))
            {
                _telefonDal.AddTelefon(telefon);
            }
            else
            {
                throw new System.Exception("Açıklama ve Telefon alanları boş olamaz.");
            }
        }

        public void UpdateTelefon(Telefon telefon)
        {
            if (telefon.TelefonID > 0 && !string.IsNullOrWhiteSpace(telefon.Aciklama) && !string.IsNullOrWhiteSpace(telefon.TelefonNo))
            {
                _telefonDal.UpdateTelefon(telefon);
            }
            else
            {
                throw new Exception("Güncelleme için geçerli bilgiler sağlanmadı.");
            }
        }

        public void DeleteTelefon(int telefonID)
        {
            if (telefonID > 0)
            {
                _telefonDal.DeleteTelefon(telefonID);
            }
            else
            {
                throw new System.Exception("Geçersiz Telefon ID.");
            }
        }
    }
}
