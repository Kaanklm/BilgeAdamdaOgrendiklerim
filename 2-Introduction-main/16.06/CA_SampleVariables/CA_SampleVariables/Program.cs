using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_SampleVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax (Söz dizimi)

            /*
             1-kod satırları kesinlikle ; ile sonlandırılmalıdır.
             2-Değişken isimleri büyük küçük harf duyarlıdır. (Case Sensity)
             3-Değişken isimleri standart gereği küçük harf ile tanımlanmalıdır. Iki kelimeden oluşuyorsa camelCase şeklinde tanımlanmalı.
             4- Değişken isimleri rakam ile başlayamaz.
             5- Değişken isimlerinde özel karakter barındırılamaz.
             6- Değişken isimlerinde Türkçe karakter kullanılmamalıdır.

             */

            /*
                Ad,
                Soyad,
                Adres,
                Telefon,
                Boy,
                Kilo,
                Ayakkabı no,
                Kapı no,
                Hobiler,
                TcKimlikNo,
                Email Adres,
                arabanız var mı?
                ev kira mı?
                Burç,
                Cinsiyet,
                pi sayısı,
                İngilizce biliyor musun?
                Yabancı diller
                
             */
            string ad = "fatih";
            string soyad = "Günalp";
            string adres = "Kadıköy";
            string telefon = "05348357676";
            byte boy = 175;
            byte kilo = 72;
            byte ayakkabiNo = 42;
            byte kapiNo = 1;
            string hobiler = "kitap, müzik, film";
            string tckn = "11111111111";
            string email = "fatih.gunalp@bilgeadam.com";
            bool araba = false;
            bool ev = true;
            string burc = "Boğa";
            string cinsiyet = "erkek";
            decimal piSayisi = 3.14m;
            bool ingilizce = true;
            string yabanciDil = "İngilizce";

            #region Örnek Kod 1
            //Console.WriteLine("Ad: "+ad);
            //Console.WriteLine("Soyad :" + soyad);
            //Console.WriteLine("Adres :" + adres);
            //Console.WriteLine("Telefon :" + telefon);
            //Console.WriteLine("Boy :"+boy);
            //Console.WriteLine("Kilo :"+kilo);
            //Console.WriteLine("Ayakkabı No: "+ayakkabiNo);
            //Console.WriteLine("Kapı No: "+kapiNo);
            //Console.WriteLine("Hobiler :"+hobiler);
            //Console.WriteLine("Tc Kimlik No: "+tckn);
            //Console.WriteLine("Email :"+email);
            //Console.WriteLine("Araba :"+araba);
            //Console.WriteLine("Ev Kira mı? "+ev);
            //Console.WriteLine("Burç :"+burc);
            //Console.WriteLine("Cinsiyet :"+cinsiyet);
            //Console.WriteLine("Pi Sayısı: "+piSayisi);
            //Console.WriteLine("İngilizce biliyor musun? "+ingilizce);
            //Console.WriteLine("Yabancı Dil :"+yabanciDil);
            //Console.Read(); 
            #endregion

            #region Örnek Kod 2
            //not: \n karakterini kullanırsanız satırı birkez aşağıya atlatır.
            //Console.WriteLine("Ad :" + ad + "\n" + "Soyad :" + soyad + "\n" + "Adres :" + adres);
            //Console.Read(); 
            #endregion


            #region Örnek Kod 3
            //string result = "Ad :" + ad + "\n" + "Soyad :" + soyad + "\n" + "Adres :" + adres;
            //Console.WriteLine(result);
            //Console.Read(); 
            #endregion
        }
    }
}
