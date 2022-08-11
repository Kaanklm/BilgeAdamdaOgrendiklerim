using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Opposite
{
    public class Represant : Employee, ICreate
    {
        public void AddEmployee(Employee employee)
        {
            throw new InvalidOperationException("Temsilci çalışan ekleyemez!");
        }

        public void AssignManager(Employee employee, int managerId)
        {
            throw new InvalidOperationException("Temsilci yetki veremez");
        }

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
