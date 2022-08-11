using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism => Çok biçimlilik
            //Bir metodun farklı sınıflar için ffarklı etkiler oluşturmasını sağlar.

            Kopek kopek = new Kopek();
            kopek.Cinsi = "Kangal";
            kopek.Renk = "Sarı";
            kopek.SadikMi = true;
            kopek.Yas = 4;

            Console.WriteLine(kopek.SesCikar());

            Kedi kedi = new Kedi();
            kedi.Cinsi = "Tekir";
            kedi.Renk = "Siyah";
            kedi.Umursar = false;
            kedi.Yas = 2;

            Console.WriteLine(kedi.SesCikar());

            Kus kus = new Kus();
            kus.Cinsi = "Muhabbet";
            kus.Memeli = false;
            kus.Renk = "Mavi";
            kus.Yas = 1;

            Console.WriteLine(kus.SesCikar());

            KomodoEjderi komodoEjderi = new KomodoEjderi();
            Console.WriteLine(komodoEjderi.SesCikar());

            Console.Read();

        }
    }
}
