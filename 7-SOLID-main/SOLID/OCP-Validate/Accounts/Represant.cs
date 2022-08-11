using OCP_Validate.Abstract;
using OCP_Validate.Generate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Accounts
{
    public class Represant : IEntity
    {
        public Represant()
        {
            GenerateAccount = new RepresantAccount();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IAccount GenerateAccount { get; set; }
    }
}
