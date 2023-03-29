using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Problem5
{
    internal class Stall
    {
        protected string _name;
        protected string _detail;
        protected string _owner;
        protected double _costPerDay;
        protected static double _totalamount;


        public Stall(string name, string detail, string owner, double costPerDay)
        {
            _name = name;
            _detail = detail;
            _owner = owner;
            _costPerDay = costPerDay;
        }
        public virtual double calculateRent(int days)
        {
            return _totalamount += _costPerDay * days;
        }

        public override string ToString()
        {
            Console.WriteLine("Name : " + _name);
            Console.WriteLine("Detail : " + _detail);
            Console.WriteLine("Owner : " + _owner);
            Console.WriteLine("Cost Per Day : " + _costPerDay);
            return "";
        }
    }
}
