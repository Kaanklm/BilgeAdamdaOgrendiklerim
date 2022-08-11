using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOPMcAdam
{
    public class HamburgerMenu
    {
        public string MenuAd { get; set; }
        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return MenuAd + " " + Fiyat;
        }
    }
}
