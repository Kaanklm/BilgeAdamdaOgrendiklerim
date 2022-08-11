using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Araba
            //Audi

            //Abstract "is"
            //Interface "can"

            Audi audi = new Audi();
            audi.Marka = "Audi";
            audi.Model = "A5";
            audi.Renk = Renk.Lacivert;

            Tesla tesla = new Tesla();
            tesla.Marka = "Tesla";
            tesla.Model = "Model s";
            tesla.Renk = Renk.Beyaz;
            tesla.OtoPilot();

        }
    }
}
