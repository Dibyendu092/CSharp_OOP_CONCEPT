using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem1
{
    internal class IMPSTransfer:FundTransfer
    {
        public override void Transfer(string accountNumber, double amount)
        {
            Console.WriteLine("The Amount is transferred using IMPS Transfer");
            Console.WriteLine("Rs." + amount + " is transferred to the Account Number " + accountNumber + "successfully");
            Console.WriteLine("The Service charge for this transaction is Rs." + amount * 0.02);
        }
    }
}
