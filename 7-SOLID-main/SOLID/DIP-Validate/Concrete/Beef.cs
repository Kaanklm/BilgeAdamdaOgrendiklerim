using DIP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate.Concrete
{
    public class Beef : IFood
    {
        public string GetCookingInstructions()
        {
            return "Et böyle pişirilir";
        }
    }
}
