using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates.Problem4
{
    
    internal class Book
    {
        private string _title;
        private string _author;
        private double _amount;
        private int _noOfPages;

        public Book(string _title, string _author, double _amount, int _noOfPages)
        {
            this._title = _title;
            this._author = _author;
            this._amount = _amount;
            this._noOfPages = _noOfPages;
        }
        public string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        public string Author
        {
            get
            {
                return this._author;
            }
            set
            {
                this._author = value;
            }
        }

        public double Amount
        {
            get
            {
                return this._amount;
            }
            set
            {
                this._amount = value;
            }
        }

        public int NoOfPages
        {
            get
            {
                return this._noOfPages;
            }
            set
            {
                this._noOfPages = value;
            }
        }

        public static int CompareBook(Book book1, Book book2)
        {
            //Fill your code here
            string str1 = book1.Title;
            string str2 = book2.Title;
            if (str1.Equals(str2)){
                return 0;
            }
            else
            {
                return 1;
            }
        
        }
        
    }
}
