using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem5
{
    internal class Hall
    {
        public string _hallName;
        public double _costPerDay;
        public DateTime _bookingDate;
        public string _ownerName;

        //fill code here

        public void Hall1(string hallname,  double costPerDay, DateTime bookingDate, string ownername)
        {
            _hallName = hallname;
            _costPerDay = costPerDay;
            _bookingDate = bookingDate;
            _ownerName = ownername;
        }
       
        public static Hall CreateHall(string hallDetail)
        {
            //fill code here
            string[] word = hallDetail.Split(",");

            string hallname = word[0];
            double costperday = Convert.ToDouble(word[1]);
            DateTime bookingdate = Convert.ToDateTime(word[2]);
            string ownername = word[3];
            Hall hall = new Hall();
            hall.Hall1(hallname, costperday, bookingdate, ownername);
            return hall;
        }

       /* public List<Hall> FilterHall(List<Hall> hallList, Predicate<double> predicate)
        {
            //fill code here
        }*/

        public void DisplayHallDetails(List<Hall> hallList)
        {
            //fill code here
            Console.WriteLine("{0} {1,15} {2,15} {3,15}", "Hall name", "Cost per day", "Booking date", "Owner name");
            foreach (Hall hall in hallList)
            {
                Console.WriteLine(hall._hallName+" "+hall._costPerDay+" "+hall._bookingDate+" "+hall._ownerName);
            }
            //fill code here
        }
    }
}
