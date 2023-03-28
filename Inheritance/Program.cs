namespace Inheritance
{
    /*
     Note 1 : In inheritance child class can acces all the property of parent class except the private member
     Note 2 : Parent class constructor will be accesable to the child class other wise inheritance will not be posiible
              When we create instance of child class it automatically called constructor of parent class
     Note 3 : Parent class can not acces the child class member but child class can access parent class member
     Note 4 : Parent class member can initialize creating by using the child class instance to make it as reference
     Note 5 :Every class that are defined by us are alwyas inherted from OBJECT class:
             Their are 4 Object Class---
             1.Equals();
             2.GetHashCode();
             3.GetType();
             4.ToString();
    Note 6:Types Of Inheritance : No of parent classes a child class can have or No of child classes a parent class have;
           a) Single inheritance:
              
                  class1 ---> class2
           b) Multi-level inheritance:
              
                  class1 --> class2 --> class3-->....
           c) Hierachical inheritance:
                        class1
                          |
                     ------------
                      |        |
                  class2       class3

           d) Hybrid inheritance:
                       class1
                          |
                     ------------
                      |        |
                  class2       class3
                      |         |
                     -------------
                           |
                         class4
           e) Muiltiple inheritancce:
                
                     class1   class2
                       |       |
                   ----------------
                           |
                        class3

        Note 7: In c# Hybrid and Multiple inheritance are not supported
        Note 8: We know that when child class instance is created the constructor of parent class automatically called
                if it is paremeter less. if the parent class constructor is parameterized then we have to use the keyword base
     */
    internal class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }*/
    }
}