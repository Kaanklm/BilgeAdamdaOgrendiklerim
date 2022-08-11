using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_StaticSample
{
    public class Personel
    {
        public Personel()
        {
            KisiSayisi++;
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public static int KisiSayisi { get; set; }
    }
}
