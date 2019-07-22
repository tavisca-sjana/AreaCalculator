using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Rectangle : Shape
    {
        double Length, Width;

        public Rectangle(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }

        public override double CalculateArea()
        {
            Area = Length * Width;
            return Area;
        }

    }
}
