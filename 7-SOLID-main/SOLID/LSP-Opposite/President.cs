using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Opposite
{
    public class President:Employee
    {
        public override void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 50;
            Salary = baseAmount * rank;
        }

        public override void AssingManager(Employee employee)
        {
            throw new InvalidOperationException("Başkan'ın yönetici olamaz!'");
        }
    }
}
