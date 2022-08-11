using LSP_Validate.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Model
{
    public class Manager : Employee, IManaged
    {
        public void GeneratePerformanceReport()
        {
            Console.WriteLine($"{FirstName} tarafından performans raporu oluşturulduç.");
        }
    }
}
