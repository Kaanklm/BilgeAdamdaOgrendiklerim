using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Opposite
{
    public class GenerateAccount
    {
        public Employee AddEmployee(User user)
        {
            Employee employee = new Employee();
            employee.FirstName = user.FirstName;
            employee.LastName = user.LastName;
            employee.Email = user.FirstName.Substring(0, 1) + user.LastName.ToLower() + "@bilgeadam.com";

            switch (user.Title)
            {
                case EmployeeTitle.Manager:
                    employee.IsManager = true;
                    break;
                case EmployeeTitle.Represant:
                    employee.IsRepresant = true;
                    break;
                case EmployeeTitle.Coordinator:
                    employee.IsCoordinator = true;
                    break;
            }
            return employee;
        }
    }
}


//Fatih
//Gunalp

//fgunalp@gmail.com