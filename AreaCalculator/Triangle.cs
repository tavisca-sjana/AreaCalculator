using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Triangle : Shape
    {
        double Base;
        double Height;

        public Triangle(double _base, double height)
        {
            this.Base = _base;
            this.Height = height;
        }

        public override double CalculateArea()
        {
            Area = 0.5 * Base * Height;
            return Area;
        }

    }
}
