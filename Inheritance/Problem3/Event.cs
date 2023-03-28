using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem3
{
    internal class Event
    {
        protected string _name;
        protected string _type;
        protected double _costPerDay;
        protected int _noOfDays;

        public Event() { }
        public Event(string name, string type, double costPerDay, int noOfDays)
        {
            _name = name;
            _type = type;
            _costPerDay = costPerDay;
            _noOfDays = noOfDays;
        }
    }
}
