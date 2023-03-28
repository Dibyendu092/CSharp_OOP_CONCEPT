﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Inheritance-base()
Write a program to get and display the event details from the user based on the event type.

 

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Event with the following protected attributes.

Data Type	Attributes
string	_name
DateTime	_date
string	_type
string	_organizer
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Event(string _name, DateTime _date, string _type, string _organizer)


Consider a class named Exhibition which inherits Event class with the following private attributes.

Data Type	Attributes
string	_stallType
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Exhibition(string _name, DateTime _date, string _type, string _organizer, string _stallType)


Define the following method in the Exhibition class.

Method Name	Description
public void Display()	Display the details of both the Event class and Exhibition class.
 

Consider the class StageEvent which inherits Event class with the following private attributes.

Data Type	Attributes
string	_showType
Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor StageEvent(string _name, DateTime _date, string _type, string _organizer, string _showType)

Define the following method in StageEvent class.

Method Name	Description
public void Display()	Display the details of both the Event class and StageEvent class.

Create Program  class with Main method, get the event details from the user.
Based on the type of event, call the corresponding constructor and display the details as shown in the sample output. Use base() to call and assign values in base class constructor.

 

The link to download the template code is given below
Code Template


Input and Output Format:
Display “Enter the correct Event Type and try again...” when user gives invalid event type.

Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]


Sample Input and Output 1:

Enter the Event Name:
Rio Carnival
Enter the Event Date(dd/MM/yyyy):
31/01/2018
Enter the Event Organizer:
Sarah
Enter the Event Type(Exhibition/Stage Event):
Exhibition
Enter the Stall Type:
Banner Stands
Event Name: Rio Carnival
Event Date: 31/01/2018
Event Organizer: Sarah
Event Type: Exhibition
Stall Type: Banner Stands


Sample Input and Output 2:

Enter the Event Name:
Cannes Film Festival
Enter the Event Date(dd/MM/yyyy):
25/08/2018
Enter the Event Organizer:
David
Enter the Event Type(Exhibition/Stage Event):
Stage Event
Enter the Show Type:
Strolling Magicians
Event Name: Cannes Film Festival
Event Date: 25/08/2018
Event Organizer: David
Event Type: Stage Event
Show Type: Strolling Magicians


Sample Input and Output 3:

Enter the Event Name:
Edinburgh Fringe Festival
Enter the Event Date:
08/03/2018
Enter the Event Organizer:
Andrea
Enter the Event Type(Exhibition/Stage Event):
Conference
Enter the correct Event Type and try again...*/

namespace Inheritance.Problem2
{
    internal class Program
    {
        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Event Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Event Date:");

            string inputDate = Console.ReadLine();
            DateTime dateTime;
            bool isValidDate = DateTime.TryParseExact(inputDate, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateTime);
            if (isValidDate)
            {

                Console.WriteLine("Enter the Event Organizer:");
                string organizer = Console.ReadLine();
                Console.WriteLine("Enter the Event Type(Exhibition/Stage Event):");
                string type = Console.ReadLine();
                if (type == "Stage Event")
                {
                    Console.WriteLine("Enter the Show Type:");
                    string shtype = Console.ReadLine();
                    StageEvent stageEvent = new StageEvent(name, dateTime, type, organizer, shtype);
                    stageEvent.Display();

                }
                else if (type == "Exhibition")
                {
                    Console.WriteLine("Enter the Stall Type:");
                    string sttype = Console.ReadLine();
                    Exhibition exhibition = new Exhibition(name, dateTime, type, organizer, sttype);
                    exhibition.Display();
                }
                else
                {
                    Console.WriteLine("Enter the correct Event Type and try again...");
                }
            }
        }
        */
    }
}
