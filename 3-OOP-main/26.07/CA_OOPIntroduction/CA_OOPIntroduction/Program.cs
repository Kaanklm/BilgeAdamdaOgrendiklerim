using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            Bilgisayar pc = new Bilgisayar();
            pc.anakart = "Msi";
            pc.bellekKapasite = 16;
            pc.fareMarkasi = "Logitech";
            pc.gucKaynagi = 1000;
            pc.monitor = "Asus";

            Console.WriteLine(pc.monitor);
            Console.Read();
        }
    }
}
