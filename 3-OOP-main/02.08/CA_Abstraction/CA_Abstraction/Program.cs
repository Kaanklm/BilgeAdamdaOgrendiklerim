using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Gitar gitar = new Gitar();
            gitar.Ad = "Gitar";
            gitar.Marka = "Ibanez";
            gitar.Model = "s2000";
            gitar.Perdeli = true;
            gitar.Tur = "Elektro";
            gitar.Fiyat = 7000;

            Cello cello = new Cello();
            cello.Ad = "Çello";
            cello.AgacCinsi = "Gül";
            cello.Fiyat = 10000;
            cello.Marka = "Yamaha";
            cello.Model = "hrs15";
            cello.Tur = "orta";

            Keman keman = new Keman();
            keman.Ad = "Keman";
            keman.Fiyat = 12000;
            keman.Marka = "Arpej";
            keman.Model = "arg5";
            keman.Tur = "El Yapımı";

            List<MuzikAleti> muzikAletleri = new List<MuzikAleti>();
            muzikAletleri.Add(gitar);
            muzikAletleri.Add(cello);
            muzikAletleri.Add(keman);


            Muzisyen muzisyen1 = new Muzisyen();
            muzisyen1.Ad = "İrem";
            muzisyen1.Soyad = "Pınar";
            muzisyen1.Enstruman = keman;

            Muzisyen muzisyen2 = new Muzisyen();
            muzisyen2.Ad = "Gökçen";
            muzisyen2.Soyad = "Akça";
            muzisyen2.Enstruman = cello;

            Muzisyen muzisyen3 = new Muzisyen();
            muzisyen3.Ad = "İbrahim";
            muzisyen3.Soyad = "Kaçar";
            muzisyen3.Enstruman = gitar;

            List<Muzisyen> muzisyenListesi = new List<Muzisyen>();
            muzisyenListesi.Add(muzisyen1);
            muzisyenListesi.Add(muzisyen2);
            muzisyenListesi.Add(muzisyen3);

            foreach (Muzisyen muzisyen in muzisyenListesi)
            {
                Console.WriteLine(muzisyen.Ad + " " + muzisyen.Soyad + " " + muzisyen.Enstruman);
            }
            Console.Read();
        }
    }
}
