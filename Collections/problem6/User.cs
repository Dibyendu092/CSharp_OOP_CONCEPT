using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Collections.problem6
{
    internal class User:IComparable<User>
    {
        private string _name;
        private string _add1;
        private string _add2;
        private long _pincode;

        public User(string _name , string _add1, string _add2, long _pincode) {
          this._name = _name;
          this._add1 = _add1;
          this._add2 = _add2;
          this._pincode = _pincode;
        }

        public int CompareTo(User obj)
        {

            if (this._pincode == obj._pincode)
            {
                if (this._add1.CompareTo(obj._add1) > 0)
                {
                    return 1;
                }
                else if (this._add1.CompareTo(obj._add1) <0)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (this._pincode > obj._pincode)
                {
                    return 1;
                }
                else if (this._pincode < obj._pincode)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }

        }
        public override string ToString()
        {
            //Fill Your Code Here
            return "Name : " + _name + " Address : " + _add1 + "," + _add2 + "," + _pincode;
        }
    }
}
