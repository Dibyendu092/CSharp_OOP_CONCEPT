using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Module.Problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select your choice...\n1. Make My Trip\n2. Trivago\n3. Clear Trip");
            int ch = Convert.ToInt32(Console.ReadLine());
            string city;
            switch (ch)
            {
                case 1:
                    //Fill your code here
                    Console.WriteLine("Available Cities:");
                    MakeMyTrip makeMyTrip = new MakeMyTrip();
                    makeMyTrip.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    city = Console.ReadLine();
                    makeMyTrip.ShowTariff(city);
                    break;
                case 2:
                    //Fill your code here
                    Console.WriteLine("Available Cities:");
                    Trivago trivago = new Trivago();
                    trivago.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    city = Console.ReadLine();
                    trivago.ShowTariff(city);
                    break;
                case 3:
                    //Fill your code here
                    Console.WriteLine("Available Cities:");
                    ClearTrip clearTrip = new ClearTrip();
                    clearTrip.CityList();
                    Console.WriteLine("Enter a city to view hotels:");
                    city = Console.ReadLine();
                    clearTrip.ShowTariff(city);
                    break;
            }
        }
    }
}
