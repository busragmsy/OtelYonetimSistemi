using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otelYonetimFinal.DOMAIN
{
    public class Oda
    {
        public int OdaID { get; set; }
        public string OdaNo { get; set; }
        public string Kat { get; set; }
        public string Kapasite { get; set; }
        public string Aciklama { get; set; }
        public string Telefon { get; set; }
        public int DurumID { get; set; }
        public string DurumAd { get; set; }
    }
}

