namespace otelYonetimFinal.DOMAIN
{
    public class Kasa
    {
        public int KasaID { get; set; }
        public string KasaAdi { get; set; }
        public decimal Bakiye { get; set; }
        public decimal Giren { get; set; }
        public decimal Cikan { get; set; }
        public int DurumID { get; set; } // Foreign Key
        public string Durum { get; set; } // Durum Adı
    }
}
