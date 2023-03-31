using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Module.Problem2
{
    internal class Trivago:HotelTariff
    {
        Dictionary<string, Dictionary<string, double>> HotelList = new Dictionary<string, Dictionary<string, double>>
    {
        {
        "Hyderabad",
        new Dictionary<string,double>
        {
            {"Park Hyatt",12000},
            {"Courtyard By Marriott",10000},
            {"Taj Krishna",14500}
        }
        },

        {
        "Mysore",
        new Dictionary<string,double>
        {
            {"Hotel Royal Orchid",20000},
            {"Hotel Kings Kourt",18000}
        }
        }
    };
        //Fill your code here
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
           if(HotelList.ContainsKey(city))
           {
                Console.WriteLine("Hotel List with Tariff:");
                foreach(var kvp in HotelList[city]) {
                    Console.WriteLine(kvp.Key + " - Rs." + kvp.Value);
                }
           }
            else { Console.WriteLine("Selected City not found..."); }
        }
    }
}
