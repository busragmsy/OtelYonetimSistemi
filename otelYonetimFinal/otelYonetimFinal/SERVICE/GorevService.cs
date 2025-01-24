using System.Collections.Generic;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAIN;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class GorevService
    {
        private GorevDAL _gorevDAL;
        private DepartmanDAL _departmanDAL;
        private DurumDAL _durumDAL;

        public GorevService()
        {
            _gorevDAL = new GorevDAL();
            _departmanDAL = new DepartmanDAL();
            _durumDAL = new DurumDAL();
        }

        public List<Gorev> GetAllGorevler()
        {
            return _gorevDAL.GetAll();
        }

        public void AddGorev(Gorev gorev)
        {
            _gorevDAL.Add(gorev);
        }

        public List<Departman> GetDepartmanlar()
        {
            return _departmanDAL.GetDepartmanlar();
        }

        public List<Durum> GetDurumlar()
        {
            return _durumDAL.GetDurumlar();
        }

        public void DeleteGorev(int gorevId)
        {
            _gorevDAL.Delete(gorevId);
        }

        public void UpdateGorevAd(Gorev gorev)
        {
            _gorevDAL.UpdateGorevAd(gorev);
        }

    }
}
