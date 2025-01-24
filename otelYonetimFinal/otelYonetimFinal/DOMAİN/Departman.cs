namespace otelYonetimFinal.DOMAİN
{
    public class Departman
    {
        public int DepartmanID { get; set; }
        public string DepartmanAd { get; set; }
        public string Telefon { get; set; }
        public int Durum { get; set; } // DurumID
        public string DurumAd { get; set; } // Durum adı

        public Departman() { }

        public Departman(int departmanID, string departmanAd, string telefon, int durum, string durumAd)
        {
            DepartmanID = departmanID;
            DepartmanAd = departmanAd;
            Telefon = telefon;
            Durum = durum;
            DurumAd = durumAd;
        }
    }
}
