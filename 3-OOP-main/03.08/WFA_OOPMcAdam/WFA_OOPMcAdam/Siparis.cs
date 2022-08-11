using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_OOPMcAdam
{
    public class Siparis
    {
        public Siparis()
        {
            SiparisTarihi = DateTime.Now;
        }

        //bir siparişin .... 'sı olur.
        public DateTime SiparisTarihi { get; set; }
        public Ebat Ebat { get; set; }
        public HamburgerMenu SeciliMenu { get; set; }
        public List<Ekstra> Ekstralar { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        //TutarHesapla
        public void TutarHesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyat;

            switch (Ebat)
            {
                case Ebat.Küçük:

                    break;
                case Ebat.Orta:
                    ToplamTutar += 5;
                    break;
                case Ebat.Büyük:
                    ToplamTutar += 10;
                    break;
            }

            foreach (Ekstra ekstra in Ekstralar)
            {
                ToplamTutar += ekstra.Fiyat;
            }

            ToplamTutar = Adet * ToplamTutar;
        }

        public override string ToString()
        {
            //string formatOld = string.Format("Menu: {0} Adet: {1}", SeciliMenu.MenuAd, Adet);

            //string format = $"Menu : {SeciliMenu.MenuAd} Adet: {Adet}";

            if (Ekstralar.Count < 1)
            {
                return $"Menu: {SeciliMenu.MenuAd} Ebat: {Ebat} Adet: {Adet} Toplam: {ToplamTutar.ToString()}";
            }
            else
            {
                string ekstraMalzeme = "";
                foreach (Ekstra ekstra in Ekstralar)
                {
                    ekstraMalzeme += ekstra.EkstraAd + " ";
                    ekstraMalzeme += ekstra.Fiyat + " ";

                }
                return $"Menu: {SeciliMenu.MenuAd} Ebat: {Ebat} Ekstralar:({ekstraMalzeme}) Adet: {Adet} Toplam: {ToplamTutar.ToString()}";
            }
        }
    }
}
