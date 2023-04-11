using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Collections.Problem10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number of stalls");
            int count = Convert.ToInt32(Console.ReadLine());
            
            for(int i=0;i< count;i++)
            {
                string s = Console.ReadLine();
                string[] detail = s.Split(",");
                string name = detail[0];
                string owner = detail[1];
                string add = detail[2];
                Stall m = new Stall(name, owner, add);
                Stall.ints.Add(m);
            }
            Console.WriteLine("Updated Stall List");
            for (int i = 0; i < Stall.ints.Count; i++)
            {
                Stall stall = Stall.ints[i];

                // Check if the name of the stall starts with "test"
                if (stall.Name.ToLower().StartsWith("test"))
                {
                    // Remove the stall from the list
                    Stall.ints.RemoveAt(i);

                    // Decrement the counter to avoid skipping an item in the list
                    i--;
                }
                else
                {
                    // Print the stall details
                    Console.WriteLine(stall);
                }
            }


        }
    }
}
