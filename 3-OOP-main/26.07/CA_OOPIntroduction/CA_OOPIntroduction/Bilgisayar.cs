using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_OOPIntroduction
{
    //Access Modifiers (erişim belirteçleri)

    /*
     *  --private:
        --public: 
        --internal:
     */
   class Bilgisayar //bir classın başına erişim belirteci yazılmazsa varsayılan; internal'dır.
    {
        //Bir nesne oluşturulurken o nesnenin ne gibi özelliklerinin olacağını belirlememiz gerekmektedir. Bu anlamda kendimize şu soruyu sormamız gerekmektedir;

        //Bir bilgisayarın .....'sı olur.


        /*
Ekran(Monitör)
Anakart
İşlemci
Bellek (RAM)
Genişletme Kartı(Ekran Kartı vb. için)
Güç Kaynağı
Sabit Disk
Klavye
Fare

         */

        //bir class içerisinde tanımlanan değişkenlere "field" denir.

       public string monitor;
       public string anakart;
       public int islemciCekirdekSayisi;
       public int bellekKapasite;
       public int ekranKartiKapasite;
       public int gucKaynagi;
       public char klavyeTipi;
       public string fareMarkasi;



    }
}
