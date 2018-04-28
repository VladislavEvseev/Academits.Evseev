using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle(1, 3);

            Square s1 = new Square(2);

            Square s2 = new Square(5);

            Rectangle r2 = new Rectangle(2, 1);

            Triangle t1 = new Triangle(1, 2, 3, 3, 6, 7);

            Circle c1 = new Circle(5);
            Circle c2 = new Circle(4);

            List<IShape> shapeObjects = new List<IShape>();
            shapeObjects.Add(r1);
            shapeObjects.Add(s1);
            shapeObjects.Add(r2);
            shapeObjects.Add(t1);
            shapeObjects.Add(c1);
            shapeObjects.Add(r1);

            ComparatorArea sortedObjects = new ComparatorArea();
            shapeObjects.Sort(sortedObjects);

            ComparatorPerimeter sortedObjects1 = new ComparatorPerimeter();
            shapeObjects.Sort(sortedObjects1);

            Console.WriteLine("Max area=" + shapeObjects[0].GetArea());
            Console.WriteLine("Second perimeter=" + shapeObjects[1].GetPerimeter());
            Console.ReadKey();
        }
    }
}
