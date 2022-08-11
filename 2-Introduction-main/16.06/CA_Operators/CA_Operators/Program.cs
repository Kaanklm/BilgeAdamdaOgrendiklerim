using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operatörler

            //Atama Operatörü =

            //string degiskenBir = "değer bir";
            //string degiskenIki = "değer iki";
            //string degiskenUc = "değer üç";

            //Console.WriteLine(degiskenBir);
            //Console.WriteLine(degiskenIki);
            //Console.WriteLine(degiskenUc);

            //string butunDegiskenler = degiskenBir = degiskenIki = degiskenUc;

            //Console.WriteLine(degiskenBir);
            //Console.WriteLine(degiskenIki);
            //Console.WriteLine(degiskenUc);

            //Console.WriteLine(butunDegiskenler);

            //Console.Read();

            //Mantıksal Operatörler

            /*
                && => ve
                || => veya  (AltGr+<>)
                ! => değil
             */

            //İlişkisel Operatörler
            /*
                >   büyüktür
                <   küçüktür
                >=  büyük eşittir
                <=  küçük eşittir
                ==  eşit eşittir
                !=  eşit değildir.
             */

            //Aritmetik Operatörler
            /*
                +   toplama
                -   çıkarma
                *   çarpma
                /   bölme
                %   mod
             */

            //Birleşik Operatörler
            /*
               +=  topla ve aktar
               -=  çıkar ve aktar
               *=  çarp ve aktar
               /=  böl ve aktar
             */

            //int sayiBir = 5;
            //int sayiIki = 5;
            //sayiIki += sayiBir;
            //Console.WriteLine(sayiIki);//sonuc bize 10 olarak teslim edilir.

            //Örnek 1
            //vize notunun %30'u, final notunun %70'ni alıp öğrencinin not ortalamasını veren console uygulamasını yazın.
            //vize=45
            //final=80

           // double vize = 45;
           // double final = 80;

           // double sonuc = (vize * 0.30) + (final * 0.70);

           //Console.WriteLine(sonuc);

            //Örnek 2
            //Console'a yazılan değer "admin" ise bize true değerini versin değilse false değerini versin.

            Console.WriteLine("lütfen değer girin: ");
            string deger = Console.ReadLine();//admin
            bool sonuc = deger == "admin";

            Console.WriteLine(sonuc);
            Console.Read();

            

        }
    }
}
