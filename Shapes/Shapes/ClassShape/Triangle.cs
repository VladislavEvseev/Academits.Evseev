using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : IShape
    {
        private double a1;
        private double y1;
        private double a2;
        private double y2;
        private double a3;
        private double y3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.a1 = x1;
            this.y1 = y1;
            this.a2 = x2;
            this.y2 = y2;
            this.a3 = x3;
            this.y3 = y3;
        }

        public double GetWidth()
        {
            return Math.Max(Math.Max(a3, a1), a2) - Math.Min(Math.Min(a3, a1), a2);
        }

        public double GetHeight()
        {
            return Math.Max(Math.Max(y3, y1), y2) - Math.Min(Math.Min(y3, y1), y2);
        }

        public double GetArea()
        {
            return 0.5 * ((a1 - a3) * (y2 - y3) + (a2 - a3) * (y1 - y3));
        }

        private static double GetLengthOfSideOfTriangle(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        }

        public double GetPerimeter()
        {
            return GetLengthOfSideOfTriangle(a1, y1, a2, y2) + GetLengthOfSideOfTriangle(a2, y2, a3, y3) + GetLengthOfSideOfTriangle(a1, y1, a3, y3);
        }
    }
}
