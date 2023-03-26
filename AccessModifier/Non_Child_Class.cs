using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifier
{
    /*protected method and private method cannot be accesable from non child class*/
    class Non_Child_Class
    {
        static void Main()
        {
            Program p = new Program();
            p.test2();
            p.test4();
            p.test5();
        }
    }
}
