using System.Collections.Generic;
using System.Data;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class RezervasyonService
    {
        private RezervasyonDAL _rezervasyonDal;
        private DurumDAL _durumDAL;

        public RezervasyonService()
        {
            _rezervasyonDal = new RezervasyonDAL();
            _durumDAL = new DurumDAL(); // Burada başlatıldığından emin olun
        }

        public List<KeyValuePair<int, string>> GetAllDurum()
        {
            return _durumDAL.GetAllDurum(); // DurumDAL'ın GetAllDurum metodunu çağırır
        }

        public void AddRezervasyon(Rezervasyon rezervasyon)
        {
            _rezervasyonDal.AddRezervasyon(rezervasyon);
        }

        public List<KeyValuePair<int, string>> GetMisafirList()
        {
            return _rezervasyonDal.GetAllMisafir();
        }

        public List<KeyValuePair<int, string>> GetOdaList()
        {
            return _rezervasyonDal.GetAllOda();
        }

        public DataTable GetRezervasyonListWithDetails()
        {
            return _rezervasyonDal.GetRezervasyonListWithDetails();
        }

        public void DeleteRezervasyon(int rezervasyonID)
        {
            _rezervasyonDal.DeleteRezervasyon(rezervasyonID);
        }

        public void UpdateRezervasyon(Rezervasyon rezervasyon)
        {
            _rezervasyonDal.UpdateRezervasyon(rezervasyon);
        }

        public DataTable GetAktifRezervasyonlar()
        {
            return _rezervasyonDal.GetAktifRezervasyonlar();
        }

        public DataTable GetIptalEdilenRezervasyonlar()
        {
            return _rezervasyonDal.GetIptalEdilenRezervasyonlar();
        }

        public DataTable GetGecmisRezervasyonlar()
        {
            return _rezervasyonDal.GetGecmisRezervasyonlar();
        }

        public DataTable GetGelecekRezervasyonlar()
        {
            return _rezervasyonDal.GetGelecekRezervasyonlar();
        }

        public DataTable GetBugunGelecekMisafirler()
        {
            return _rezervasyonDal.GetBugunGelecekMisafirler();
        }

        public DataRow GetRezervasyonDetailsById(int rezervasyonID)
        {
            return _rezervasyonDal.GetRezervasyonDetailsById(rezervasyonID);
        }
    }
}
