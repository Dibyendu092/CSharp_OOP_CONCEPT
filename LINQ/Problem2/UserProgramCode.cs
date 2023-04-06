using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Problem2
{
    internal class UserProgramCode
    {
        public static string[] FilterArray(string[] nameList, int minLength)
        {
            //fill code here
            var b = nameList.Where(x => x.Length < minLength).ToArray();
            return b;
        }
    }
}
