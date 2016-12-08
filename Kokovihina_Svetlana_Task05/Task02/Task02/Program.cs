using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Round//todo вынести в отдельный файл
{
    public int R { get; set; }
    public int X { get; set; }
    public int Y { get; set; }

    public Round()
    {

    }

    public Round(int x, int y, int r)
    {
        R = r;
        X = x;
        Y = y;
    }

    public double Area()
    {
        return Math.PI * R * R;
    }

    public double Length()
    {
        return 2 * Math.PI * R;
    }
    public string info()
    {
        return String.Format("Круг с цетром ({0};{1}) и радиусом R = {2} имеет площадь = {3:0.##} и периметр = {4:0.##}", X, Y, R, Area(), Length());
    }
}
class Ring : Round//todo вынести в отдельный файл
{
    public int R2 { get; set; }

    public Ring()
        :base()
    {

    }
    public Ring (int x, int y, int r1, int r2)
        :base(x, y, r1)
    {
        R2 = r2;
    }

    public new double Area()
    {
        return (Math.PI * R * R) - (Math.PI * R2 * R2);
    }

    public double Perimeter()
    {
        return 2 * Math.PI * R + 2 * Math.PI * R2;
    }

    public new string info()
    {
        return String.Format("Кольцо с цетром ({0};{1}), внешним радиусом R = {2} и внутренним R2 = {3},\n имеет площадь = {4:0.##} и периметр = {5:0.##}", X, Y, R, R2, Area(), Perimeter());
    }
}

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            Round round = new Round(0,0,2);
            Console.WriteLine(round.info()+"\n");

            Ring ring = new Ring();
            Console.Write("Введите внешний радиус кольца: ");
            ring.R = int.Parse(Console.ReadLine());
            Console.Write("Введите внутренний радиус кольца: ");
            ring.R2 = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты центра кольца: \nX: ");
            ring.X = int.Parse(Console.ReadLine());
            Console.Write("Y: ");
            ring.Y = int.Parse(Console.ReadLine());
            Console.WriteLine(ring.info());


            Console.ReadKey();
        }
    }
}
