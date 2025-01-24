using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DOMAİN
{
    public class Durum
    {
        public Durum()
        {
            // Boş constructor, özellikle veri bağlama için gereklidir.
        }

        private int durumID; // DurumID
        public int DurumID
        {
            get { return durumID; }
            set { durumID = value; }
        }

        private string durumAd; // DurumAd
        public string DurumAd
        {
            get { return durumAd; }
            set { durumAd = value; }
        }

        // Constructor - ID olmadan
        public Durum(string durumAd)
        {
            this.DurumAd = durumAd;
        }

        // Constructor - ID ile
        public Durum(int durumID, string durumAd)
        {
            this.DurumID = durumID;
            this.DurumAd = durumAd;
        }

        public override string ToString()
        {
            return $"{DurumAd}";
        }
    }
}
