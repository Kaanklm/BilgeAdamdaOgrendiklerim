using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    public class Kedi:Hayvan
    {
        public bool Umursar { get; set; }


        //override => ezme anlamını taşır.
        public override string SesCikar()
        {
            return "miyavvv";
        }
    }
}
