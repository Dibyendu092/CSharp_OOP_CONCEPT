﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem4
{
   
    internal class Program
    {
        public delegate int CompareBookDelegate(Book b1, Book b2);
       /* static void Main(string[] args)
        {
            Console.WriteLine("Enter the book 1 details");
            Console.WriteLine("Enter the title");
            string title1 = Console.ReadLine();
            Console.WriteLine("Enter the author");
            string author1 = Console.ReadLine();
            Console.WriteLine("Enter the price");
            double price1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the noOfPages");
            int noOfPages1 = Convert.ToInt32(Console.ReadLine());
            Book b1 = new Book(title1, author1, price1, noOfPages1);

            Console.WriteLine("Enter the book 2 details");
            Console.WriteLine("Enter the title");
            string title2 = Console.ReadLine();
            Console.WriteLine("Enter the author");
            string author2 = Console.ReadLine();
            Console.WriteLine("Enter the price");
            double price2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the noOfPages");
            int noOfPages2 = Convert.ToInt32(Console.ReadLine());
            Book b2 = new Book(title2, author2, price2, noOfPages2);


            CompareBookDelegate compareBookDelegate = Book.CompareBook;
            if(compareBookDelegate.Invoke(b1, b2) == 0)
            {
                Console.WriteLine("Books are equal");
            }
            else
            {
                Console.WriteLine("Books are not equal");
            }
        }
       */
        //Fill your code here
    }
}