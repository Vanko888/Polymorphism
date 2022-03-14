using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public double height;
        public double width;

        public Rectangle(double height, double width)
        {
            this.height = height;
            this.width = width;
        }
        public override double CalculatePerimeter()
        {

            return 2 * height + 2 * width;
        }

        public override double CalculateArea()
        {
            return height * width;
        }

        public override string Draw()
        {
            return base.Draw() + this.GetType().Name;
        }
    }
}
