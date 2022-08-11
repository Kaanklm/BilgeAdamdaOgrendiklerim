using LSP_Validate.Entity;
using LSP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Model
{
    public class Employee : BaseEmployee, IManager
    {
        public IEmployee Manager { get ; set ; }

        public void AssignManager(IEmployee employee)
        {
            Manager = employee;
        }

        public override  void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 12;
            Salary = baseAmount + (rank * 2);
        }

    }
}
