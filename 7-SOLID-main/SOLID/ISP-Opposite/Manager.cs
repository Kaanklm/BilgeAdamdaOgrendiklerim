using ISP_Opposite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Opposite
{
    public class Manager : Employee, ICreate
    {
        public void AddEmployee(Employee employee)
        {
            EmployeeData.employees.Add(employee);
        }

        public void AssignManager(Employee employee, int managerId)
        {
            throw new InvalidOperationException("Müdür yetki veremez");
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
