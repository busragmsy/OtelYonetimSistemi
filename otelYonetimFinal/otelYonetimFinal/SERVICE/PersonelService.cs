using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using otelYonetimFinal.DAL;
using otelYonetimFinal.DOMAİN;

namespace otelYonetimFinal.SERVICE
{
    public class PersonelService
    {
        private PersonelDAL _personelDal;
        private DepartmanDAL _departmanDal;
        private GorevDAL _gorevDal;

        public PersonelService()
        {
            _personelDal = new PersonelDAL();
            _departmanDal = new DepartmanDAL(); // DepartmanDAL nesnesini başlat
            _gorevDal = new GorevDAL(); // GorevDAL nesnesini başlat
        }

        public void AddPersonel(Personel personel)
        {
            if (!string.IsNullOrWhiteSpace(personel.AdSoyad) && !string.IsNullOrWhiteSpace(personel.TC))
            {
                _personelDal.AddPersonel(personel);
            }
            else
            {
                throw new Exception("Personel bilgileri eksik!");
            }
        }

        public List<KeyValuePair<int, string>> GetDepartmanlar()
        {
            return _departmanDal.GetAllDepartman();
        }

        public List<KeyValuePair<int, string>> GetGorevler()
        {
            return _gorevDal.GetAllGorev();
        }

        public void DeletePersonel(int personelID)
        {
            _personelDal.DeletePersonel(personelID);
        }

        public Personel GetPersonelByID(int personelID)
        {
            return _personelDal.GetPersonelByID(personelID); // DAL'dan çağır
        }

        public void UpdatePersonel(Personel personel)
        {
            _personelDal.UpdatePersonel(personel); // DAL'dan çağır
        }

        public DataTable GetPersonelList()
        {
            return _personelDal.GetAllPersonel();
        }

    }
}
