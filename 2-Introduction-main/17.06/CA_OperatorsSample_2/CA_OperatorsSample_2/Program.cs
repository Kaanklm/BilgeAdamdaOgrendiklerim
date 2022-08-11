using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OperatorsSample_2
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Tip değerleri
            //Console.WriteLine("Integer Min Deger=> " + int.MinValue + "\n" + "Integer Max Deger=> " + int.MaxValue + "\n");
            //Console.WriteLine("UInteger Min Deger=> " + uint.MinValue + "\n" + "UInteger Max Deger=> " + uint.MaxValue + "\n");

            //Console.WriteLine("Byte Min Deger=> " + byte.MinValue + "\n" + "Byte Max Deger=> " + byte.MaxValue + "\n");
            //Console.WriteLine("SByte Min Deger=> " + sbyte.MinValue + "\n" + "Sbyte Max Deger=> " + sbyte.MaxValue + "\n");

            //Console.WriteLine("Short Min Deger=> " + short.MinValue + "\n" + "Short Max Deger=> " + short.MaxValue + "\n");

            //Console.WriteLine("Long Min Deger=>" + long.MinValue + "\n" + "Long Max Deger=> " + long.MaxValue);

            //Console.Read(); 
            #endregion

            int sayi1 = 102;
            int sayi2 = 25;

            int toplam = sayi1 + sayi2;


            Console.WriteLine("Toplam işlemi sonucu: " + toplam);
            Console.WriteLine("Toplam işlemi sonucu: " + sayi1 + sayi2);
            Console.WriteLine("Toplam işlem sonucu: " + (sayi1 + sayi2));
            toplam++;
            Console.WriteLine("Toplam :" + toplam);
            toplam--;
            Console.WriteLine("Toplam :" + toplam);

            int mod = sayi1 % sayi2;
            Console.WriteLine("Mod :" + mod);
            //
            char karakter = 'a';//97
            int sayi = karakter;
            sayi++;
            //karakter = sayi;



            Console.Read();






        }
    }
}
