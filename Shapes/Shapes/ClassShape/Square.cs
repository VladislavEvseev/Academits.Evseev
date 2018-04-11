using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Square : IShape
    {
        private double width;

        public Square(double width)
        {
            this.width = width;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return width;
        }

        public double GetArea()
        {
            return Math.Pow(width, 2);
        }

        public double GetPerimeter()
        {
            return (width * 4);
        }
    }
}
