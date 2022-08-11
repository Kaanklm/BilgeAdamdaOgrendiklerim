using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class MasterKartBuilder : KrediKartBuilder
    {

        public MasterKartBuilder()
        {
            kart = new KrediKarti();
        }

        public override void BankaAdi()
        {
            kart.BankaAdi = "Türkiye İş Bankası";
        }

        public override void KartLimit()
        {
            kart.KartLimit = 10000;
        }

        public override void KartTipi()
        {
            kart.KartTipi = "MasterCard";
        }

        public override void TaksitAtlatma()
        {
            kart.TaksitAtlama = true;
        }
    }
}
