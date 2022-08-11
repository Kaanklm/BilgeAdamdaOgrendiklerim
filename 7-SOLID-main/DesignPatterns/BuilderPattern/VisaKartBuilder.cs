using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class VisaKartBuilder : KrediKartBuilder
    {
        public VisaKartBuilder()
        {
            kart = new KrediKarti();
        }
        public override void BankaAdi()
        {
            kart.BankaAdi = "Garanti";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 15000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "Visa";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlama = false;
        }
    }
}
