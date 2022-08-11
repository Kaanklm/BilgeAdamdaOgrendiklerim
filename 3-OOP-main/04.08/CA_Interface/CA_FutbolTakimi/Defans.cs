using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi
{
    public class Defans : Futbolcu, IFutbolcu
    {
        public override int SutGucu { get ; set; }

        public string CalimAt()
        {
            return Ad + " çalım attı";
        }

        public string Kos()
        {
            return Ad + " koşuyor";
        }

        public string PressYap()
        {
            return Ad + " press yapıyor";
        }

        public string SutCek()
        {
            return Ad + " Şut çekti";
        }

        public string TopKurtar()
        {
            return Ad + " Top kurtardı";
        }
    }
}
