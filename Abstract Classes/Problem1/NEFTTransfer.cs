using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem1
{
    internal class NEFTTransfer:FundTransfer
    {
        private DateTime _date;
        private DateTime _start = DateTime.Parse("09:00:00 AM");
        private DateTime _end = DateTime.Parse("06:00:00 PM");


        public override void Transfer(string accountNumber, double amount)
        {
            Console.WriteLine("Enter the Transaction time(hh:mm:ss tt):");
            string d = Console.ReadLine();
            _date = DateTime.Parse(d);
            if (_date.TimeOfDay >= _start.TimeOfDay && _date.TimeOfDay <= _end.TimeOfDay)
            {
                Console.WriteLine("The Amount is transferred using NEFT Transfer");
                Console.WriteLine("Rs." + amount + " is transferred to the Account Number " + accountNumber + " successfully");
            }
            else
            {
                Console.WriteLine("The Transaction Time is " + _date.ToString("hh:mm:ss tt"));
                Console.WriteLine("NEFT Transfer is applicable between 9.00 AM and 6.00 PM.");
            }
        }

       }
}
