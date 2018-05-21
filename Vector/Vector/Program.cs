using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] arrayVectors = { 21, 17, 33, 41, 2, 3, 6, 9 };
            int n = 0;
            for (int i = 0; i < arrayVectors.Length; i++)
            {
                n++;
            }

            Vector vector = new Vector(arrayVectors);
            Vector vector1 = new Vector(vector);
            Vector vector2 = new Vector(n);
            Vector vector3 = new Vector(n, arrayVectors);

            Console.WriteLine("Размер Вектора=" + vector1.GetSize());

            double[] arrayVectors1 = { 21, 17, 33, 41, 2, 3, 6, 9 };
            Vector vector4 = new Vector(arrayVectors1);
            Console.WriteLine("Equals=" + vector1.Equals(vector4));

            Console.WriteLine("Сумма векторов=" + vector1.GetAddition(vector4));
            Console.WriteLine("Разница векторов=" + vector.GetDifference(vector4));

            double scalar = 3;
            Console.WriteLine("Скалярное умножение векторов=" + vector.GetMultipliedByScalar(scalar));

            Console.WriteLine("Разворот векторов=" + vector.GetRotation());
            Console.WriteLine("Длинна векторов=" + vector.GetLength());

            Console.WriteLine(vector.GetComponent(2));
            vector.SetComponent(2, 4);

            Console.WriteLine("Статическая сумма векторов=" + Vector.GetAdditionVectors(vector1, vector4));
            Console.WriteLine("Статическая разница векторов=" + Vector.GetDifferenceVectors(vector1, vector4));
            Console.WriteLine("Скалярное статическое умножение векторов=" + Vector.GetVectorMultipliedByAnotherVector(vector1, vector4));
            Console.Read();
        }
    }
}