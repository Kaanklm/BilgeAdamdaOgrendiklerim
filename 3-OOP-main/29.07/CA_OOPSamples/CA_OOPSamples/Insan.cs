using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPSamples
{
    public class Insan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public string Cinsiyet { get; set; }

        public string TamAd { get { return Ad + " " + Soyad; } }//read only

        //private int _yas;
        //public int Yas//36
        //{
        //    get
        //    {
        //        return _yas;
        //    }
        //    set
        //    {
        //        _yas = value;
        //    }
        //}



    }
}
