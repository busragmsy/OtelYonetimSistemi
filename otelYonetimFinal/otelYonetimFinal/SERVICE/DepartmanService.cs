using System.Collections.Generic;
using System.Data;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class DepartmanService
    {
        private DepartmanDAL _departmanDAL;

        public DepartmanService()
        {
            _departmanDAL = new DepartmanDAL();
        }

        public List<Departman> GetDepartmanlar()
        {
            return _departmanDAL.GetDepartmanlar();
        }
        public DataTable gettable()
        {
            return _departmanDAL.GetDataTable();
        }

        public DataTable GetDurumlar()
        {
            return _departmanDAL.GetDurumlar();
        }

        public void AddDepartman(Departman departman)
        {
            _departmanDAL.AddDepartman(departman);
        }

        public void UpdateDepartman(Departman departman)
        {
            _departmanDAL.UpdateDepartman(departman);
        }

        public void DeleteDepartman(int departmanID)
        {
            _departmanDAL.DeleteDepartman(departmanID);
        }
    }
}
