using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem5
{
    internal class Hall:IComparable<Hall>
    {
        private string _name;
        private long _mobileNumber;
        private string _ownerName;
        private double _costPerDay;
        public Hall(string _name, long _mobileNumber, string _ownerName, double _costPerDay)
        {
            this._name = _name;
            this._mobileNumber = _mobileNumber;
            this._ownerName = _ownerName;
            this._costPerDay = _costPerDay;
        }
        public int CompareTo(Hall obj)
        {
            //Fill your code here
            if(this._costPerDay > obj._costPerDay)
            {
                return 1;
            }
            else if(this._costPerDay < obj._costPerDay)
            {
                return -1;
            }
            else
            {
                return 0;
            }
            
        }
        public override string ToString()
        {
            string k=string.Format("{0,-20} {1,-15} {2,-15} {3,-10}", _name, _mobileNumber, _ownerName, _costPerDay);
           
            //Fill your code here
            return k;
        }

    }
}
