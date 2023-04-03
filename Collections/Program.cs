
using System.Collections;
using System.Collections.Generic;
using System.Numerics;

namespace Collections
{
    /*
     Note 1: We can say dynamic array are collection
     Note 2 : Their are two types of collection
              Generic collection:List.
              Non-Generic Collection: Stack, Queue, LinkedList , SortedList, Hashtable, ArrayList
    Note 3 : Arraylist have autoresizing features and if it is not declared previously the capacity then it will double the capacity after certain limit
    Note 4 : Array is not type safe and auto resizing but generic collection are type safe and auto resizing
    Note 5: Dictionary collection store the value in sorted manner but hashtable does not store in sorted manner
     */
    internal class Program
    {

       
        public class Student:IComparable<Student>//IComparable Method
        {
            public int Sid
            {
                get; set;
            }
            public string Name { get; set; }
            public int Age { get; set; }

            public int CompareTo(Student other)
            {
                if(this.Sid > other.Sid)
                {
                    return 1;
                }
                else if(this.Sid < other.Sid)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }

            }
        }
        public class CompareStu : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                if (x.Age > y.Age)
                {
                    return 1;
                }
                else if(x.Age < y.Age)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }
        public class Coustomer
        {
            public int Cousid
            {
                get; set;
            }

            public string Name { get; set; }
            public string Brief { get; set; }
        }
        class Generic1
        {
            public void Add<T>(T a, T b) {
                dynamic d1 = a;
                dynamic d2 = b;
               Console.WriteLine((d1+d2));
            }
        }
        class Generic2<T>
        {
            public void mul(T a, T b)
            {
                dynamic d1 = a;
                dynamic d2 = b;
                Console.WriteLine((d1 * d2));
            }

        }
        /*static void Main(string[] args)
        {
            /*array list Implementation
             * ArrayList arrayList = new ArrayList();
            for(int i = 0; i < 5; i++)
             {
                 arrayList.Add(i);
             }

             arrayList.Insert(1, 5);
             arrayList.RemoveAt(1);
             arrayList.Reverse();
             arrayList.RemoveRange(1, 3);
             ............................manyMore Method
             Console.WriteLine(arrayList.LastIndexOf(0));
            foreach(object obj in arrayList)
             {
                 Console.WriteLine(obj);
             }*/


            /*HashTable*/

            /*
            Hashtable ht = new Hashtable();

            ht.Add("Id", "101");
            ht.Add("Name", "Dibyendu");
            ht.Add("Roll", "18700119092");

            Console.WriteLine(ht["Roll"]);
            foreach (string key in ht.Keys)
            {
                Console.WriteLine(key + " " + ht[key]);
            }*/


            /*List*/

            /*List<int> list = new List<int>();

            for(int i=0;i<5;i++)
            {
                list.Add(i);
            }

            for(int i=0;i<list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
            */

            /*Complex List Implementaion*/
            /*List<Coustomer> list = new List<Coustomer>();
            for(int i = 0; i < 5; i++)
            {
                int id = i;
                string s = Console.ReadLine();
                string b = Console.ReadLine();
                Coustomer c = new Coustomer { Cousid = id, Name = s, Brief = b };
                list.Add(c);

            }

            foreach(Coustomer c in list)
            {
                Console.WriteLine(c.Cousid+" "+c.Name+" "+c.Brief);
            }*/

            /*Generic1 generic1 = new Generic1();
            generic1.Add<int>(15, 25);
            generic1.Add<float>(15.2f, 25.3f);
            generic1.Add<double>(15.20, 25.31);*/

            /*Generic2<int> generic2 = new Generic2<int>();
            generic2.mul(14, 23);
            Generic2<float> generic3 = new Generic2<float>();
            generic3.mul(14.3f, 23.3f);*/


            /*Dictionary<int , Dictionary<int,string> > dic = new Dictionary<int ,Dictionary<int, string> >();
            dic[0].Add(10, "Hello");
            dic[1].Add(11, "Kaju");

            foreach(var outer in dic)
            {
                foreach(var obj in  outer.Value)
                {
                    Console.WriteLine(obj.Key+obj.Value);
                }
            }*/


            /*IComparable Method*/
            /*
             * Student s1 = new Student{ Sid=101, Name="Rahul",Age=20};
            Student s2 = new Student { Sid = 105, Name = "Raja", Age = 25 };
            Student s3 = new Student { Sid = 103, Name = "Prajesh", Age = 10 };
            Student s4 = new Student { Sid = 107, Name = "Kaul", Age = 21 };

            List<Student> s = new List<Student> { s1, s2, s3, s4};
            s.Sort();
            foreach(Student student in s)
            {
                Console.WriteLine(student.Sid+" "+student.Name+" "+student.Age);
            }
            */

            /*IComparar Method*/
            /*
            Student s1 = new Student { Sid = 101, Name = "Rahul", Age = 20 };
            Student s2 = new Student { Sid = 105, Name = "Raja", Age = 25 };
            Student s3 = new Student { Sid = 103, Name = "Prajesh", Age = 10 };
            Student s4 = new Student { Sid = 107, Name = "Kaul", Age = 21 };

            List<Student> s = new List<Student> { s1, s2, s3, s4 };
            CompareStu compareStu = new CompareStu();
            s.Sort(compareStu);
            foreach (Student student in s)
            {
                Console.WriteLine(student.Sid + " " + student.Name + " " + student.Age);
            }*/

        /*}*/
       
    }
}