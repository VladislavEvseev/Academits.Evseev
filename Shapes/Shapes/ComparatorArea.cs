﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class ComparatorArea : IComparer<IShape>
    {
        public int Compare(IShape two, IShape one)
        {
            return one.GetArea().CompareTo(two.GetArea());
        }
    }
}