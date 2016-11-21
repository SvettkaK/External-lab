using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Написать класс Round, задающий круг с указанными координатами центра,
 * радиусом, а также свойствами, позволяющими узнать длину
 * описанной окружности и площадь круга. Обеспечить нахождение 
 * объекта в заведомо корректном состоянии.
 * Написать программу, демонстрирующую использование данного круга
*/

namespace Task01
{
   class Round
    {
        public int r;
        public int x = 0;
        public int y = 0;

        public double Area()
        {
            return Math.PI * r * r;
        }

        public double Length()
        {
            return 2 * Math.PI * r;
        }
        public string info()
        {
            return String.Format("Круг с цетром ({0};{1}) и радиусом R = {2} имеет площадь = {3:0.##} и периметр = {4:0.##}", x, y, r, Area(), Length());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round();

            Console.Write("Введите радиус окружности: ");
            round.r = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты центра окружности: \nX: ");
            round.x = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            round.y = int.Parse(Console.ReadLine());
            Console.WriteLine("Площадь окружности ={0:0.##}", round.Area());
            Console.WriteLine("Длина окружности ={0:0.##}", round.Length());
            Console.WriteLine(round.info());


            Console.ReadKey();
        }
    }
}
