using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOP
{
    public class Insan//Base
    {
        public Insan()
        {

        }

        public Insan(string _ad, string _soyad)
        {
            Ad = _ad;
            Soyad = _soyad;
        }

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string AnneAdi { get; set; }
        public string BabaAdi { get; set; }

        //TamAd

        public string TamAd
        {
            get
            {
                return Ad + " " + Soyad;
            }
        }

        public override string ToString()
        {
            return TamAd;
        }

        public virtual string Konus()
        {
            return "tanımlı ses";
        }

    }
}
