using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    public class Kus:Hayvan
    {
        public bool Memeli { get; set; }
        public override string SesCikar()
        {
            return "cik cik cik";
        }
    }
}
