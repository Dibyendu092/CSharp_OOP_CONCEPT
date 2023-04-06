using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FeaturesOfDotnet.Problem1
{
    internal class Program
    {
        public delegate void totalprice(double p, int d);
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of accounts :");
            int n = Convert.ToInt32(Console.ReadLine());
            List<Account> list = new List<Account>();

            Console.WriteLine("Enter accounts :");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Account Number :");
                string acno = Console.ReadLine();
                Console.WriteLine("Premium :");
                double premium = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Discount Percent :");
                int discount = Convert.ToInt32(Console.ReadLine());
                Account account = new Account(acno, premium, discount);
                list.Add(account);
            }

            Console.WriteLine("Account Details :");
            foreach (Account account in list)
            {
                Console.WriteLine("Account : " + account.ANumber);
                Console.WriteLine("Premium : Rs." + string.Format("{0:0.0}", account.Premium));
                Console.WriteLine("Discount :" + account.DiscountPercent + "%");
                double xi = account.Premium;
                int yi = account.DiscountPercent;

                totalprice tt = (x, y) =>
                {
                    double acct = x - ((double)y / 100) * x;
                    Console.WriteLine("Amount to be paid : Rs." + string.Format("{0:0.0}", acct));
                };
                tt.Invoke(xi,yi);
            }
        }*/
    }
}
