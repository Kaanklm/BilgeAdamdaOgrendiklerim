using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP_Opposite
{
    public interface ICreate
    {
        void AddEmployee(Employee employee);
        void SendEmail(string email);
        void AssignManager(Employee employee, int managerId);
        void GeneratePerformanceReport(Employee sender);
    }
}
