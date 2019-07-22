using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Square : Shape
    {
        double Side;

        public Square(double side)
        {
            this.Side = side;
        }

        public override double CalculateArea()
        {
            Area = Side * Side;
            return Area;
        }

    }
}
