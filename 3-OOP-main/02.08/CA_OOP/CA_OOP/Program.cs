using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             1-Encapsulation
             2-Inheritance
             3-Polymorphism
             4-Abstraction
             */

            //Insan insan = new Insan();
            //insan.Ad = "Fatih";
            //insan.Soyad = "Günalp";

            //listbox1.items.add(insan);
            //CA_OOp.Insan

            Insan insan = new Insan();
            insan.Ad = "Fatih";
            insan.Soyad = "Günalp";

            Insan insan2 = new Insan("İrem", "Pınar");

            //object initilizer

            Insan insan3 = new Insan()
            {
                Ad = "Gökçen",
                Soyad = "Akça"
            };



        }
    }
}
