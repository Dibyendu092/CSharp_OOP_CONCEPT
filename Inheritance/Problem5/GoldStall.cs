using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem5
{
    internal class GoldStall:Stall
    {
        public double _discount;

        public GoldStall(string name, string detail, string owner, double costPerDay, double discount) : base(name, detail, owner, costPerDay)
        {
            _discount = discount;
        }

        public override double calculateRent(int days)
        {
            return _totalamount = (days * _costPerDay) - ((days * _costPerDay) * _discount / 100);
        }
        public override string ToString()
        {
            return base.ToString();

        }
    }
}
