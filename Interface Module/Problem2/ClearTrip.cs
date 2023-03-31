using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Module.Problem2
{
    internal class ClearTrip:HotelTariff
    {
        Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Chennai",
        new Dictionary<string,double>
        {
            {"Leela Palace",25000},
            {"Hilton",20000},
            {"WoodLands",18000}
        }
        },

        {
        "Bangalore",
        new Dictionary<string,double>
        {
            {"Adarsh Hamilton",12000},
            {"Wonderla Resort",15000},
            {"Olde Bangalore Resort",20000}
        }
        }
    };
        //Fill your code here

        public void CityList()
        {
            //Fill your code here
            foreach (var kvp in HotelList)
            {
                Console.WriteLine( kvp.Key);
            }
        }

        public void ShowTariff(string city)
        {
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
