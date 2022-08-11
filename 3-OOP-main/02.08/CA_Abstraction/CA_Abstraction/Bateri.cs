using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    public class Bateri : MuzikAleti
    {
        public override string Cal()
        {
            return "Bateri Çalınıyor";
        }
        public override string ToString()
        {
            return Marka + " " + Model + " " + Fiyat;
        }
    }
}
