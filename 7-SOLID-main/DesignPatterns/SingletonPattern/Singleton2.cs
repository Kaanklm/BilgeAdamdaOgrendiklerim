using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class Singleton2
    {
        private Singleton2()
        {

        }

        private static Singleton2 _sinif;//null


        public static Singleton2 Sinif
        {
            get
            {
                if (_sinif == null)
                    _sinif = new Singleton2();
                return _sinif;
            }
        }

        public string Message()
        {
            return "İnstance alındı";
        }



    }
}
