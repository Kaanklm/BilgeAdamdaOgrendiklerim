using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public abstract class MuzikAleti
    {
        /*
         Abstract
        1-Abstract classlar/metotlar private tanımlanamazlar.
        2-Abstract metotlar sadece abstract classlar içerisinde tanımlanır.
        3-Abstract metotlar virtual tanımlanamazlar. 
        4- Abstract metotlar static tanımlanamaz.
        5- Abstract metotların gövdesi olmaz.

         */

        public string Marka { get; set; }
        public string Model { get; set; }
        public decimal Fiyat { get; set; }
        public string Tur { get; set; }
        public string Ad { get; set; }


        //public virtual string Cal()
        //{
        //    return "çalınıyor...";
        //}

        public abstract string Cal();//zorunlu hale getirildi.
    }
}
