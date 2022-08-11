using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Opposite
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public bool IsManager { get; set; }
        public bool IsRepresant { get; set; }
        public bool IsCoordinator { get; set; }
    }
}
