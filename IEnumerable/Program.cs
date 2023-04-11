using System;
using System.Collections;
namespace IEnumerable
{
    internal class Program
    {
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
        }
        public class Organization :
        {
            List<Employee> Employees = new List<Employee>();

            public void Add(Employee employee)
            {
                Employees.Add(employee);
            }

            public IEnumerator GetEnumerator()
            {
                return Employees.GetEnumerator();
            }
        }

        public OrganizationEnumerator :IEnumerator{
            }

        static void Main(string[] args)
        {
            Organization list = new Organization();
            list.Add(new Employee { Id = 101, Name = "Dibyendu", Address = "b1/203", City = "Kolkata" });
            list.Add(new Employee { Id = 102, Name = "Asif", Address = "b1/205", City = "Bangalore" });
            list.Add(new Employee { Id = 103, Name = "Soumik", Address = "b1/201", City = "Pune" });
            list.Add(new Employee { Id = 104, Name = "Priyesh", Address = "b1/203", City = "Hydrabad" });

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Id+" "+emp.Name+" "+emp.Address+" "+emp.City);
            }
        }
    }
}