using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_FutbolTakimi
{
    public class Kaleci:Futbolcu,IFutbolcu
    {
        private int _sutGucu;
        public override int SutGucu {
            get
            {
                return _sutGucu;
            }
            set
            {
                if (value > 70)
                {
                    Console.WriteLine("Şu gücü 70'den büyük olduğu için isabet oranı düşer");
                }
            }
        }

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
            throw new NotImplementedException();
        }

        public string TopKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
