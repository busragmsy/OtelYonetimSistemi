using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DOMAİN
{
    public class Rezervasyon
    {
        public int RezervasyonID { get; set; }
        public int MisafirID { get; set; }
        public int OdaID { get; set; }
        public DateTime GirisTarih { get; set; }
        public DateTime CikisTarih { get; set; }
        public string Kisi { get; set; }
        public string Telefon { get; set; }
        public string Aciklama { get; set; }
        public int Durum { get; set; }
        public string RezervasyonAdSoyad { get; set; }
    }
}
