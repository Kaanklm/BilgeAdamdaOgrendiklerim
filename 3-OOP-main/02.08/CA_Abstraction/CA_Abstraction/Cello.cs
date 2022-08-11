using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public class Cello:MuzikAleti
    {
        public string AgacCinsi { get; set; }
        public override string Cal()
        {
            return "Çello Çalınıyor.";
        }
        public override string ToString()
        {
            return Ad + " " + Model + " " + Fiyat;
        }
    }
}
