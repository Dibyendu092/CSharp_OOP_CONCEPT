using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Problem3
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of students");
            int n = Convert.ToInt32(Console.ReadLine());

            string name;
            int id, age;
            Student[] students = new Student[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Student {0} Details", (i + 1));
                Console.WriteLine("Enter the id");
                id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the name");
                name = Console.ReadLine();
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());
                Student student = new Student(id, name, age);


                //fill code here
                students[i] = new Student(id, name, age);
            }


            //fill code here
            var x = students.OrderBy(x => x.Name).Select(x => x.Name).ToArray();


            Console.WriteLine("Sorted student names");
            //fill code here
            foreach (string y in x)
            {
                Console.WriteLine(y);

            }

        }*/
    }
}
