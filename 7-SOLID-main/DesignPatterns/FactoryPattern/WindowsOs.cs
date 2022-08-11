using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WindowsOs : MobileApplication
    {
        public override void Platform()
        {
            Console.WriteLine("bu uygulama windows için çalışmaktadır");
        }
    }
}
