using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_StaticSample
{
    class Program
    {
        static void Main(string[] args)
        {

            //Personel isminde bir class tanımlayın. bi kaç adet personel oluşturun. console writeline ile kaç adet personel oluşturulduğunu gösterin.

            Personel p1 = new Personel();

            Personel p2 = new Personel();

            Personel p3 = new Personel();

            Console.WriteLine(Personel.KisiSayisi.ToString());
        }
    }
}
