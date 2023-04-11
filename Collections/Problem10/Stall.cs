using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.Problem10
{
    internal class Stall
    {
        private string _name;
        private string _owner;
        private string _detail;
        public static List<Stall> ints = new List<Stall>();

        public Stall(string _name , string _owner, string _detail) { 
            this._name = _name;
            this._owner = _owner;
            this._detail = _detail;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Owner
        {
            get { return _owner; }  
            set { _owner = value; }
        }
        public string Detail
        {
            get { return _detail; }
            set
            {
                _detail = value;
            }
        }
        //Fill Your Code Here
        
        public override string ToString()
        {
            //Fill Your Code Here
            
            
            return "Name : " + _name + "\nOwner : " + _owner + "\nDetails : " + _detail;

        }
    }
}
