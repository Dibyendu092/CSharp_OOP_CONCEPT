using System.Drawing;
/*
 Write a C# program to illustrate the method returning an object by getting details from user and display these details in a detailed view using the following classes and methods.

[Note : Strictly adhere to the object oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Rectangle with the following private attributes/variables.

Data type	Attributes
int	_length
int	_width
 

Include appropriate getters and setters.
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor is Rectangle(int _length, int _width)

Define the following method in the Rectangle class.

Method Name	Description
int Area( )	This method computes the area of the rectangle and returns it.
void Display( )	
This method displays the length and width of the rectangle.
Include the statement ‘Rectangle Dimension’ in this method.
Print the dimensions along with area of the rectangle.

Rectangle DimensionChange(int d)	This method changes the rectangle dimension by increasing the length and width of the rectangle by d times.
 

Create another class Program and write a Main method to test the above class.
In the Main() method, read the length and width details from the user and test the above methods.

The link to download the template code is given below
Code Template


Input and Output Format:
Refer sample input and output for formatting specifications.


[All text in bold corresponds to input and the rest corresponds to output.]

Sample Input and Output 1:

Enter the length of the rectangle
5
Enter the width of the rectangle
6
Rectangle Dimension
Length:5
Width:6
Area of the Rectangle:30
Enter the new dimension
2
Rectangle Dimension
Length:10
Width:12
Area of the Rectangle:120

 */


namespace Getter_Setter_Practise_Problem
{
    internal class Problem1
    {
        class Rectangle
        {
            private static int _length;
            private  static int _width;

            Rectangle() { }
            public  Rectangle(int length, int width)
            {
                _length = length;
                _width = width;
            }
            public Rectangle  DimensionChange(int d)
            {
                Rectangle r=new Rectangle();
                r.Length = _length*d;
                r.Width = _width*d;
                return r;
                 
            }

            public int Length
            {
                get { return _length; }
                set { _length = value; }
            }
            public int Width
            {
                get { return _length; }
                set { _width = value; }
            }

            public int Area() { return (_width*_length); }

            public void Display() {
                Console.WriteLine("Rectangle Dimension");
                Console.WriteLine("Length:" + _length);
                Console.WriteLine("Width:" + _width);
                Console.WriteLine("Area of the Rectangle:"+Area());
            }
        }
      /*  static void Main(string[] args)
        {
            Console.WriteLine("Enter the length of the rectangle");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the width of the rectangle");
            int y = Convert.ToInt32(Console.ReadLine());

            Rectangle m = new Rectangle(x,y);
            m.Display();
            Console.WriteLine("Enter the new dimension");
            int k = Convert.ToInt32(Console.ReadLine());
            m.DimensionChange(k);
            m.Display();
        }
      */
    }
}