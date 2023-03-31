using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem2
{
    class Square:Shape
    {
        private double _side;

        public double Side
        {
            get { return this._side; }
            set { this._side = value; }
        }

        public Square() { }

        public Square(double _side)
        {
            this._side = _side;
        }
        public override double Perimeter()
        {
            return this._side*4;
        }

    }
}
