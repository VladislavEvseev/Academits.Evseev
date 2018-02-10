using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Range
{
    class Program
    {

        static void Main(string[] args)
        {
            Class1 r = new Class1(2, 22);

            Console.WriteLine("Length=" + r.GetLength());

            double numberInRange = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(r.IsInside(numberInRange));
            Console.ReadKey();
        }

    }
}
