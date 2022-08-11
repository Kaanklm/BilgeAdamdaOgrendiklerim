using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class KrediKartiKullan
    {
        public void KartKullan(KrediKartBuilder kart)
        {
            kart.BankaAdi();
            kart.KartTipi();
            kart.KartLimit();
            kart.TaksitAtlatma();
        }
    }
}
