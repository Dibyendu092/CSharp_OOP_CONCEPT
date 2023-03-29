using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem5
{
    internal class PlatinumStall:Stall
    {
        public string _coupon;
        public double _discount;


        public PlatinumStall(string name, string detail, string owner, double costPerDay, double discount, string coupon) : base(name, detail, owner, costPerDay)
        {
            _coupon = coupon;
            _discount = discount;
        }
        public override double calculateRent(int days)
        {
            if (_coupon == "yes")
            {
                _totalamount = ((days * _costPerDay) - ((days * _costPerDay) * _discount / 100)) / 2;
                return _totalamount;

            }
            else
            {
                return _totalamount = (days * _costPerDay) - ((days * _costPerDay) * _discount / 100);
            }
        }
        public override string ToString()
        {

            return base.ToString();
        }

    }
}
