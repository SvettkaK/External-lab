using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Figure
{
    public int X { get; set; }
    public int Y { get; set; }

    public Figure()
    {
        Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);
        X = rand.Next(20) - 10;
        Y = rand.Next(20) - 10;
    }
    public Figure(int centerX, int centerY)
    {
        X = centerX;
        Y = centerY;
    }

    public double Length()
    {
        return 0;
    }

    public string Info()
    {
        return String.Format("Фигура не выбрана");
    }

    public double Area()
    {
        return 0;
    }
}

/// <summary>
/// Линия
/// </summary>
class Line : Figure
{
    public int X1 { get; set; }
    public int Y1 { get; set; }
    public int X2 { get; set; }
    public int Y2 { get; set; }


    public Line() : base() { }
    /// <summary>
    /// Инициализация фигуры Линия
    /// </summary>
    /// <param name="x1">Координата Х начальной точки</param>
    /// <param name="y1">Координата У начальной точки</param>
    /// <param name="x2">Координата Х конечной точки</param>
    /// <param name="y2">Координата У конечной точки</param>
    public Line(int x1, int y1, int x2, int y2)
        :base()
    {
        X1 = x1;
        Y1 = y1;
        X2 = x2;
        Y2 = y2;
    }

    public new double Length()
    {
        return Math.Sqrt( Math.Pow(X2-X1,2) + Math.Pow(Y2 - Y1, 2));
    }

    public new string Info()
    {
        return String.Format("Линия. Начало:({0};{1}), Конец:({2};{3}), Длина: {4:0,##}", X1, Y1, X2,Y2, Length());
    }
    
}

/// <summary>
/// Окружночть
/// </summary>
class Circle : Figure
{
    public int Radius { get; set; }

    public Circle() : base() { }
    public Circle(int x, int y, int r)
        :base(x, y)
    {
        Radius = r;
    }

    public new double Length()
    {
        return 2* Radius;
    }

    public new string Info()
    {
        return String.Format("Окружность. Центр:({0};{1}), Радиус:{2}, Длина окружности: {3:0,##}", X, Y, Radius, Length());
    }
}

/// <summary>
/// Пямоугольник
/// </summary>
class Reсtangle : Figure
{
    public int SideA { get; set; }
    public int SideB { get; set; }

    public Reсtangle() : base() { }
    /// <summary>
    /// Инициализация фигуры Пямоугольник
    /// </summary>
    /// <param name="x">Координата Х центра фигуры</param>
    /// <param name="y">Координата У центра фигуры</param>
    /// <param name="a">Сторона А</param>
    /// <param name="b">Сторона B</param>
    public Reсtangle(int x, int y, int a, int b)
        :base(x, y)
    {
        SideA = a;
        SideB = b;
    }

    public new double Length()
    {
        return 2 * (SideA + SideB);
    }

    public new double Area()
    {
        return SideA * SideB;
    }

    public new string Info()
    {
        return String.Format("Пямоугольник. Центр:({0};{1}), Сторона А:{2}, Сторона B:{3}, Периметр: {4:0,##}, Площадь:{5:0,##}", X, Y, SideA, SideB, Length(), Area());
    }
}

/// <summary>
/// Круг
/// </summary>
class Round : Figure
{
    public int Radius { get; set; }

    public Round() : base() { }
    public Round(int x, int y, int r)
        :base(x, y)
    {
        Radius = r;
    }

    public new double Length()
    {
        return 2 * Radius;
    }

    public new double Area()
    {
        return Math.PI * Radius * Radius;
    }

    public new string Info()
    {
        return String.Format("Круг. Центр:({0};{1}), Радиус:{2}, Длина круга: {3:0,##}, Площадь: {4:0,##}", X, Y, Radius, Length(), Area());
    }
}

/// <summary>
/// Кольцо
/// </summary>
class Ring : Figure
{
    public int Radius1 { get; set; }
    public int Radius2 { get; set; }

    public Ring() : base() { }
    /// <summary>
    /// Инициализация фигуры Кольцо
    /// </summary>
    /// <param name="x">Координата Х центра фигуры</param>
    /// <param name="y">Координата У центра фигуры</param>
    /// <param name="r1">Внешний радиус кольца</param>
    /// <param name="r2">Внутренний радиус кольца</param>
    public Ring(int x, int y, int r1, int r2)
        :base(x, y)
    {
        Radius1 = r1;
        Radius1 = r2;
    }

    public new double Length()
    {
        return 2 * Radius1 + 2 * Radius2;
    }

    public new double Area()
    {
        return Math.PI * Radius1 * Radius1 - Math.PI * Radius2 * Radius2;
    }

    public new string Info()
    {
        return String.Format("Кольцо. Центр:({0};{1}), Радиус внешний:{2}, Радиус внешний:{3}, Длина: {4:0,##}, Площадь:{5:0,##}", X, Y, Radius1, Radius2, Length(), Area());
    }
}

namespace Task03
{
    class Program
    {
        bool replay()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
                return false;
            }
            else
            {
                Console.WriteLine("\n");
                return true;
            }
        }
        static void Main(string[] args)
        {
            Program pr = new Program();
            do
                try
                {
                    Console.WriteLine("Выберите фигуру:\n1: Линия\n2: Окружность\n3: Прямоугольник\n4: Круг\n5: Кольцо");
                    int figure = int.Parse(Console.ReadLine());
                    
                    if (figure == 1)
                    {
                        Line f = new Line(2, 5, 1, 4);
                        Console.WriteLine(f.Info()); 
                    }
                    else if (figure == 2)
                    {
                        Circle f = new Circle(0, 0, 2);
                        Console.WriteLine(f.Info());
                    }
                    else if (figure == 3)
                    {
                        Reсtangle f = new Reсtangle(0, 0, 2, 3);
                        Console.WriteLine(f.Info());
                    }
                    else if (figure == 4)
                    {
                        Round f = new Round(0, 0, 3);
                        Console.WriteLine(f.Info());
                    }
                    else if (figure == 5)
                    {
                        Ring f = new Ring(0, 0, 5, 2);
                        Console.WriteLine(f.Info());
                    }
                    Console.WriteLine("Повторить? [Нажмите любую кнопку для продолжения или Esc для выхода]");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ощибка: {0}", ex.Message);
                }
            while (pr.replay() == true);
        }
    }
}
