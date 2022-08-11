using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_ConvertClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Convert (Tip Dönüşümleri)

            /*
                veri tipleri arasında tip dönüşümünü gerçekleştirmek istediğimizde kullanmış olduğumuz sıonıf: Convert sınıfın. Örnek vermek gerekirse C# dilinde string ifadeler "" çift tırmak içerisinde yazılır. "125" string bir ifade iken aynı zamanda sayıdır. 125 ifadesini çift tırnak içerisine almadığımızda rakam olarak tanımlanır.

                    --Kapalı Dönüşüm (Implicit Convert): Dönüştürme işlemini C# kendisi yapar.
                    --Açık Dönüşüm (Explicit Convert):Tipler arasındaki dönüştürme işlemini bizler gerçekleştiririz.
             */


            //Aşağıdaki örnekler Kapalı dönüşüm işlemi gerçekleştirir.
            //char karakter = 'a';
            //int karakterDeger = karakter;

            //byte byteSayi = 5;
            //short shortSayi = byteSayi;

            ////Aşağıdaki örnekler Açık dönüşüm işlemini gerçekleştirir.
            //string metinselDeger = "125";
            //int cevrilecekDeger = Convert.ToInt32(metinselDeger);
            //int toplam = 5 + cevrilecekDeger;

            //Console.WriteLine(toplam);

            //Console.Read();

            //Aşağıda tanımlanan iki adet string değerin toplamlarını console'da yazdırın.

            //string sayi1;
            //string sayi2;
            //string sonuc;

            //Console.WriteLine("Lütfen sayi 1 girin:");
            //sayi1 = Console.ReadLine();
            //Console.WriteLine("Lütfen sayi 2 girin:");
            //sayi2 = Console.ReadLine();
            //int sayiBir = Convert.ToInt32(sayi1);
            //int sayiIki = Convert.ToInt32(sayi2);

            //int toplamSonuc = sayiBir + sayiIki;
            //sonuc = toplamSonuc.ToString();//ToString() metodu herhangin bir tipi doğrudan string olarak göstermek için kullanılır.
            //Console.WriteLine("Toplam : " + sonuc);

            //Console.Read();

            //kullanıcıdan alınan vize ve final notlarının ortalamasını console'da yazdırın.
            //vize'nin %30
            //final'in %70

            string vize, final;
            double ortalama;


            Console.WriteLine("Vize Notunu Giriniz :");
            vize=Console.ReadLine();

            Console.WriteLine("Final Notunu Giriniz :");
            final=Console.ReadLine();

            ortalama = Convert.ToInt32(vize) * 0.3 + Convert.ToInt32(final) * 0.7;

            Console.WriteLine("Not Ortalaması :" + ortalama);


            Console.Read();

            //burası test işlemi.


        }
    }
}
