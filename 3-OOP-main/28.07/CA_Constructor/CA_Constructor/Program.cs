using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebek bebek1 = new Bebek();
            //bebek1.DogumTarihi = DateTime.Now;
            bebek1.AnneAdi = "Zeynep";
            bebek1.BabaAdi = "Murat";
            bebek1.Cinsiyet = "Erkek";
            bebek1.Kilo = 3.5;
            bebek1.Boy = 35;

            Bebek bebek2 = new Bebek();
            //bebek2.DogumTarihi = DateTime.Now;
            bebek1.AnneAdi = "Ayşe";
            bebek1.BabaAdi = "Hasan";
            bebek1.Cinsiyet = "Kız";
            bebek1.Kilo = 3.4;
            bebek1.Boy = 36;

            //Console.WriteLine("Bebek 1 Doğum Zamanı: " + bebek1.DogumTarihi);
            //Console.WriteLine("Bebek 2 Doğum Zamanı: " + bebek2.DogumTarihi);

            //Console.Read();

            Bebek bebek3 = new Bebek("Fatma");

            Bebek bebek4 = new Bebek();


        }
    }
}
