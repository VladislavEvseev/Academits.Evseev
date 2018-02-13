using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Range
    {
        public double From { get; set; }
        public double To { get; set; }

        public Range (double from, double to)
        {
            From = from;
            To = to;
        }

        public double Length
        {
           get
           {
                return From - To; ;

           }
        }

        public bool IsInside(double numberInRange)
        {
            return From <= numberInRange && To >= numberInRange;
        }

    }
}
