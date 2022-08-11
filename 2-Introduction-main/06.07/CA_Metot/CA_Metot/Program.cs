using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Metot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. sayıyı girin");
            int sayiBir = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2. sayıyı girin");
            int sayiIki = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Topla(sayiBir, sayiIki));
            Console.Read();
        }

        static string Topla(int s1, int s2)
        {
            int toplam = s1 + s2;
            return toplam.ToString();
        }
    }
}
