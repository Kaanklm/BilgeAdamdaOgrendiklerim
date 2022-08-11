using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public abstract class Araba//Base
    {
        //Properties (Özellikler)
        public string Marka { get; set; }
        public int KapiSayisi { get; set; }
        public string Model { get; set; }
        public Renk Renk { get; set; }

        //Eylemler (Method)
        public abstract string MaxHız();

    }
}
