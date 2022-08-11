using SRP_Validate.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP_Validate
{
    class Program
    {
        static void Main(string[] args)
        {
            Message.Greeting();

            Employee newEmployee = EmployeeData.AddEmployee();

            bool isValid = EmployeeValidator.Validate(newEmployee);

            if (isValid == false)
            {
                Console.ReadLine();
                return;
            }

            EmployeeGenerator.Create(newEmployee);
            Console.Read();
        }
    }
}
