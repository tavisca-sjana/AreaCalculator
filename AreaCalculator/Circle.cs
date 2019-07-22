using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculator
{
    public class Circle : Shape
    {
        double Radius;

        public Circle(double radius)
        {
            this.Radius = radius;
        }


        public override double CalculateArea()
        {
            Area = 3.14 * Radius * Radius;
            return Area;
        }


    }
}
