using SRP_Validate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class EmployeeData
    {
        public static Employee AddEmployee()
        {
            Employee employee = new Employee();
            Console.WriteLine("Lütfen çalışan adı giriniz...");
            employee.FirstName = Console.ReadLine();

            Console.WriteLine("Lütfen çalışan soyadını giriniz...");
            employee.LastName = Console.ReadLine();

            return employee;
        }
    }
}
