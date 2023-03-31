using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem2
{
    internal class Rectangle:Shape
    {
        private double _length;
        private double _width;

        public double Length
        {
            get { return this._length; }
            set { this._length = value; }
        }

        public double Width
        {
            get { return this._width; }
            set { this._width = value; }
        }
        public Rectangle() { }

        public Rectangle(double _length, double _width)
        {
            this._length = _length;
            this._width = _width;
        }
        public override double Perimeter()
        {
            return (this._length+this._width) * 2;
        }

    }
}
