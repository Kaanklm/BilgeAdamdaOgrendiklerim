using LSP_Validate.Entity;
using LSP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Model
{
    public class President : BaseEmployee, IManaged

    {
        public void GeneratePerformanceReport()
        {
            Console.WriteLine($"{FirstName} tarafından performans raporu oluşturulduç.");
        }

        public override void CalculatePerHourPrice(int rank)
        {
            decimal baseAmount = 50;
            Salary = baseAmount * rank;
        }

    }
}
