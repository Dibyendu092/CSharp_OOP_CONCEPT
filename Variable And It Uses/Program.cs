namespace Variable_And_It_Uses
{
    internal class Program
        /*Note 1:  non static -variable required instances of class for initialization or execution but satic member does't required it
         because when the execution start static variable automatically initialize
         
         Note 2: in the life cycle of a class a static variable initialize one and only one time
                 but non static variable is initialized 0 times if no instances are created and n times if n instances are created

         Note 3: instance or non-static variable can be initialize through constructor
        
         Note 4: we are not initialize static variable through constructor because it override the value

         Note 5 : if a variable is declare with const keyword it will be called constant variable and it will never change.
                  It cannot be modified after declaration
        
         Note 6:  If a variable declare with raedonly key word than that is called readonly variable and it can't be modified after 
                  initialization but modified after declaration
        */
    {
      
        int x = 50;
        static int p=100;
        const float f = 1.0f;
        readonly bool k = true;

        Program(int y,int m)
        {
            this.x = y;
            p = m;
        }
        static void Main(string[] args)
        {
            Program s = new Program(100,300);
            Console.WriteLine(s.x);
            Console.WriteLine(Program.p);
            Console.WriteLine(Program.f);
            Console.WriteLine(s.k);
            //not accepted s.k = false;
        }
    }
}