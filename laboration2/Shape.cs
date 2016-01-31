using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboration2
{
    public abstract class Shape : IComparable<Shape>
    {
        private double _length;
        private double _width;

        
        protected Shape(double l, double w)
        {
           _length = l;
           _width = w;
        }

       

        public double Length
        {
            get
            {
                return _length;
            }

            set
            {
                _length = value;
            }
        }

        public double Width
        {
            get
            {
                return _width;
            }

            set
            {
                _width = value;
            }
        }

        public abstract double Area { get; }

        public abstract double Perimeter {get;}

        public override string ToString()
        {
            return "Length : " + Length + "\nWidth : " + Width + "\nOmkrets : " + Perimeter + "\nArea : " + Area;
        }

        public int CompareTo(Shape other)
        {
            if (this.Area == other.Area)
            {
                return 0;
            }
            if (this.Area > other.Area)
            {
                return 1;
            }
            else
            {
                return -1;

            }
        }
    }
}