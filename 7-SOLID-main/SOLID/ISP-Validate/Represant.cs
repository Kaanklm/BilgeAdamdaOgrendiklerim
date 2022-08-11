using ISP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Validate
{
    public class Represant : Employee, IReport
    {
        public void GeneratePerformanceReport(Employee sender)
        {
            SendEmail(sender.Email);
        }

        public void SendEmail(string email)
        {
            Console.WriteLine(email + " adresine mail gönderildi!");
        }
    }
}
