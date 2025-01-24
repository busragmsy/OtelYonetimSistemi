using System;

namespace otelYonetimFinal.DOMAIN
{
    public class Kur
    {
        public int KurID { get; set; }
        public string KurAd { get; set; }
        public string Sembol { get; set; }
        public decimal Deger { get; set; }
        public DateTime Tarih { get; set; }
        public int DurumID { get; set; }
        public string Durum { get; set; } // Join ile alınan durum adı
        public string DurumAd { get; set; }
    }
}
