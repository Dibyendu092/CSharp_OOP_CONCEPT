namespace Abstract_Classes
{

    /*
     *  Note 1 : abstract method are the without any body ,only declaration is done here.syntax : public abstract void add(int x , iny)
     *  Note 2 : if a class has any abstract method then the class also be declared as abstract.
     *           abstract class Program{
     *             public abstract void add(int x, int y);
     *           }
     *  Note 3: If a method is declared as abstract under any class then the child class of that class is responsible for implementing the method.
     *  Note 4 : Example of implementation abstract class
     *           abstract class Program{
     *             public abstract void add(int x, int y);
     *           }
     *           class Sample:Program{
     *             public override void add(int , int y){//must be declared here
     *             }
     *           }
     * Note 5:abstract class have both abstract method and non-abstract method
     * Note 6:We cannot create instance of abstract class but we can create reference of abstract class.
     * Note 7:abstract method can contain constructor .
     */
    internal class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/
    }
}