using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem2
{
    internal class StageEvent:Event
    {
        private string _showType;

        public StageEvent() { }
        public StageEvent(string name, DateTime date, string type, string organizer,string showType):base(name, date, type, organizer)
        {
            _showType = showType;
        }
        public void Display()
        {
            Console.WriteLine("Event Name:" + _name);
            Console.WriteLine("Event Date: " + _date.ToString("dd/MM/yyyy"));
            Console.WriteLine("Event Organizer:" + _organizer);
            Console.WriteLine("Event Type:" + _type);
            Console.WriteLine("Show Type: " + _showType);
        }
    }
}
