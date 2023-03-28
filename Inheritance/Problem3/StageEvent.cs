using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem3
{
    internal class StageEvent:Event
    {
        private static int _gst = 15;
        private int _noOfSeats;
        private double TotalCost;

        public StageEvent() { }

        public StageEvent(string name, string type, double costPerDay, int noOfDays, int noOfSeats) : base(name, type, costPerDay, noOfDays)
        {
            _noOfSeats = noOfSeats;

        }

        public override string ToString()
        {
            TotalCost += (_costPerDay * _noOfDays) + (_costPerDay * _noOfDays * 0.15);
            return "Name:" + _name + "\n" + "Type:" + _type + "\n" + "Number of seats:" + _noOfSeats + "\n" + "Total amount:" + String.Format("{0:0.00}", TotalCost);

        }

    }
}
