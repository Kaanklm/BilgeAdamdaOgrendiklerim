using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPSamples
{
    public class InsanKaynaklari:Personel
    {
     
       //Ise Al
       //Rapor Gonder
       //Mulakat

        public void IseAl(Insan i)
        {
            Personel p = new Personel();
            p.Ad = i.Ad;
        }
    }
}
