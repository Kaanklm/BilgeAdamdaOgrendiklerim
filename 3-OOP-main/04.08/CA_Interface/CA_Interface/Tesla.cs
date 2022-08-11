using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Interface
{
    public class Tesla : Araba,IYetenek
    {
       

        public override string MaxHız()
        {
            return "180km/h";
        }

        public string OtoPilot()
        {
            return Marka + " " + Model + " kendi kendini sürebilir";
        }
    }
}
