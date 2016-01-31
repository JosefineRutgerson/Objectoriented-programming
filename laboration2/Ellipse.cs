using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboration2
{
    public class Ellipse : Shape
    {
        public Ellipse(double l, double w) : base(l, w)
        {
            
        }


        public override double Area
        {
            get
            {
                return Math.PI * (Length / 2) * (Width / 2);
            }
        }

        public override double Perimeter
        {
            get
            {
                return 2 * Math.PI * Math.Sqrt(((Length / 2) * (Length / 2) + (Width / 2) * (Width / 2)) / 2);
            }
        }

        
        }
    }
