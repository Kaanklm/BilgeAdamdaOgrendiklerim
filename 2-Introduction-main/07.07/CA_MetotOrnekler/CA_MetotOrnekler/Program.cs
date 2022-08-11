using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_MetotOrnekler
{
    class Program
    {
        static void Main(string[] args)
        {
            SayilariTopla();
            SayilariTopla(8, 2);

            int toplam = ToplaveDon();//10

            int toplam2 = ToplaveDon(5, 5);//10


            Console.Read();
        }

        /// <summary>
        /// içindeki değerleri toplar
        /// </summary>
        static void SayilariTopla()
        {
            int a = 5;
            int b = 5;
            int toplam = a + b;
            Console.WriteLine(toplam.ToString());
        } 

        /// <summary>
        /// parametre olarak gönderilen iki sayıyı toplar
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void SayilariTopla(int a, int b)
        {
            int toplam = a + b;
            Console.WriteLine(toplam.ToString());
        }

        /// <summary>
        /// içinde bulunan iki adet sayıyı toplar ve int toplam döner.
        /// </summary>
        /// <returns></returns>
        static int ToplaveDon()
        {
            int a = 5;
            int b = 5;
            int toplam = a + b;

            return toplam;
        }


        /// <summary>
        /// parametre olarak gönderilen iki adet sayıyı toplar ve geriye int bir tip döner
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int ToplaveDon(int a, int b)
        {
            int toplam = a + b;
            return toplam;
        }
    }
}
