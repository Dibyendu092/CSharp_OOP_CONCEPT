using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem3
{
    internal class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of the userlist");
            int n=Convert.ToInt32(Console.ReadLine());
            List<string> list = new List<string>();
            for(int i = 0;i < n; i++)
            {
                string s = Console.ReadLine();
                if(s == " ")
                {
                    list.Add(null);
                }
                else
                {
                    list.Add(s);
                }
                
            }
            Dictionary<string, int> dic = new Dictionary<string, int>();
            foreach(string s in list)
            {
                if (dic.ContainsKey(s) && s != null)
                {
                    dic[s]++;
                }
                else
                {
                    dic[s] = 1;
                }
            }
            int c = 0;

            foreach(KeyValuePair<string,int> k in dic)
            {
                
                if(k.Value > 0 && (!string.IsNullOrEmpty(k.Key)))
                {
                    c++;
                }

            }
            Console.WriteLine("Total number of unique users"+c);
        }
        
    }
}
