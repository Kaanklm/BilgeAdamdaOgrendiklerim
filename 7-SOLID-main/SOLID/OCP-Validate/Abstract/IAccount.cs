using OCP_Validate.Accounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCP_Validate.Abstract
{
    public interface IAccount
    {
        Employee Create(IEntity account);
    }
}
