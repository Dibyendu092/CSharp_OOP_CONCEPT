using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem2
{
    public delegate void CalculateDelegate(int num1, int num2);
    internal class Program
    {
        public static void Addition(int num1, int num2)
        {
            //fill code here
            Console.WriteLine("The sum is :"+(num1 + num2));
        }

        public static void Subtract(int num1, int num2)
        {
            //fill code here
            Console.WriteLine("The subtraction is :"+(num1 - num2));
        }

       /* static void Main(String[] args)
        {
            Console.WriteLine("Enter the num1");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the num2");
            int y = Convert.ToInt32(Console.ReadLine());

            CalculateDelegate calculateDelegate = Program.Addition;
            calculateDelegate += Program.Subtract;

            calculateDelegate.Invoke(x, y);
        }*/
    }
}
