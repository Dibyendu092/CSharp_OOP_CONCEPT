using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem1
{
    internal class SavingAccount : Account
    {
        protected double _interestRate;

        public SavingAccount(string holderName, long accountNumber, string iFSCCode, long contactNumber ,double interestRate): base(holderName, accountNumber, iFSCCode, contactNumber)
        {
            _interestRate = interestRate;
        }

        public double InterestRate
        {
            get { return _interestRate; }
            set { _interestRate = value; }
        }

        public void Display()
        {
            base.Display();
            Console.WriteLine("Interest Rate :" + _interestRate);
        }
    }
}
