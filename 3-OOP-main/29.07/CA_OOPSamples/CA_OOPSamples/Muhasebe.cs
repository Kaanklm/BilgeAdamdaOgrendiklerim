using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPSamples
{
    public class Muhasebe:Personel
    {


        public decimal BordroHazirla(Personel p)
        {
            return p.Maas;
        }
    }
}
