using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a progrm to calculate the total credit and display the event details baed on event type.

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Event with the following protected attributes/variables. 
Data Type	Variable
string	_name
string	_detail
string	_organizer

Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor Event(string _name, string _detail, string _organizer)

In the Event class include the following method
Method	Description
public void TotalCredit()	Display "Credit Details"
 
Define the following method in the Event class.

Method Name  	Description
public void TotalCredit()	In this method, compare the phone number of the two users and return true if both the numbers are equal else return false.

Create a class named Exhibition with the following private attributes/variables.
Data Type	Variable
int	_stallCount
 

Include a four-argument constructor with parameters in the following order,  
public Exhibition(string _name, string _detail, string _organizer, int _stallCount)

Use base Keyword to call the base class constructor. 

In the Exhibition class override the TotalCredit() method of the Event Class
Method	Description
public void TotalCredit()	Call TotalCredit() of base class using base.
Compute the total credit and display the same
 

Formula to calculate total credits for exhibition:   (stallCount * 50)

Override ToString() method in the Exhibition class to display the Exhibition Details.

Create class StageEvent with the following private attributes/variables.
Data Type	Variable
int	_totalShow
int	_seatsPerShow
 

Include a five-argument constructor with parameters in the following order,  
 public StageEvent(string _name, string _detail, string _organizer, int _totalShow, int _seats)

In the StageEvent class override the TotalCredit() method of the Event Class
Method	Description
public void TotalCredit()	Call TotalCredit() of base class using base.Compute the total credit and display the same

Formula to calculate total credits for stage event: 
(totalShow* seatsPerShow )* 100

Override ToString() method in the StageEvent class to display the stage event details.

Create Program class with Main method, read the Event type from the user and create corresponding objects.
Display Event Details along with total credit.

Input and Output Format:
Refer sample input and output for formatting specifications. 

[All text in bold corresponds to the input and the rest corresponds to output.]

 

Sample Input and Output 1: 
Enter Event Name
The phenomenal show
Enter Detail
World wide best stage show activites
 Enter Organizer
john
Select Event Type 1.Exhibition 2.StageEvent
2
Enter Total shows
5
Enter seats per show
100
Event Name : The phenomenal show
Event Detail : World wide best stage show activites
Event Organizeer : john
Total Events : 5
Total Seats : 100
Credit Details
Total Credit Gained is 50000

Sample Input and Output 2:
 Enter Event Name
Dubai Food fest
Enter Detail
dubai food items
Enter Organizer
faizur
Select Event Type 1.Exhibition 2.StageEvent
1
Enter stall count
100
Event Name : Dubai Food fest
Event Detail : dubai food items
Event Organizer : faizur
Stall Count : 100
Credit Details
Total Credit Gained is 5000

Sample Input and Output 3:
Enter Event Name
sevens football
Enter Detail
football tournament
Enter Organizer
gowtham
Select Event Type 1.Exhibition 2.StageEvent
5
Enter valid choice
*/
namespace Polymorphism.Problem3
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter Event Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Detail");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter Organizer");
            string organizer = Console.ReadLine();
            Console.WriteLine("Select Event Type 1.Exhibition 2.StageEvent");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter stall count");
                    int st = Convert.ToInt32(Console.ReadLine());
                    Exhibition exhibition = new Exhibition(name, detail, organizer, st);
                    Console.WriteLine(exhibition.ToString());
                    exhibition.TotalCredit();
                    break;
                case 2:
                    Console.WriteLine("Enter Total shows");
                    int toShow = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter seats per show");
                    int totalseat = Convert.ToInt32(Console.ReadLine());
                    StageEvent stageEvent = new StageEvent(name, detail, organizer, toShow, totalseat);
                    Console.WriteLine(stageEvent.ToString());
                    stageEvent.TotalCredit();
                    break;
                default:
                    Console.WriteLine("Enter valid choice");
                    break;
            }
           }
       */
    }
}
