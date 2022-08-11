using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Opposite
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Employee Manager { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 12;
            Salary = baseAmount + (rank * 2);
        }

        public virtual void AssingManager(Employee employee)
        {
            Manager = employee;
        }

    }
}
