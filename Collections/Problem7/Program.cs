using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem7
{
    internal class Program
    {
        /*static void Main(string[] args)
        {

            Console.WriteLine("Enter total number of users");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter User Details");
            User[] users = new User[x];

            for (int i = 0; i < x; i++)
            {
                string s = Console.ReadLine();
                string[] detail = s.Split(",");
                string name = detail[0];
                string email = detail[1];
                string contactno = detail[2];

                User user = new User(name, email, contactno);
                users[i] = new User(name, email, contactno);
            }
            Console.WriteLine("Sort By 1]Name 2]Email");
            int ch = Convert.ToInt32(Console.ReadLine());
            if(ch == 1)
            {
                Array.Sort(users, new NameComparator());
                foreach(User user in users)
                {
                    Console.WriteLine(user.ToString());
                }
            }
            else
            {
                Array.Sort(users, new EmailComparator());
                foreach (User user in users)
                {
                    Console.WriteLine(user.ToString());
                }
            }
        }*/
    }
}
