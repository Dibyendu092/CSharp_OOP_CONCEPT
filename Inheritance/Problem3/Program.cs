﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
GST Calculation

Write a program to calculate the total amount with GST for the events. There are two types of Events Stage show and Exhibition. For Stage show GST will be 15% and for exhibition GST will be 5%.

 

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider a class names Event with the following protected attributes.

Data Type	Attributes
string	_name
string	_type
double	_costPerDay
int	_noOfDays
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Event(string _name, string _type, double _costPerDay, int _noOfDays)

Consider the class Exhibition which inherits the Event class with the following private attributes.

Data Type	Attributes
static int	_gst = 5
int	_noOfStalls
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Exhibition(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfStalls)

Define the following method in the Exhibition class.

Method	Description
public double totalCost()	This method is to calculate the total amount with 5% GST.

Consider the class StageEvent which inherits the Event class with the following private attributes.
Data Type	Attributes
static int	_gst = 15
int	_noOfSeats
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor StageEvent(string _name, string _type, double _costPerDay, int _noOfDays, int _noOfSeats)

Define the following method in the StageEvent class.

Method	Description
public double totalCost()	This method is to calculate the total amount with 15% GST.

Use base() to call and assign values in base class constructor.
Override ToString() method to display the event details and the total amount inside this ToString() method.

Create Program class with Main method.
In the Main() method, read the event details from the user and then create the object of the event according to the event type. Display the statement ‘Event Details’ inside the Main() method.

The link to download the template code is given below
Code Template


Input and Output Format:

All the double values should be displayed upto 2 decimal palces

Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]


Sample Input and Output 1:

Enter event name
Sky Lantern Festival
Enter the cost per day
1500
Enter the number of days
3
Enter the type of event
1.Exhibition
2.Stage Event
2
Enter the number of seats
100
Event Details
Name:Sky Lantern Festival
Type:Stage Event
Number of seats:100
Total amount: 5175.00

Sample Input and Output 2:

Enter event name
Glastonbury
Enter the cost per day
5000
Enter the number of days
2
Enter the type of event
1.Exhibition
2.Stage Event
1
Enter the number of stalls
10
Event Details
Name:Glastonbury
Type:Exhibition
Number of stalls:10
Total amount: 10500.00

Sample Input and Output 3:

Enter event name
Glastonbury
Enter the cost per day
5000
Enter the number of days
2
Enter the type of event
1.Exhibition*/

namespace Inheritance.Problem3
{
    
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter event name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day");
            double costperday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the number of days");
            int noofday = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the type of event");
            Console.WriteLine("1.Exhibition");
            Console.WriteLine("2.Stage Event");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the number of stalls");
                    int noofstall = Convert.ToInt32(Console.ReadLine());
                    string type2 = "Exhibition";
                    Exhibition exhibition = new Exhibition(name, type2, costperday, noofday, noofstall);
                    Console.WriteLine("Event Details");
                    Console.WriteLine(exhibition.ToString());
                    break;
                case 2:
                    Console.WriteLine("Enter the number of seats");
                    int noofseat = Convert.ToInt32(Console.ReadLine());
                    string type1 = "Stage Event";
                    StageEvent stageEvent = new StageEvent(name, type1, costperday, noofday, noofseat);
                    Console.WriteLine("Event Details");
                    Console.WriteLine(stageEvent.ToString());
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;
            }

        }*/
    }
}
