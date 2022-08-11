using SRP_Validate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    public class EmployeeValidator
    {
        public static bool Validate(Employee employee)
        {
            if (string.IsNullOrEmpty(employee.FirstName))
            {
                Message.ErrorMessage("Çalışan adı");
                Console.ReadLine();
                return false;
            }

            if (string.IsNullOrEmpty(employee.LastName))
            {
                Message.ErrorMessage("Çalışan soyadı");
                Console.ReadLine();
                return false;
            }

            return true;

        }
    }
}
