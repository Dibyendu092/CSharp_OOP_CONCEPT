namespace AccessModifier
{
    internal class Program/*if we does't mention any thing before the class it is by default internal.class cannot
                           be private in c# .*/

    {
        /*
         Their are 5 access modifier in c#
          1.priavte 
          2.public 
          3.protectected 
          4.internal
          5.protected internal*/
        private void test1()
        {
            Console.WriteLine("Private Method");
        }
        public void test2()
        {
            Console.WriteLine("Public Method");
        }
        protected void test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void test4()
        {
            Console.WriteLine("Protected Internal Method");
        }
        internal void test5()
        {
            Console.WriteLine("Internal Method");
        }
        
    }
}