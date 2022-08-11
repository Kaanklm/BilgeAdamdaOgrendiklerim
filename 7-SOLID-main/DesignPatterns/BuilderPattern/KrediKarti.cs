using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public class KrediKarti
    {
        public string BankaAdi { get; set; }
        public string KartTipi { get; set; }
        public decimal KartLimit { get; set; }
        public bool TaksitAtlama { get; set; }

        public override string ToString()
        {
            return $"{BankaAdi} bankasına ait müşteri {KartTipi} kart tipini kullanmakta ve {KartLimit} limiti vardır. Ayrıca taksit atlatma seçeneği ise {TaksitAtlama}";
        }

    }
}
