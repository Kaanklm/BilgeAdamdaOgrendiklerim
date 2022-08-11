using OCP_Validate.Abstract;
using OCP_Validate.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Generate
{
    public class RepresantAccount:IAccount
    {
        public Employee Create(IEntity account)
        {
            Employee employee = new Employee();
            employee.FirstName = account.FirstName;
            employee.LastName = account.LastName;
            employee.Email = account.FirstName.Substring(0, 1).ToLower() + account.LastName.ToLower() + "@bilgeadam.com";
            employee.IsRepresant = true;
            return employee;
        }
    }
}
