using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of halls:");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Hall> hallList = new List<Hall>();

            for(int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                hallList.Add(Hall.CreateHall(s));
            }

            //fill code here

            /*Console.WriteLine("Enter the minimum price to filter:");
            double min = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the maximum price to filter:");
            double max = Convert.ToDouble(Console.ReadLine());*/
            Hall hall1 = new Hall();
            hall1.DisplayHallDetails(hallList);
        }
    }
}
