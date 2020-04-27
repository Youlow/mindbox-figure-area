using System;
using Xunit;


namespace FigureArea.Tests
{
    public class CircleTests
    {
        [Fact]
        public void Ctor_ThrowsAnExeption()
        {
            Assert.Throws<ArgumentException>(() => { new Circle(-1); });
        }

        [Theory]
        [InlineData(2, 12.5664)]
        [InlineData(4.5, 63.6173)]
        public void Area_ReturnsCircleArea(double r, double expected)
        {
            Figure c = new Circle(r);
            var area = c.Area();
            Assert.Equal(expected, area, 4);
        }
    }
}
