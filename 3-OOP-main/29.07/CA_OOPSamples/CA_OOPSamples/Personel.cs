using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPSamples
{
    public class Personel:Insan
    {
        public Personel()
        {
            IseGirisTarihi = DateTime.Now;
        }
        public decimal Maas { get; set; }
        public DateTime IseGirisTarihi { get; set; }
    }
}
