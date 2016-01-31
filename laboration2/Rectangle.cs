using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboration2
{
    public class Rectangle : Shape
    {

        public Rectangle(double l, double w) : base(l, w) { }


        public override double Area
        {
            get
            {
                return Length * Width;
            }
        }

        public override double Perimeter
        {
            get
            {
                return (2 * Length) + (2 * Width);
            }
        }

        
    }
}