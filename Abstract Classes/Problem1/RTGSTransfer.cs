using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem1
{
    internal class RTGSTransfer:FundTransfer
    {
        public override void Transfer(string accountNumber, double amount)
        {
            if(amount > 10000)
            {
                Console.WriteLine("The Amount is transferred using RTGS Transfer");
                Console.WriteLine("Rs." + amount + " is transferred to the Account Number " + accountNumber + "successfully");
            }
            else
            {
                Console.WriteLine("RTGS Transfer can be done for the amount greater than Rs.10000");
            }
            
        }
    }
}
