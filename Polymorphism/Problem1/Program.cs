using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Write a program to display the details based on the payment mode used for ticket booking using method overloading.

 

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class TicketBooking and define the following methods.

Method Name  	Description
public void MakePayment(double amount)	When the payment mode is "Cash Payment", then get the amount and display the payment details.
public void MakePayment(string walletNumber, double amount)	When the payment mode is "Wallet Payment", then get the amount, wallet number and display the payment details.
public void MakePayment(string creditCard, string ccv, string name, double amount)	When the payment mode is "Credit Card", then get the amount, credit card details and display the payment details.

Consider another class Program and write a Main method to test the above class.
In the main method, get the payment mode details and call the corresponding method and display the payment details. Display ‘Please select the correct mode of payment...’ when user enter invalid mode of payment.

The link to download the template code is given below
Code Template

 

Input and Output Format:
 
Refer sample input and output for formatting specifications.
[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1:
 
Enter the mode of Payment:
1.Cash Payment
2.Wallet Payment
3.Credit Card
1
Enter the Amount of Payment:
5000
You have selected the Cash payment mode
The Amount is Rs.5000.

Sample Input and Output 2:
 
Enter the mode of Payment:
1.Cash Payment
2.Wallet Payment
3.Credit Card
2
Enter the Wallet Number:
GRB1083
Enter the Amount of Payment:
2000
You have selected the Wallet payment mode
Wallet Number: GRB1083
The Amount is Rs.2000.

Sample Input and Output 3:
 
Enter the mode of Payment:
1.Cash Payment
2.Wallet Payment
3.Credit Card
3
Enter the Credit Card Number:
5105105105105100
Enter the Validity Date(dd/MM/yyyy):
25/11/2020
Enter the Card Holder Name:
John Kennedy
Enter the Amount of Payment:
50000
You have selected the Credit Card payment mode
CreditCard Number:5105105105105100
Validity Date:25/11/2020
Card Holder Name: John Kennedy
The Amount is Rs.50000.

Sample Input and Output 4:
 
Enter the mode of Payment:
1.Cash Payment
2.Wallet Payment
3.Credit Card
4
Please select the correct mode of payment...*/

namespace Polymorphism.Problem1
{
    internal class Program
    {
       /* static void Main(string[] args)
        {
            TicketBooking tb = new TicketBooking();
            Console.WriteLine("Enter the mode of Payment:\n1.Cash Payment\n2.Wallet Payment\n3.Credit Card");

            int modee = Convert.ToInt32(Console.ReadLine());
            TicketBooking ticketBooking = new TicketBooking();

            switch (modee)
            {
                case 1:
                    Console.WriteLine("Enter the Amount of Payment:");
                    //Fill your code here
                    double d = Convert.ToDouble(Console.ReadLine());
                    ticketBooking.MakePayment(d);

                    break;
                case 2:
                    Console.WriteLine("Enter the Wallet Number:");
                    string m = Console.ReadLine();
                    Console.WriteLine("Enter the Amount of Payment:");
                    double k = Convert.ToDouble(Console.ReadLine());
                    ticketBooking.MakePayment(m,k);

                    //Fill your code here
                    break;
                case 3:
                    Console.WriteLine("Enter the Credit Card Number:");
                    string p = Console.ReadLine();
                    Console.WriteLine("Enter the Validity Date(dd/MM/yyyy):");
                    string q = Console.ReadLine();
                    Console.WriteLine("Enter the Card Holder Name:");
                    string r = Console.ReadLine();
                    Console.WriteLine("Enter the Amount of Payment:");
                    double d1 = Convert.ToDouble(Console.ReadLine());
                    //Fill your code here
                    ticketBooking.MakePayment(p,q,r,d1);
                    break;

                default:
                    Console.WriteLine("Please select the correct mode of payment...");
                    break;
            }
        }*/
    }
}
