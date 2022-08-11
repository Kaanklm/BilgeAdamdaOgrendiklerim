using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryClass factory = new FactoryClass();

            MobileApplication mobileAnroid = factory.FactoryMethod(AllMobileOs.AndroidOs);

            MobileApplication mobileIphone = factory.FactoryMethod(AllMobileOs.IphoneOs);

            MobileApplication mobileWindows = factory.FactoryMethod(AllMobileOs.WindowsOs);


            mobileAnroid.Platform();
            mobileIphone.Platform();
            mobileWindows.Platform();

            Console.Read();

        }
    }
}
