using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DOMAİN
{
    public class Personel
    {
        public int PersonelID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string Sifre { get; set; }
        public int DepartmanID { get; set; }
        public int GorevID { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public DateTime? IstenCikisTarihi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string Mail { get; set; }
        public string Aciklama { get; set; }
        public int Durum { get; set; }
        public string KimlikOn { get; set; } // Kimlik ön URL
        public string KimlikArka { get; set; } // Kimlik arka URL
    }

}
