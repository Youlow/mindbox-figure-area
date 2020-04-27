using System;
using System.Collections.Generic;
using Xunit;

namespace FigureArea.Tests
{
    public class TriangleTests
    {
        [Theory]
        [InlineData(-1.0, 1.0, 2.0)]
        [InlineData(1.0, 2.0, 3.01)]
        [InlineData(10.0, 5.0, 3.0)]
        public void Ctor_ThrowsAnExeption(double a, double b, double c)
        {
            Assert.Throws<ArgumentException>(() => { new Triangle(a, b, c); });
        }

        [Theory]
        [InlineData(3.0, 5.0, 4.0, 6.0)]
        [InlineData(3.0, 7.0, 8.0, 10.3923)]
        public void Area_ReturnsTriangleArea(double a, double b, double c, double expected)
        {
            Figure t = new Triangle(a, b, c);
            var area = t.Area();
            Assert.Equal(expected, area, 4);
        }

        [Theory]
        [InlineData(3.0, 5.0, 4.0, true)]
        [InlineData(3.0, 7.0, 8.0, false)]
        public void IsRightTriangle_ReturnsTrueOrFalse(double a, double b, double c, bool expected)
        {
            Triangle t = new Triangle(a, b, c);
            var isRight = t.IsRightTriangle();
            Assert.Equal(expected, isRight);
        }

    }
}
