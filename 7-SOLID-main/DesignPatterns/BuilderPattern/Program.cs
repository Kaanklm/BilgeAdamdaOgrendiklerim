using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            KrediKartBuilder gercekKart = new MasterKartBuilder();
            KrediKartiKullan kullan = new KrediKartiKullan();
            kullan.KartKullan(gercekKart);

            Console.WriteLine(gercekKart.Kart.ToString());
            Console.Read();
        }
    }
}
