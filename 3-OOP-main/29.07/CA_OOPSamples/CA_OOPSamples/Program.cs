using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Insan insan=new Insan();
            insan.Ad = "Fatih";
            insan.Soyad = "Günalp";

            Console.WriteLine(insan.TamAd);
        }
    }
}
