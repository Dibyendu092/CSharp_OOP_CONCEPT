using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem1
{
    internal class Program
    {
        public delegate void rectangleDelegate(double width, double height);

        public void PrintArea(double width, double height)
        {
            Console.WriteLine("Area is:" + width * height);
        }
        public void PrintPerimeter(double width, double height)
        {
            Console.WriteLine("Perimeter is: "+2*(width + height));
        }
        /*static void Main(string[] args)
        {
            Program p = new Program();
            rectangleDelegate rectangleDelegate = p.PrintArea;
            rectangleDelegate += p.PrintPerimeter;
            Console.WriteLine("Enter the width");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the height");
            double d2 = Convert.ToDouble(Console.ReadLine());

            rectangleDelegate.Invoke(d1, d2);

        }*/
    }
}
