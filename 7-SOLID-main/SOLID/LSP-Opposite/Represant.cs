using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Opposite
{
    public class Represant:Employee
    {
        public override void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 13;
            Salary = baseAmount + (rank * 2);
        }

        public override void AssingManager(Employee employee)
        {
            Manager = employee;
        }
    }
}
