namespace Interface_Module
{
    /*
     Note 1: Abstract class Contain Only abstract method 
     Note 2: Every abstract method of an interface should be implemented by the child class of interface.
     Note 3: Generaly a class can inherit from another class to  consume the member of its parent whereas if a class is
             inheriting from an interface it is to implement the member of its parent.
     Note 4: a class can inherit from an interface as well as class at a time.
     Note 5 :The default scope of an interface member is public where as a class member has private;
     Note 6:By default every member of an interface is abstract so we dont required to use abstract modifier on it.
            interface A{
              void add(int a, int b);
            }
    Note 7:We cant declare any field and variable under interface .
    Note 8: If required a interface can inherit from another interface.
    Note 9:When we use abstract method in abstract class and then declare its body into the child class 

    note 10: ex-
            interface A{
              void add(int a, int b);
            }
            class B:A{
               public void add(int a, int b){
                 
               }
            }
  Note 11 : Multiple inheritance will be supported by interface.Because a child class have one and only one Parent class but it may have 
            many interface.

     */

    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/
    }
}