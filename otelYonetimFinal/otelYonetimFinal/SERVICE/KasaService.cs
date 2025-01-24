using System.Collections.Generic;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class KasaService
    {
        private readonly KasaDAL _kasaDal = new KasaDAL();
        private readonly DurumDAL _durumDal = new DurumDAL(); // Durum verilerini almak için

        public List<Kasa> GetAllKasalar()
        {
            return _kasaDal.GetAll();
        }

        public void AddKasa(Kasa kasa)
        {
            _kasaDal.Add(kasa);
        }

        public void UpdateKasa(Kasa kasa)
        {
            _kasaDal.Update(kasa);
        }

        public void DeleteKasa(int kasaID)
        {
            _kasaDal.Delete(kasaID);
        }

        // Burada Durum verilerini çekiyoruz
        public List<Durum> GetDurumlar()
        {
            return _durumDal.GetAll(); // DurumDAL'den verileri çekiyor
        }
    }
}
