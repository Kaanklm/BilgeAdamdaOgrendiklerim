using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class IpAddresses
    {
        public static string GetHostName()
        {
            string ip = string.Empty;

           var localAddresses= Dns.GetHostAddresses(Dns.GetHostName());
            foreach (var item in localAddresses)
            {
                if (item.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    ip = item.ToString();
                }
            }



            return ip;
        }
    }
}
