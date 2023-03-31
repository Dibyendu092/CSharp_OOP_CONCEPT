using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes.Problem2
{
    internal class Circle:Shape
    {
        private double _radius;

        public double Radius
        {
            get { return this._radius; }
            set { this._radius = value; }
        }
        public Circle() { }

        public Circle(double _radius)
        {
            this._radius = _radius;
        }
        public override double Perimeter()
        {
            return 2*Pi*_radius;
        }
    }
}
