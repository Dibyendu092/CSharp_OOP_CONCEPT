using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem1
{
    internal class Account
    {
        protected string _holderName;
        protected long _accountNumber;
        protected string _IFSCCode;
        protected long _contactNumber;

        public Account()
        {

        }
        public Account(string holderName, long accountNumber, string iFSCCode, long contactNumber)
        {
            _holderName = holderName;
            _accountNumber = accountNumber;
            _IFSCCode = iFSCCode;
            _contactNumber = contactNumber;
        }

        public string HolderName
        {
            get { return _holderName; }
            set { _holderName = value; }
        }
        public long AccountNumber
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }

        public string IFSCCode
        {
            get { return _IFSCCode; }
            set
            {
                _IFSCCode = value;
            }
        }
        public long ContactNumber
        {
            get { return _contactNumber; }
            set
            {
                _contactNumber = value;
            }
        }

        public void Display()
        {
            Console.WriteLine("Your Contact Details");
            Console.WriteLine("HolderName :"+_holderName);
            Console.WriteLine("Account Number :"+_accountNumber);
            Console.WriteLine("IFSCCode :"+_IFSCCode);
            Console.WriteLine("ContactNumber :"+_contactNumber);
        }


    }
}
