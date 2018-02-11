using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Class1
    {
        private double from;
        private double to;

        public Class1 (double from, double to)
        {
            this.from = from;
            this.to = to;
        }

        public double GetLength()
        {
            return to - from;
        }

        public bool IsInside(double numberInRange)
        {
            return from <= numberInRange && to >= numberInRange;
        }

    }
}
