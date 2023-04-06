using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesOfDotnet.Problem1
{
    internal class Account
    {
        private string aNumber;
        private double premium;
        private int discountPercent;
        

        public Account(string aNumber, double premium, int discountPercent)
        {
            this.aNumber = aNumber;
            this.premium = premium;
            this.discountPercent = discountPercent;
            
        }

        public string ANumber { get { return aNumber; } set { aNumber = value; } }
        public double Premium { get {  return premium; } set {  premium = value; } }
        public int DiscountPercent { get {  return discountPercent; } set {  discountPercent = value; } }
        
    }
}
