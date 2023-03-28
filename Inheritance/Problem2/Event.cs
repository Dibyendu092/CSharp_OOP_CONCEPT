using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem2
{
    internal class Event
    {
        protected string _name;
        protected DateTime _date;
        protected string _type;
        protected string _organizer;

        public Event() { }
        public Event(string name, DateTime date, string type, string organizer)
        {
            _name = name;
            _date = date;
            _type = type;
            _organizer = organizer;
        }
    }
}
