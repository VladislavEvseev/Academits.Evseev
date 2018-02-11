using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Range
    {
        private double from;
        private double to;

        public Range (double from, double to)
        {
            this.from = from;
            this.to = to;
        }

        public double Propereties
        {
            get;
            set;
        }

        public double GetLength
        {
           get
           {
                return from - to; ;

           }
        }

        public bool IsInside(double numberInRange)
        {
            return from <= numberInRange && to >= numberInRange;
        }

    }
}
