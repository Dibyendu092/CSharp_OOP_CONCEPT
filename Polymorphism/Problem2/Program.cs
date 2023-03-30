using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program to calculate the cost of the stall based on its type. If the stall type is Gold, the cost will be Rs.100 per square feet. If the stall type is Diamond, the cost will be Rs.150 per square feet and cost of a TV will be Rs.100. If the stall type is Platinum, the cost will be Rs.200 per square feet and if they are using projector it will cost Rs.1000.

The 3 stall types are,

Gold
Diamond
Platinum
[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]

Consider the class named Stall and create the following methods.
Note: Use Overloading concept to define the ComputeCost method.

Method Name	Method Argument Type	Description
ComputeCost	string, int	The order of the parameters are stallType, squareFeet. This method is used to calculate the cost of the Gold stall on cost of Rs.100 per square feet.
ComputeCost	string, int, int	The order of the parameters are stallType, squareFeet, numberOfTV. This method is used to calculate the cost of the Diamond stall on cost of Rs.150 per square feet and cost per TV of Rs.100.
ComputeCost	string, int, bool	The order of the parameters are stallType, squareFeet, projectorAvailability. This method is used to calculate the cost of the Platinum stall on cost of Rs.200 per square feet and if they are using projector it costs Rs.1000.

Consider the class Program and write a Main method to test the above class.

In Main method, get the stall type and its corresponding stall details from the user and calculate the cost.

The link to download the template code is given below
Code Template


Input and Output Format :
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1 :

Enter the stall type
Gold
Enter the square feet
100
Gold costs Rs.10000

Sample Input and Output 2 :

Enter the stall type
Diamond
Enter the square feet
200
Enter the number of TV
1
Diamond costs Rs.30100

Sample Input and Output 3 :

Enter the stall type
Platinum
Enter the square feet
150
Do you need a projector(yes/no)
yes
Platinum costs Rs.31000*/

namespace Polymorphism.Problem2
{
    internal class Program
    {
        /*static void Main(string[] args)
        {
            Console.WriteLine("Enter the stall type");
            string s = Console.ReadLine();
            Console.WriteLine("Enter the square feet");
            int sq = Convert.ToInt32(Console.ReadLine());
            Stall stall = new Stall();
            switch(s)
            {
                case "Gold":
                            stall.ComputeCost(s,sq);
                            break;
                case "Diamond":
                             Console.WriteLine("Enter the number of TV");
                             int k = Convert.ToInt32(Console.ReadLine());
                             stall.ComputeCost(s,sq,k);
                             break;
                case "Platinum":
                             Console.WriteLine("Do you need a projector(yes/no)");
                             string m = Console.ReadLine();
                             if (m == "yes")
                             {
                                 stall.ComputeCost(s, sq, true);
                             }
                             else
                             {
                                 stall.ComputeCost(s, sq, false);
                             }
                             break;
                default:
                    break;



            }
        }*/
    }
}
