using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 St. William Convent organizes a project exhibition "Innovative Minds" every year with an objective to provide the platform and unleash the potential of the students by showcasing their innovative projects. Pasha is a smart, high school student and was eager to participate in the fair for the first time.

After a lot of ground work, she decided her project and set out to design the same. Her project requirement was to design an advanced calculator that has a fraction feature that will simplify fractions. The project will accept a non-negative integer as a numerator and a positive integer as a denominator and outputs the fraction in simplest form. That is, the fraction cannot be reduced any further, and the numerator will be less than the denominator.

Help Pasha to program her advanced calculator and succeed in her first ever project presentation. You can assume that all input numerators and denominators will produce valid fractions.

 

[Note :  Strictly adhere to the object-oriented specifications given as a part of the problem statement.
Follow the naming conventions as mentioned. Create separate classes in separate files.]


Consider a class named Program and define the following method.

Method Name	
Description
static void PrintValue(int num,int den)	This method should display the fraction in simplest form.
 

Write a main method to test the above class.

In the Main method, obtain input from the user in the console and call the PrintValue method present in the class and display the output.
 

 
The link to download the template code is given below
Code Template
 
Input Format:

First line of the input is a non-negative integer which is the numerator in the fraction.
Second line of the input is a positive integer which is the denominator in the fraction.

Output Format:

Output the simplified form of the fraction in a single line.
Refer sample input and output for formatting specifications.

[All text in bold corresponds to the input and the rest corresponds to output.]

Sample Input and Output 1:

28
7
4

Sample Input and Output 2:

13
5
2 3/5

 

Sample Input and Output 3:

55
10
5 1/2

 

Sample Input and Output 4:

0
7
0

 

Sample Input and Output 5:

1000
210
4 16/21

 

Sample Input and Output 6:

42
44
21/22
 */

namespace Getter_Setter_Practise_Problem
{

    internal class Problem2
    {
        public int gcd(int a, int b)
        {
            int result = Math.Min(a, b); // Find Minimum of a and b
            while (result > 0)
            {
                if (a % result == 0 && b % result == 0)
                {
                    break;
                }
                result--;
            }
            return result; // return gcd of a and b
        }
        static void PrintValue(int num, int den)
        {
            if(num == 0 || den == 0)
            {
                Console.WriteLine(0);
                return;

            }
            Problem2 p=new Problem2();
            int m = p.gcd(num, den);
            num /= m;
            den /= m;

            if(num < den)
            {
                Console.WriteLine($"{num}/{den}");
                
            }
            else
            {
                int k = num / den;
                num %= den;
                if(num == 0)
                {
                    Console.WriteLine(k);
                }
                else
                {
                    Console.WriteLine($"{k} {num}/{den}");
                }
                
            }

        }
         static void Main(string[] args)
        {

            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            PrintValue(x, y);
        }
    }
}
