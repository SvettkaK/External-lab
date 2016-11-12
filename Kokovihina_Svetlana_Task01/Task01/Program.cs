using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = '+';
            while (ans == '+')
                try
                {
                    Console.WriteLine("Введите длины сторон прямоугольника:");

                    Console.Write("a = ");
                    int a = int.Parse(Console.ReadLine());
                    if (a <= 0)
                    {
                        throw new System.ArgumentException("a не должнa быть меньше или равна 0.\n");
                    }

                    Console.Write("b = ");
                    int b = int.Parse(Console.ReadLine());
                    if (b <= 0)
                    {
                        throw new System.ArgumentException("b не должнa быть меньше или равна 0.\n");
                    }

                    Console.Write("\nПлощадь прямоугольника равна {0}\n", a * b);

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}", ex.Message);
                }
        }
    }
}
