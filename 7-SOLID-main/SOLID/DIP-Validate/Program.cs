using DIP_Validate.Abstract;
using DIP_Validate.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            Beef antrikot = new Beef();
            Fish hamsi = new Fish();

            List<IFood> yemekListesi = new List<IFood>();
            yemekListesi.Add(antrikot);
            yemekListesi.Add(hamsi);

            Restaurant restaurant = new Restaurant(yemekListesi);
           string yemekIslemi= restaurant.GenerateInstructions();

            Console.WriteLine(yemekIslemi);
        }
    }
}
