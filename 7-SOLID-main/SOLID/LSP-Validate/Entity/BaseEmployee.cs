using LSP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Entity
{
    public class BaseEmployee : IEmployee
    {
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public decimal Salary { get; set; }

        public virtual void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 10;
            Salary = baseAmount + (rank * 2);
        }
    }
}
