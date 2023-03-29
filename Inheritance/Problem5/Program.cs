﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program to Calculate Rent based on the type of stall.

 

[Note:  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class Stall with the following protected attributes.

Data Type	Attributes
string	_name
string	_detail
string	_owner
double	_costPerDay

The methods for constructors is given in the template code.

In class Stall include the following method.
Method	Description
public virtual double CalculateRent(int days)	In this method, calculate the rent amount using the formula and return the same based on stall type. Formula for rent calculation is rent=days * costPerDay/100

Consider the class GoldStall which inherits the Stall class with the following public attributes.
Data Type	Attributes
double	_discount

Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor GoldStall(string _name, string _detail, string _owner, double _costPerDay, double _discount)
Use base keyword to call base class constructor.

In class GoldStall define the following method and override the CalculateRent method of Stall class.
Method	Description
public double CalculateRent(int days)	In this method, calculate the rent amount using the formula given below and return the same. Formula for rent calculation is rent=(days * costPerDay) - ((days * costPerDay )* discount/100)

Consider the class PlatinumStall which inherits the Stall class with the following public attributes.
Data Type	Attributes
string	_coupon

Include default and parameterized constructor for the class.
Prototype for the Parameterized Constructor PlatinumStall(string _name, string _detail, string _owner, double _costPerDay, double _discount, string _coupon)
Use base keyword to call base class constructor.


In the class PlatinumStall define the following method and override the CalculateRent method of Stall class.
Method	Description
double calculateRent(int days)	In this method, calculate the rent amount based on the coupon value and return the same.

Formula for rent calculation:
If coupon is available, then the rent will be calculated using
rent=((days * costPerDay) - ((days * costPerDay) * discount/100))/2
else
rent=(days * costPerDay) - ((days * costPerDay) * discount/100)



Consider Program class with Main method, get the stall details from the user.
Based on the type of stall, calculate the corresponding rent amount and display the stall details. Override ToString() method in all the classes to display the stall details.

The link to download the template code is given below
Code Template


Input and Output Format:

Display “Invalid choice” when the user select invalid stall choice.
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1:

Enter stall name
punjabi dhaba
Enter stall detail
Traditional North Indian Foot Style
Enter stall owner name
karam singh
Enter cost per day
15000
1.Stall 2.GoldStall 3.PlatinumStall
1
Enter Total Number of Days
2
Name : punjabi dhaba
Detail : Traditional North Indian Foot Style
Owner : karam singh
Cost Per Day : 15000
Your Total Cost 30000


Sample Input and Output 2:

Enter stall name
Radisson square garden
Enter stall detail
chat items
Enter stall owner name
xio
Enter cost per day
7000
1.Stall 2.GoldStall 3.PlatinumStall
2
Enter Total Number of Days
1
Enter discount percentage
2.5
Name : Radisson square garden
Detail : chat items
Owner : xio
Cost Per Day : 7000
Your Total Cost 6825


Sample Input and Output 3:

Enter stall name
food plaza
Enter stall detail
multicuinse restaurent
Enter stall owner name
ravi
Enter cost per day
18000
1.Stall 2.GoldStall 3.PlatinumStall
3
Enter Total Number of Days
5
Enter discount percentage
3
Coupon Yes/No
yes
Name : food plaza
Detail : multicuinse restaurent
Owner : ravi
Cost Per Day : 18000
Your Total Cost 43650

Sample Input and Output 4:

Enter stall name
abc
Enter stall detail
food stall
Enter stall owner name
John
Enter cost per day
120
1.Stall 2.GoldStall 3.PlatinumStall
4
Enter Total Number of Days
5
Invalid choice*/

namespace Inheritance.Problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter stall name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter stall detail");
            string detail = Console.ReadLine();
            Console.WriteLine("Enter stall owner name");
            string owner = Console.ReadLine();
            Console.WriteLine("Enter cost per day");
            double costperday = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1.Stall 2.GoldStall 3.PlatinumStall");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter Total Number of Days");
                    int days = Convert.ToInt32(Console.ReadLine());
                    Stall s = new Stall(name, detail, owner, costperday);
                    Console.WriteLine(s.ToString());
                    Console.WriteLine("Your Total Cost " + s.calculateRent(days));
                    break;
                case 2:
                    Console.WriteLine("Enter Total Number of Days");
                    int days1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter discount percentage");
                    double discount = Convert.ToDouble(Console.ReadLine());
                    GoldStall g = new GoldStall(name, detail, owner, costperday, discount);
                    Console.WriteLine(g.ToString());
                    Console.WriteLine("Your Total Cost " + g.calculateRent(days1));
                    break;
                case 3:
                    Console.WriteLine("Enter Total Number of Days");
                    int day2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter discount percentage");
                    double discount1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Coupon Yes/No");
                    string coupon = Console.ReadLine();
                    PlatinumStall p = new PlatinumStall(name, detail, owner, costperday, discount1, coupon);
                    Console.WriteLine(p.ToString());
                    Console.WriteLine("Your Total Cost " + p.calculateRent(day2));
                    break;
                default:
                    Console.WriteLine("Enter Total Number of Days");
                    int day3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
