using System.ComponentModel;

namespace Features
{
    /*
     Improvement in out Parameter: 
     */
    public class Employee
    {
        private string Name;
        private int Id;
        private int Salary;

        public Employee(string name , int id, int salary) { 
            Name = name;
            Id = id;
            Salary = salary;
        }

        public void Deconstruct(out string name , out int id, out int salary)
        {
            name = Name;
            id = Id;
            salary = Salary;
        }
    }
    internal class Program
    {
        public void Math1(int  a, int b, ref int x, ref int y)
        {
             x = a + b;
             y = a * b;
        }
        public void Math2(int a, int b, out int x, out int y)
        {
            x = a + b;
            y = a * b;
        }
        public (int sum , int mul) Math3(int a, int b)
        {
            int x = a + b;
            int y = a * b;

            return (x, y);
        }
        static void Main(string[] args)
        {
            /*
              Improvement in out Parameter: 
            */

            /*
            int M =10, N = 20;
            Program program = new Program();
            int p = 0, q = 0;
            program.Math1(M, N, ref p, ref q);
            Console.WriteLine(p+" " + q);
            program.Math2(M, N, out p, out q);
            Console.WriteLine(p + " " + q);*/


            /*Tuple*/
            /*Program p = new Program();
            var obj = p.Math3(100, 5);
            Console.WriteLine(obj.Item1);
            Console.WriteLine(obj.Item2);

            Program p   = new Program();
            var (Sum, Mul) = p.Math3(200, 3);
            Console.WriteLine(Sum);
            Console.WriteLine(Mul);

            Program program = new Program();
            var obj = program.Math3(200, 5);
            Console.WriteLine(obj.sum);
            Console.WriteLine(obj.mul);*/

            /*Deconstructor*/
            /*Deconstructor can be overloaded but their is no need*/

            /* Employee employee = new Employee("Suraj", 101, 100000);

             var (ename, eid, esalary) = employee;
             Console.WriteLine(ename);
             Console.WriteLine(eid);
             Console.WriteLine(esalary);*/

            Employee employee = new Employee("Suraj", 101, 100000);

            var (ename, eid, _) = employee;
            Console.WriteLine(ename);
            Console.WriteLine(eid);
            
        }
    }
}