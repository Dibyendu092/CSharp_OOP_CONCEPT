using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem3
{
    internal class Exhibition : Event
    {
        private static int _gst;
        private int _noOfStalls;
        private double TotalCost;

        public Exhibition() { }
        public Exhibition(string name, string type, double costPerDay, int noOfDays, int noOfStalls) : base(name, type, costPerDay, noOfDays)
        {
            _name = name;
            _noOfStalls = noOfStalls;
        }


        public override string ToString()
        {


            TotalCost += (_costPerDay * _noOfDays) + (_costPerDay * _noOfDays * 0.05);
            return "Name:" + _name + "\n" + "Type:" + _type + "\n" + "Number of stalls:" + _noOfStalls + "\n" + "Total amount:" + String.Format("{0:0.00}", TotalCost);

        }
    }
}
