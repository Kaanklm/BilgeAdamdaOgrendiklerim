using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Static
{
    class Program
    {
        static void Main(string[] args)
        {
            //Static 
            /*
             * Static olarak işaretlenen bir class veya içerisinde bulunan elamanı proje çalıştırıldığında doğrudan ram bellek üzerine çıkartılmasını sağlar.
             */

            //Matematik matematik = new Matematik();
            //matematik.VarsayilanSayi

           decimal gelenSayi= Matematik.PiSayisi;

            Matematik.VarsayilanSayi = 10;

            Console.WriteLine(Notification.Info());
            Console.WriteLine(Notification.Success());
            Console.WriteLine(Notification.Error());



        }
    }
}
