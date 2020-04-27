using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Circle : Figure
    {
        public double Radius { get; }

        /// <summary>
        /// Creates circle figure object
        /// </summary>
        /// <param name="r">Circle radius</param>
        public Circle(double r)
        {
            if(Double.IsNegative(r))
            {
                throw new ArgumentException("Radius can't be negative value");
            }
            Radius = r;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
