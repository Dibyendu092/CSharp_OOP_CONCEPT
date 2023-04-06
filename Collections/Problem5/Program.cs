using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections.Problem5
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            List<Hall> hallList = new List<Hall>();
            Console.WriteLine("Enter total number of halls");
            int ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Hall Details");
            for (int i=0;i< ch;i++)
            {
                
                string k = Console.ReadLine();
                string[] detail = k.Split(",");
                string name = detail[0];
                long mobileno = Convert.ToInt64(detail[1]);
                string ownername = detail[2];
                double costperday = Convert.ToDouble(detail[3]);
                Hall hall = new Hall(name, mobileno,ownername,costperday);
                hallList.Add(hall);

            }
            hallList.Sort();
            //Fill your code here
            Console.WriteLine(string.Format("{0,-20} {1,-15} {2,-15} {3,-10}","Hall Name", "MobileNumber", "OwnerName", "CostPerDay"));
            foreach (Hall hall in hallList)
            {
                Console.WriteLine(hall.ToString());
            }

        }*/
    }
}
