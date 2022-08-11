using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi
{
    class Program
    {
        static void Main(string[] args)
        {

            //IEnumerable => liste içerisinde birden fazla liste kullanmak istenildiğinde kullanabiliriz.
            Kaleci kaleci = new Kaleci();
            kaleci.Ad = "Uğurcan";
            kaleci.Soyad = "Çakır";
            kaleci.FormaNumarasi = "1";
            kaleci.Agresiflik = 30;
            kaleci.Kondisyon = 70;
            kaleci.SutGucu = 65;
            kaleci.TopCalma = 55;

            List<Defans> defansListesi = new List<Defans>()
            {
                new Defans
                {
                    Ad="Ayhan",
                    Soyad="Kaan",
                    FormaNumarasi="2"
                },
                new Defans
                {
                    Ad="Merih",
                    Soyad="Demiral",
                    FormaNumarasi="5"
                },
                new Defans
                {
                    Ad="Çağlar",
                    Soyad="Söyüncü",
                    FormaNumarasi="6"
                },
            };

            List<OrtaSaha> ortaSahaListesi = new List<OrtaSaha>()
            {
                new OrtaSaha
                {
                    Ad="Zeki",
                    Soyad="Çelik"
                },
                new OrtaSaha
                {
                    Ad="Ozan",
                    Soyad="Tufan"
                },
                new OrtaSaha
                {
                    Ad="İrfan",
                    Soyad="Can"
                },
                new OrtaSaha
                {
                    Ad="Emre",
                    Soyad="Kılınç"
                },
            };

            List<Forvet> forvetListesi = new List<Forvet>()
            {
               new Forvet
                {
                    Ad="Cengiz",
                    Soyad="Ünder"
                },
                new Forvet
                {
                    Ad="Cenk",
                    Soyad="Tosun"
                },
                 new Forvet
                {
                    Ad="Ahmed",
                    Soyad="Kutucu"
                }
            };

            List<Futbolcu> futbolcuListesi = new List<Futbolcu>();

            foreach (Defans defans in defansListesi)
            {
                Console.WriteLine(defans.Kos());
            }

            Console.Read();
           
        }
    }
}
