using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program to calculate the perimeter of different shapes using an abstract class.

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Create an abstract class Shape with the following methods.
Method Name	Description
public abstract double Perimeter()	Base class method to be overridden.

Consider a class Square which inherits Shape with the following private attributes.
Data Type	Attribute
double	_side
The methods for getters, setters and constructors are given in the template code.



Include the following method in Square class.

Method Name	Description
double Perimeter()	This method is used override Perimeter method in Shape class and to calculate the perimeter of square.

Consider a class Rectangle which inherits Shape with the following private attributes.
Data Type	Attribute
double	_length
double	_width
The methods for getters, setters and constructors are given in the template code.


Include the following method in Rectangle class.

Method Name	Description
double Perimeter()	This method is used override Perimeter method in Shape class and to calculate the perimeter of rectangle.

Consider a class named Circle with the following private attributes.
Data Type	Attribute
double	_radius
The methods for getters, setters and constructors are given in the template code.


Include the following method in Circle class.

Method Name	Description
double Perimeter()	This method is used override Perimeter method in Shape class and to calculate the perimeter of circle.

Consider Program class with Main method to test the above class.
In the Main() method, get the details of the shape from the user and calculate the perimeter of the respective shape.

The link to download the template code is given below
Code Template

Input and Output Format :
All the double values should be displayed upto 2 decimal places.
Display “Invalid input” when user enter invalid choice of shape.
Refer sample input and output for formatting specifications. Display the perimeter correct to 2 decimal places.

[All text in bold corresponds to the input and the rest corresponds to output]

Sample Input and Output 1:
Shapes
1.Square
2.Rectangle
3.Circle
Enter your choice
1
Enter the side of the square
5.6
Perimeter of square is 22.40

Sample Input and Output 2:
Shapes
1.Square
2.Rectangle
3.Circle
Enter your choice
2
Enter the length of the rectangle
5
Enter the width of the rectangle
6.3
Perimeter of rectangle is 22.60

Sample Input and Output 3:
Shapes
1.Square
2.Rectangle
3.Circle
Enter your choice
3
Enter the radius of the circle
5
Perimeter of circle is 31.40

Sample Input and Output 4:
Shapes
1.Square
2.Rectangle
3.Circle
Enter your choice
5
Invalid input
 


 */

namespace Abstract_Classes.Problem2
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Shapes\n1.Square\n2.Rectangle\n3.Circle\nEnter your choice");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch(choice)
            {
                case 1:
                       Console.WriteLine("Enter the side of the square");
                       double d = Convert.ToDouble(Console.ReadLine());
                       Square s = new Square(d);
                       Console.WriteLine("Perimeter of square is " + String.Format("{0:0.00}",s.Perimeter()));
                       break;
                case 2:
                       Console.WriteLine("Enter the length of the rectangle");
                       double m = Convert.ToDouble(Console.ReadLine());
                       Console.WriteLine("Enter the width of the rectangle");
                       double k = Convert.ToDouble(Console.ReadLine());
                       Rectangle r = new Rectangle(m, k);
                       Console.WriteLine("Perimeter of rectangle is " + String.Format("{0:0.00}",r.Perimeter()));
                       break;
                case 3:
                       Console.WriteLine("Enter the radius of the circle");
                       double kr = Convert.ToDouble(Console.ReadLine());
                       Circle circle = new Circle(kr);
                       Console.WriteLine("Perimeter of circle is " + String.Format("{0:0.00}",circle.Perimeter()));
                       break;
                default:
                       Console.WriteLine("Invalid input");
                       break;
            }*/
        }
    }
}
