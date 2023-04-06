using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem4
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the total number of hall owners");
            int x = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, List<string>> dic = new Dictionary<string, List<string>>();

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter owner name " + (i + 1));
                string ownername = Console.ReadLine();
                Console.WriteLine("Enter total number of halls owned by " + ownername);
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter list of halls owned by " + ownername);
                List<string> list = new List<string>();
                for (int j = 0; j < y; j++)
                {
                    string hallname = Console.ReadLine();

                    list.Add(hallname);
                }
                dic.Add(ownername, list);
            }

            foreach (KeyValuePair<string, List<string>> pair in dic)
            {
                Console.WriteLine("Owner Name : " + pair.Key);

                Console.WriteLine("Halls Owned :");
                foreach (string hallName in pair.Value)
                {
                    Console.WriteLine(hallName);
                }
                Console.WriteLine();
            }
        }*/
    }
}
