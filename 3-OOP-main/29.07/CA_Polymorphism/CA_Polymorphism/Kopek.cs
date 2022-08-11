using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    public class Kopek:Hayvan
    {
        public bool SadikMi { get; set; }
        public override string SesCikar()
        {
            return "hav hav";
        }
    }
}
