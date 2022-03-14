using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Shapes
{
    public abstract class Shape
    {
        public abstract double CalculatePerimeter();

        public abstract double CalculateArea();

        public virtual string Draw()
        {
            return "Drawing ";
        }
    }
}
