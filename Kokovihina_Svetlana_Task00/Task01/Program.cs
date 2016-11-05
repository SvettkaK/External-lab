using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01
{
    class Vector
    {
        public double x, y;//координаты вектора
        public Vector(double Ax, double Ay, double Bx, double By)
        {
            x = Bx - Ax;
            y = By - Ay;
        }

        public double Length()//длина вектора
        {
            return Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
        }

        public double scalarProduct(Vector b)//скалярное произведение векторов
        {
            return this.x * b.x + this.y * b.y;
        }

        public double AngleBetwen(Vector b)//угол между векторами
        {
            return Math.Acos(this.scalarProduct(b) / (this.Length() * b.Length())) * 180 / Math.PI;
        }
    };


    class Program
    {
        public string belongs(double x, double y, string g)
        {
            bool res = false;
            //a.  
            if (g == "a" || g == "f")
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1)
                {
                    res = true;
                }
            }

            //б.
            if (g == "б" || g == ",")
            {
                if (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && Math.Pow(x, 2) + Math.Pow(y, 2) >= Math.Pow(0.5, 2))
                {
                    res = true;
                }
            }

            //в.
            if (g == "в" || g == "d")
            {
                if (x <= 1 && x >= -1 && y <= 1 && y >= -1)
                {
                    res = true;
                }
            }

            //г.  
            if (g == "г" || g == "u")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, 1, 0);
                Vector c = new Vector(x, y, 0, -1);
                Vector d = new Vector(x, y, -1, 0);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(d) + d.AngleBetwen(a));

                if (Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180)
                {
                    res = true;
                }
            }
            //д.  
            if (g == "д" || g == "l")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, 0.5, 0);
                Vector c = new Vector(x, y, 0, -1);
                Vector d = new Vector(x, y, -0.5, 0);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(d) + d.AngleBetwen(a));

                if (Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180)
                {
                    res = true;
                }
            }
            //е.  
            if (g == "е" || g == "t")
            {
                Vector a = new Vector(x, y, 0, 1);
                Vector b = new Vector(x, y, -2, 0);
                Vector c = new Vector(x, y, 0, -1);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a));

                if (Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180 || (Math.Pow(x, 2) + Math.Pow(y, 2) <= 1 && x >= 0))
                {
                    res = true;
                }
            }

            //ж.  
            if (g == "ж" || g == ";")
            {
                Vector a = new Vector(x, y, 0, 2);
                Vector b = new Vector(x, y, -1, -1);
                Vector c = new Vector(x, y, 1, -1);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a));

                if (Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180)
                {
                    res = true;
                }
            }

            //з.  
            if (g == "з" || g == "p")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, 0, 0);
                Vector c = new Vector(x, y, 1, 1);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a));

                if (x <= 1 && x >= -1 && y <= 0 && y >= -2 && (Math.Abs(sumAngle) != 360 || Math.Abs(sumAngle) != 180))
                {
                    res = true;
                }
            }

            //и.  
            if (g == "и" || g == "b")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, -2, -1);
                Vector c = new Vector(x, y, 1, 0);
                Vector d = new Vector(x, y, 0, 0);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a));
                double sumAngle2 = (a.AngleBetwen(d) + d.AngleBetwen(c) + c.AngleBetwen(a));

                if ((Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180) && (Math.Abs(sumAngle2) != 360 && Math.Abs(sumAngle2) != 180))
                {
                    res = true;
                }
            }

            //к.  
            if (g == "к" || g == "r")
            {
                Vector a = new Vector(x, y, -1, 1);
                Vector b = new Vector(x, y, 0, 0);
                Vector c = new Vector(x, y, 1, 1);

                double sumAngle = (a.AngleBetwen(b) + b.AngleBetwen(c) + c.AngleBetwen(a));

                if ((Math.Abs(sumAngle) == 360 || Math.Abs(sumAngle) == 180) || (y >= 1))
                {
                    res = true;
                }
            }

            return "Точка (" + x + ";" + y + ") " + (res == true ? "принадлежит" : "НЕ принадлежит") + " области " + g;
        }

        static void Main(string[] args)
        {
            Program obj = new Program();
            char ans = '+';
            do
                try
                {

                    Console.WriteLine("Введите координаты точки:");
                    Console.Write("x: ");
                    Double x = Double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    Double y = Double.Parse(Console.ReadLine());

                    Console.WriteLine("Выберите фигуру(а-к):");
                    string graph = Console.ReadLine();

                    Console.WriteLine(obj.belongs(x, y, graph));

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n");
                }
                catch
                {
                    Console.WriteLine("Введены недопустимые символы. Повторите попытку...\n");
                    ans = '+';
                }
            while (ans == '+');
        }


    }
}

