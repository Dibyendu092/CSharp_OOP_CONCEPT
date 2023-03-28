using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem6
{
    internal class Exhibition:Event
    {
        protected int _noOfStall;

        public Exhibition(string name, string type,int noofstall) :base(name, type) 
        {
            _noOfStall = noofstall;
        }
        public double ProjectedRevenue()
        {
            double d = base.ProjectedRevenue();
            return  d += _noOfStall*10000;
        }
    }
}
