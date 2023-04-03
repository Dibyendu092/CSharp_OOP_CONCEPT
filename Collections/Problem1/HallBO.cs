using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem1
{
    internal class HallBO
    {
        public Hall CreateHall(string hallDetails)
        {
            //fill code here
            string[] word = hallDetails.Split(",");
            string name1 = word[0];
            string contactno = word[1];
            double costperday = Convert.ToDouble(word[2]);
            string ownerName1 = word[3];
            Hall hall = new Hall(name1, contactno, costperday, ownerName1);
            return hall;
            
        }
       public bool RemoveHallFromList(List<Hall> hallList, int index)
        {
            //fill code here
            if (hallList.Count != 0)
            {
                hallList.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public void DisplayHalls(List<Hall> hallList)
        {
            Console.WriteLine("{0}{1,15}{2,15}{3,15}", "Name", "Contact Number", "Cost per day", "Owner Name");
            foreach (Hall hall in hallList)
            {
                Console.WriteLine(hall.name + " " + hall.contactNumber + " " + hall.costPerDay + " " + hall.ownerName);
            }
            //fill code here
        }
    }
}
