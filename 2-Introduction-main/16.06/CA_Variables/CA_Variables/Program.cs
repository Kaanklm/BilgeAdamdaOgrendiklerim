/*.Net Framework*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Variables
{//scope
    class Program
    {

        //metot
        static void Main(string[] args)
        {//scope

            //Syntax (Söz dizimi)

            /*
             1-kod satırları kesinlikle ; ile sonlandırılmalıdır.
             2-Değişken isimleri büyük küçük harf duyarlıdır. (Case Sensity)
             3-Değişken isimleri standart gereği küçük harf ile tanımlanmalıdır.
             4- Değişken isimleri rakam ile başlayamaz.
             5- Değişken isimlerinde özel karakter barındırılamaz.
             6

             */

            //Variables (Değişkenler)
            //Değişkenleri en basit şekilde verilerin depolandığı yerler olarak tanımlayabiliriz. Değişkenlerin içine verilerimizi gönderebiliriz veya değişkenler içerisindeki verileri C# programındaki işlemlerimizde kullanabiliriz.


            //Sayısal
            //1-Tam sayısal tipler

            //byte   8bit    0 ile 255
            //sbyte  8bit    -128 ile 127
            //short  16bit   -32768 ile 32767
            //ushort 16bit   0 ile 65535
            //int    32bit   -2milyar ile 2 milyar
            //uint   32bit   0 ile 4 milyar
            //long   64bit   -9katrilyon 9 katrilyon
            //ulong  64bit   0 ile 18 katrilyon

            //bir tipin maksimum değerini görmek için aşağıdaki komutu kullanabilirsiniz.
            Console.WriteLine(byte.MinValue);
            Console.WriteLine(byte.MaxValue);

            byte sayiByte = 255; //byte tipinde bulunan değişkenin içerisine 255 değerini tanımladık.
            int sayiInt = sayiByte;//byte tipini int tip'e atadık.
            sayiInt = sayiInt + 1;//int tipte barınan değişkenin (255) değerini 1 kez artırdık. 

            Console.WriteLine(sayiInt);

            Console.Read();

            //2-Ondalıklı Sayısal Tipler
            /*
                1- float    32bit   ., sonra 7 hane desteği verir.
                2- double   64bit   ., sonra 14 hane desteği verir.
                3- decimal  128bit  ., sonra 28 hane desteği verir.


             */

            float sayiFloat = 1.5f;
            double sayiDouble = 1.5;
            decimal sayiDecimal = 1.5m;


            //Metinsel Tipler
            //1-char    tek bir karakter barındırır.
            //2-string  sınırsız metin tutar.

            char karakter = 'a';
            string metin = "buraya dilediğiniz kadar metin yazabilirsiniz";

            //Mantıksal
            //1-Boolean (bool) => içerisinde 0 (false) ve 1 (true) değerini tutar

            bool sart = true;



            //CTRL+K+S tuş kombinasyonu ile region bloğunu oluşturabilirsiniz. 

            //CTRL+K+D tuş kombinasyonu ile kod satırını derleyebilirsiniz.

            #region Genel Tanıma
            //CTRL+Shift+Space tuş kombinasyonu ile tooltip'i görüntüleyebilirsiniz.


            //Write()
            //WriteLine()

            //Read()
            //ReadLine()
            //ReadKey()


            //Eğer herhangi bir satırı yorum alanı olarak belirlememek isterseniz CTRL+K+C tuş kombinasyonunu kullanabilirsiniz. Geri almak için ise CTRL+K+U tuş kombinasyonunu kullanabilirsiniz.

            //Console.WriteLine("Hello World!");
            //Console.ReadLine();
            //Console.Read(); 
            #endregion





        }//scope bitiş
    }
}//scope bitiş


