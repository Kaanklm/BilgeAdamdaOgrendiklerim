using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Opposite
{
    public class Manager:Employee
    {
        public override void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 19;
            Salary = baseAmount + (rank * 4);
        }

        public override void AssingManager(Employee employee)
        {
            Manager = employee;
        }

    }
}
