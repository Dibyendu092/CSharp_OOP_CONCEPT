using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Problem1
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of Courses");
            int n = Convert.ToInt32(Console.ReadLine());
            ArrayList courses = new ArrayList();

            //Fill your code here
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Course {0} Details", (i + 1));
                Console.WriteLine("Enter the id");
                string id = Console.ReadLine();
                Console.WriteLine("Enter the name");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the category");
                string category = Console.ReadLine();
                Console.WriteLine("Enter the price");
                int price = Convert.ToInt32(Console.ReadLine());
                Course course1 = new Course(id, name,category,price);
                courses.Add(course1);
                //Fill your code here
            }

            var result = courses.Cast<Course>().GroupBy(c => c.Category)
                                          .Select(g => new { Name = g.Key, Price = g.Min(c => c.Price) });


            foreach (var course in result)
            {
                Console.WriteLine("Course {{ Name = {0}, Price = {1} }}", course.Name, course.Price);
            }

        }*/
    }
}
