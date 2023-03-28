using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem6
{
    internal class Event
    {
        private string _name;
        private string _type;

        public Event(string name, string type)
        {
            _name = name;
            _type = type;
        }
        public virtual double ProjectedRevenue()
        {
            return 0.0;
        }
    }
}
