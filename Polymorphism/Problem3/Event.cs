using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Problem3
{
    internal class Event
    {
        protected string _name;
        protected string _detail;
        protected string _organizer;

        public Event() { }
        public Event(string name, string detail, string organizer)
        {
            _name = name;
            _detail = detail;
            _organizer = organizer;
        }

        public virtual void TotalCredit()
        {
            Console.WriteLine("Event Name: " + _name);
            Console.WriteLine("Event Detail: " + _detail);


        }
    }
}
