using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public class Data:IUrun
    {
        public static List<Urun> urunListesi = new List<Urun>()
        {
            new Kitap{Id=1,Ad="1984",Fiyat=20},
            new Telefon{Id=2,Ad="IPhone",Fiyat=10000}
        };

        public string Kaydet(Urun urun)
        {
            urunListesi.Add(urun);
            return urun.Ad + " kaydedildi!";
        }

        public List<Urun> Listele()
        {
            return urunListesi;
        }

        public string Sil(Urun urun)
        {
            urunListesi.Remove(urun);
            return "ürün silindi";
        }
    }
}
