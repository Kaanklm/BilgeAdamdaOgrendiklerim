using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFA_UrunYonetimi
{
    public interface IUrun
    {
        string Kaydet(Urun urun);
        List<Urun> Listele();
        string Sil(Urun urun);
    }
}
