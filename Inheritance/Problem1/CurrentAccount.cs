using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem1
{
    internal class CurrentAccount:Account
    {
        protected string _organizationName;
        protected long _TIN;

        public CurrentAccount(string holderName, long accountNumber, string iFSCCode, long contactNumber,string organizationName, long tIN):base(holderName, accountNumber, iFSCCode, contactNumber)
        {
            _organizationName = organizationName;
            _TIN = tIN;
        }

        public string Organization
        {
            get { return _organizationName; }  
            set { _organizationName = value; }
        }
        public long Tin
        {
            set { _TIN = value; }   
            get { return _TIN; }
        }
        public void Display()
        {
            base.Display();
            Console.WriteLine("Organization Name :"+_organizationName);
            Console.WriteLine("TIN :"+_TIN);
        }
    }
}
