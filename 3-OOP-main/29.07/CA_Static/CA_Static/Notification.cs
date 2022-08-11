using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA_Static
{
    public class Notification
    {

        public static string Success()
        {
            return "Başarılı";
        }

        public static string Error()
        {
            return "Hatalı";
        }

        public static string Info()
        {
            return "Bilgilendirme";
        }
    }
}
