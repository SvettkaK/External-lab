using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Triangle
    {
        public int a;
        public int b;
        public int c;

        public Triangle(int A, int B, int C)
        {
            a = A;
            b = B;
            c = C;
        }

        public double Area()
        {
            return Perimeter() / 2;
        }

        public double Perimeter()
        {
            return a + b + c;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стороны треугольника:");
            Triangle tr = new Triangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
            Console.WriteLine("Периметр = {0}", tr.Perimeter());
            Console.WriteLine("Площадь = {0:0.##}", tr.Area());

            Console.ReadKey();
        }
    }
}
