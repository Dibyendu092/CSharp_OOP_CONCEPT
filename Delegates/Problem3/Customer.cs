using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem3
{
    public delegate void NameDelegate();
    internal class Customer
    {
        public string _firstName;
        public string _lastName;

        public Customer(string _firstName, string _lastName)
        {
            this._firstName = _firstName;
            this._lastName = _lastName;
        }

        public void DisplayFirstName()
        {
            //fill code here
            Console.WriteLine("First Name: " + _firstName);
        }

        public void DisplayLastName()
        {
            //fill code here
            Console.WriteLine("Last Name: "+_lastName);
        }
    }
}
