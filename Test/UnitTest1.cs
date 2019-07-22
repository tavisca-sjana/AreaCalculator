using System;
using Xunit;
using AreaCalculator;

namespace Test
{
    public class UnitTest1
    {
        [Fact]
        public void CircleAreaPassingTest()
        {
            Circle circle = new Circle(3);
            Assert.True(Math.Round(circle.CalculateArea(), 2).Equals(28.26));
        }

        [Fact]
        public void CircleAreaFailingTest()
        {
            Circle circle = new Circle(3);
            Assert.False(Math.Round(circle.CalculateArea(), 2).Equals(25.26));

        }

        [Fact]
        public void RectangleAreaPassingTest()
        {
            Rectangle rect = new Rectangle(2,5);
            Assert.True(Math.Round(rect.CalculateArea(), 1).Equals(2*5));
        }
        [Fact]
        public void RectangleAreaFailingTest()
        {
            Rectangle rect = new Rectangle(2, 5);
            Assert.False(Math.Round(rect.CalculateArea(), 1).Equals(5.0));

        }

        [Fact]

        public void TriangleAreaPassingTest()
        {
            Triangle triangle = new Triangle(4, 4);
            Assert.True(Math.Round(triangle.CalculateArea(), 1).Equals(8.0));
        }

        [Fact]

        public void TriangleAreaFailingTest()
        {
            Triangle triangle = new Triangle(4, 4);
            Assert.False(Math.Round(triangle.CalculateArea(), 1).Equals(9.0));


        }

        [Fact]
        public void SquareAreaPassingTest()
        {
            Square sq = new Square(2);
            Assert.True(Math.Round(sq.CalculateArea(), 1).Equals(4));
        }
        
        [Fact]
        public void SquareAreaFailingTest()
        {
            Square sq = new Square(2);
            Assert.False(Math.Round(sq.CalculateArea(), 1).Equals(5.0));

        }



    }
}
