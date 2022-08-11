using OCP_Validate.Abstract;
using OCP_Validate.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Accounts
{
    public class Employee : IEntity
    {
        public Employee()
        {
            GenerateAccount = new Account();
        }
       
        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }

        public string Email { get; set; }

        public bool IsManager { get; set; }
        public bool IsRepresant { get; set; }
        public bool IsCoordinator { get; set; }

        public IAccount GenerateAccount { get; set; }
    }
}
