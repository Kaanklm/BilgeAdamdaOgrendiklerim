using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP_Opposite
{
    public class Restaurant
    {

        public Fish hamsi = new Fish();
        public Beef antrikot = new Beef();

        public string GenerateInstructions()
        {
            return hamsi.GetFishCooking() + " " + antrikot.GetBeefCooking();
        }
    }
}
