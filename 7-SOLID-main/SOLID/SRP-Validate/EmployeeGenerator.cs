using SRP_Validate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class EmployeeGenerator
    {
        public static void Create(Employee employee)
        {
            Console.WriteLine("Ad :" + employee.FirstName + " Soyad: " + employee.LastName);
        }




    }
}
