using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SampleVariables_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan, kullanıcının adı, soyadı, adresi ve telefon numarasını alarak ilgili değişkenlere aktarın.

            //string ad = "";
            //string soyad = "";
            //string adres = "";
            //string telefon = "";

            string ad, soyad, adres, telefon;
            int frekans = 500;
            int frekans2 = 750;
            int sure = 1000;
            int sure2 = 2000;

            Console.WriteLine("Lütfen adınızı girin:");
            ad = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Lütfen soyadınızı girin:");
            soyad = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Lütfen adresinizi girin...");
            adres = Console.ReadLine();
            Console.Beep();
            Console.WriteLine("Lütfen telefon numaranızı girin...");
            telefon = Console.ReadLine();

            Console.WriteLine("Lütfen bekleyin. bilgilerinizi kontrol ediyorum...");
            Console.Beep(frekans,sure);
            Console.Beep(frekans2, sure2);
            string sonuc = ad + " " + soyad + " " + adres + " " + telefon;
            Console.WriteLine(sonuc);
            Console.WriteLine("Borcunuz bulunmamaktadır :Pp");
            Console.Read();

        }
    }
}
