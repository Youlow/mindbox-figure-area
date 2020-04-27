using System;
using System.Collections.Generic;
using System.Text;

namespace FigureArea
{
    public class Triangle : Figure
    {
        /// <summary>
        /// Calculation precision
        /// </summary>
        public static double Epsilon { get; set; } = 0.00001;
        public double A { get; }
        public double B { get; }
        public double C { get; }

        /// <summary>
        /// Creates triangle figure object
        /// </summary>
        /// <param name="a">Length of first side of a triangle</param>
        /// <param name="b">Length of second side of a triangle</param>
        /// <param name="c">Length of third side of a triangle</param>
        public Triangle(double a, double b, double c)
        {
            if(Double.IsNegative(a) || Double.IsNegative(b) || Double.IsNegative(c))
            {
                throw new ArgumentException("Side length can't be negative value");
            }
            if(!(a < b + c + Epsilon && b < a + c + Epsilon && c < a + b + Epsilon))
            {
                throw new ArgumentException("It's not a triangle sides");
            }
            A = a;
            B = b;
            C = c;
        }

        public override double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));

        }
        
        /// <summary>
        /// Returns true if the figure is a right triangle
        /// </summary>
        public bool IsRightTriangle()
        {
            double hyp;
            double cath1, cath2;
            if (A + Epsilon > B && A + Epsilon > C)
            {
                hyp = A;
                cath1 = B;
                cath2 = C;
            }
            else if (B + Epsilon > A && B + Epsilon > C)
            {
                hyp = B;
                cath1 = A;
                cath2 = C;
            }
            else
            {
                hyp = C;
                cath1 = A;
                cath2 = B;
            }
            return (Math.Abs(hyp * hyp - cath1 * cath1 - cath2 * cath2) < Epsilon);
            
        }
    }
}
