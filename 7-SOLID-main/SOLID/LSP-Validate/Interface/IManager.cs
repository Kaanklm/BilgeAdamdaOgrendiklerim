using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP_Validate.Interface
{
    public interface IManager:IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee employee);
    }
}
