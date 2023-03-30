using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Problem3
{
    internal class Exhibition:Event
    {
        private int _stallCount;
        public Exhibition() { }
        public Exhibition(string name, string detail, string organizer, int stallCount) : base(name, detail, organizer)
        {
            _stallCount = stallCount;
        }

        public override void TotalCredit()
        {
            Console.WriteLine("Event Organizer :" + _organizer);
            Console.WriteLine("Stall Count:" + _stallCount);
            Console.WriteLine("Credit Details");
            Console.WriteLine("Total Credit Gained is " + _stallCount * 50);
        }
        public override string ToString()
        {
            base.TotalCredit();
            return "";
        }

    }
}
