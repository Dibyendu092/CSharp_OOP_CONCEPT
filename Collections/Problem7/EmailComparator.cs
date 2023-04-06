﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem7
{
    internal class EmailComparator : IComparer<User>
    {
        public int Compare(User u1, User u2)
        {
            // fill your code
            if(u1.Email.CompareTo(u2.Email) > 0)
            {
                return 1;
            }
            else if (u1.Email.CompareTo(u2.Email) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
