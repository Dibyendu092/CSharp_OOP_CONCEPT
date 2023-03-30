using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism.Problem3
{
    internal class StageEvent:Event
    {
        private int _totalShow;
        private int _seatsPerShow;

        public StageEvent() { }
        public StageEvent(string name, string detail, string organizer, int totalShow, int seatsPerShow) : base(name, detail, organizer)
        {
            _totalShow = totalShow;
            _seatsPerShow = seatsPerShow;
        }
        public override void TotalCredit()
        {
            Console.WriteLine("Event Organizeer :" + _organizer);
            Console.WriteLine("Total Events:" + _totalShow);
            Console.WriteLine("Total Seats: " + _seatsPerShow);
            Console.WriteLine("Credit Details");
            Console.WriteLine("Total Credit Gained is " + (_totalShow * _seatsPerShow * 100));
        }

        public override string ToString()
        {
            base.TotalCredit();
            return "";
        }
    }
}
