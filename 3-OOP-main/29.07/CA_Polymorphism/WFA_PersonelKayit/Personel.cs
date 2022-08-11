using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_PersonelKayit
{
    public class Personel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime IseGirisTarihi { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad + " " + IseGirisTarihi;
        }
    }
}
