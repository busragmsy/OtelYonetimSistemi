using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DOMAİN
{
    public class Misafir
    {
        public int MisafirID { get; set; }
        public string AdSoyad { get; set; }
        public string TC { get; set; }
        public string Mail { get; set; }
        public string Telefon { get; set; }
        public string Adres { get; set; }
        public string Aciklama { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Ilce { get; set; }
        public int Durum { get; set; }
    }
}