using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton
    {

        //Constructor private yaparak bu sınıf dışından instance alınmasını engelliyoruz.
        private Singleton()
        {

        }
        
        //alınan instance sadece bu class içerisinden ulaşılması için private tanımlıyoruz.
        private static Singleton _nesne = new Singleton();

        //oluşturulan static nesnenin dışarıdan erişilmesini sağlamak için instance alıyoruz.
        public static Singleton Nesne
        {
            get
            {
                return _nesne;
            }
        }


        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
    }
}
