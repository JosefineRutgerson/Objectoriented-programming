using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace laboration2
{
    public class ResizableRectangle : Rectangle, IResizable
    {
        public ResizableRectangle(double l, double w) : base(l, w) { }

        public void resize(int procent)
        {
            Length = (Length * (procent / 100.0));
            Width = (Width * (procent / 100.0));
        }
    }

    
}