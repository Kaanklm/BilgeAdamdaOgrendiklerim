using DIP_Validate.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Validate
{
    public class Restaurant
    {
        private List<IFood> _foods;
        public Restaurant(List<IFood> foods)
        {
            _foods = foods;
        }

        public string GenerateInstructions()
        {
            string instructions = string.Empty;
            foreach (var food in _foods)
            {
                instructions += food.GetCookingInstructions();
            }
            return instructions;
        }
    }
}
