using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Interface
{
    public interface IEmployee
    {
       string FirstName { get; set; }
       string LastName { get; set; }
       decimal Salary { get; set; }

        void CalculatePerHourPrice(int rank);
    }
}
