using ISP_Opposite.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Opposite
{
    public class Ceo : Employee, ICreate
    {
        public void AddEmployee(Employee employee)
        {
            EmployeeData.employees.Add(employee);
        }

        public void AssignManager(Employee employee, int managerId)//Ali,2
        {
            var manager = EmployeeData.employees.Find(x=>x.Id==managerId);
            employee.Manager = manager;
           //güncelleme yapılacak.


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
