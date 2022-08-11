using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public class Gitar:MuzikAleti
    {
        public bool Perdeli { get; set; }

        public override string Cal()
        {
            return Marka+" "+ "gitar çalınıyor";
        }

        public override string ToString()
        {
            return Ad + " " + Model + " " + Fiyat;
        }
    }
}
