using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOP
{
    public class MusteriTemsilcisi:Insan
    {
        public override string Konus()
        {
            return "Merhaba ben" + TamAd + " size nasıl yardımcı olabilirim?";
        }
    }
}
