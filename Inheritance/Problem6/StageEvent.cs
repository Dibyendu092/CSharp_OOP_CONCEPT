using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem6
{
    internal class StageEvent:Event
    {
        protected int _noOfShows;
        protected int _noOfSeats;

        public StageEvent(string name, string type, int noOfShows, int noOfSeats):base(name, type)
        {
            _noOfShows = noOfShows;
            _noOfSeats = noOfSeats;
        }

        public double ProjectedRevenue()
        {
            double d = base.ProjectedRevenue();
            return d+= _noOfSeats*_noOfShows*50;
        }
    }
}
