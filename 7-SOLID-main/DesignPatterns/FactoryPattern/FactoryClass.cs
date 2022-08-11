using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FactoryClass
    {
        public MobileApplication FactoryMethod(AllMobileOs osType)
        {
            MobileApplication ma = null;

            switch (osType)
            {
                case AllMobileOs.AndroidOs:
                    ma = new AndroidOS();
                    break;
                case AllMobileOs.IphoneOs:
                    ma = new IphoneOS();
                    break;
                case AllMobileOs.WindowsOs:
                    ma = new WindowsOs();
                    break;
            }
            return ma;


        }
    }
}
