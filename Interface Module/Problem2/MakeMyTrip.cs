using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Module.Problem2
{
    internal class MakeMyTrip:HotelTariff
    {
        Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Tokyo",
        new Dictionary<string,double>
        {
            {"Tokyo Residency",10000},
            {"Heritage Tokyo",15000},
            {"Germanus",20000}
        }
        },

        {
        "Singapore",
        new Dictionary<string,double>
        {
            {"Hotel CAG Pride",15000},
            {"Heritage Inn",25000}
        }
        }
    };
        public void CityList()
        {
            //Fill your code here
            foreach (var kvp in HotelList)
            {
                Console.WriteLine(kvp.Key);
            }
        }

        public void ShowTariff(string city)
        {
            //Fill your code here
            if (HotelList.ContainsKey(city))
            {
                Console.WriteLine("Hotel List with Tariff:");
                foreach (var kvp in HotelList[city])
                {
                    Console.WriteLine(kvp.Key + " - Rs." + kvp.Value);
                }
            }
            else { Console.WriteLine("Selected City not found..."); }
        }
    }
}
