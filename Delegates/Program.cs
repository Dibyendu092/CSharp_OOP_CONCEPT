namespace Delegates
{
    /*
     Note 1 : Delegates: Its a type safe pointer function.It holds reference of a method then call the method for execution.
     Note 2:To call an delegates we have three step-
            first declare delegates
               <Modifier> delegate void|TYPE  <NAME> (parameterlist)
            second instanciate the delegate
            third now calling the delegate by passing the required value so that it execute internally.
    Note 3: It will be better to make delgate method void 
    Note 4: Their are three predefine delegate: a> func, b> action, c> predicate
    Note 5 : func deligate basically use for value returning method
    NOte 6 : action deligte basically use for non value returning method
    Note 7: predicate deligate basically use for when we want to return boolean

     */
    public delegate int Addx(int x, int y);
    public delegate int Subx(int a, int b);
    public delegate void calc(int a, int b);

    public delegate int Sample1(int a, int b, int c);
    public delegate void Sample2(int a, int b, int c);
    internal class Program
    {
        public void mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        public static void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public int Add(int x, int y)
        {
            return x + y;
        }
        public static int sub(int x, int y)
        {
            return x - y;
        }
        /*static void Main(string[] args)
        {
            /*Basic Delegates*/

            /*Program program = new Program();
            Addx addx = new Addx(program.Add);
            Console.WriteLine(addx(100, 50));
            Console.WriteLine(addx.Invoke(100, 50));

            Subx subx = new Subx(sub);
            Console.WriteLine(subx.Invoke(100,50));
            Console.WriteLine(subx(100, 50));*/

            /*Multicast Delegate*/

            /*
            Program program = new Program();
            calc cal = program.mul;
            cal += program.div;
            cal.Invoke(6, 3);

            cal.Invoke(12, 2);
            */


            /*generic delegates*/

            /*Program p = new Program();
            Func<int, int, int> obj = p.Add;
            Console.WriteLine(obj.Invoke(5, 4));



            Action<int, int> obj1 = div;
            obj1.Invoke(50, 2);*/

            
            /*anonymous Method*/
            /*Sample1 s1 = delegate (int x, int y, int z)
            {
                return (x + y + z);
            };
            Console.WriteLine(s1.Invoke(10, 15, 20));

            Sample2 s2 = delegate (int x, int y, int z)
            {
                Console.WriteLine(x - y - z);
            };
            s2.Invoke(50, 20, 10);*/

        /*}*/
    }
}