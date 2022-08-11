using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //Singleton s = new Singleton();

            //Singleton s = Singleton.Nesne;

            //string toplam = s.Topla(3, 5).ToString();

            //Console.WriteLine(toplam);
            //Console.Read();

            Singleton2 s = Singleton2.Sinif;
            Console.WriteLine(s.Message());
        }
    }
}
