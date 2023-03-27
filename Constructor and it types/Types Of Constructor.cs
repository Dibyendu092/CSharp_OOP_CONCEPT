namespace Constructor
{
    internal class Program
    {
        /* 
         *Their are 4 type of constructor:
         *Parameterless Constructor
         *Prameterized Constructor
         *Copy Constructor
         *Static Constructor
         * 
         * Note 1: Constructor are basically use for initializing the variavble 
           Note 2 : Name of the constructor are same as name of the class
           Note 3 : It is also a returning value method 
           Note 4: Constructor are automatically called when the object is created 
           Nopt 6: Implicit constructor are called default constructor which does't take any parameter or parameterless constructor
           Note 7: Impicit  Constructor are public 
           Note 8: If we declare a constructor under a class then it it will call explicit constructor and explicit constructor are
                   parameterless or parameterized
           Note 9: Copy Constructor:
                    If we want to create multiple instance with the same value then we use copy constructor, in a copy constructor 
                    the constructor take the same class as parameter to it
           Note 10: Static Constructor:
                    If we declare a constructor with static keyword then it is called static constructor.all the constructor other than this a non static constructor

           Note 11: If a class contain any static variable then only implicit static constructor will be present or else we need to define them explicitly
                    
           Note 12 : Static constructor are rseponsible for initializing the static variable
           Note 13 :Static constructor cannot be parameterized and it cannot be over loaded 
            */

        public int x;
        bool b;
       
        /*static constructor
         * it always executed before main methd*/
        static Program()
        {
            Console.WriteLine("Static Constructor");
        }

        Program(int a, bool c)
        {
            this.x = a; 
            this.b = c;
        }
        public Program(int x)
        {
            this.x = x;
        }
        
        /*Copy Constructor*/
        public Program(Program obj)
        {
            x = obj.x;
        }
        public void display()
        {
            Console.WriteLine(x);
        }


        static void Main(string[] args)
        {
            /*
             Implicit Constructor
            */

            /*Program p = new Program();
            Console.WriteLine(p.x);
            Console.WriteLine(p.b);*/

            /*Explicit Constructor*/
            /*
            Program p = new Program(100, true);
            Console.WriteLine(p.x);
            Console.WriteLine(p.b);*/

            /*copy Constructor*/
            /*
            Program p = new Program(5);
            Program m = new Program(p);
            p.display();*/

            Console.WriteLine("Main Method");


            
        }
    }
}