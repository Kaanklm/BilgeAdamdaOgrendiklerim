using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Polymorphism
{
    public class Hayvan//Base
    {
        //Property
        public virtual  string Cinsi { get; set; }
        public int Yas { get; set; }
        public string Renk { get; set; }

        //public string SesCikar()
        //{
        //    return "hayvan sesi";
        //}

        //Polymorhism
        //virtual=> ezilebilir anlamını taşımaktadır. Amacı miras verilen class içerisinde virtual olarak tanımlanan yapının farklı etkiler oluşturmasını sağlamak.

        /*
         İsteğe bağlı ezme işlemi olarak da adlandırılır.
        class içerisinde bulunan propertyler veya metotlar virtual olarak tanımlanabilir.
         */
        public virtual string SesCikar()
        {
            return "hayvan sesi";
        }
    }
}
