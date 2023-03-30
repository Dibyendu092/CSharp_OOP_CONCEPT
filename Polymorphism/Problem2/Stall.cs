using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Problem2
{
    internal class Stall
    {
        public void ComputeCost(string stallType, int squareFeet)
        {
            Console.WriteLine("Gold costs Rs." + squareFeet * 100);
        }
        public void ComputeCost(string stallType, int squareFeet, int numberOfTV)
        {
            Console.WriteLine("Diamond costs Rs." + ((squareFeet * 150) + (numberOfTV * 100)));
        }
        public void ComputeCost(string stallType, int squareFeet, bool projectorAvailability)
        {
            if(projectorAvailability == true) {
                Console.WriteLine("Platinum costs Rs." + ((squareFeet * 200) + 1000));
            }
            else
            {
                Console.WriteLine("Platinum costs Rs." + squareFeet*200);
            }
        }


    }
}
