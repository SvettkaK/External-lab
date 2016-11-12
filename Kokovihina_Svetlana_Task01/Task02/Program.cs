using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = '+';
            int n =0;
            while (ans == '+')
                try
                {
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    if (n <= 0)
                    {
                        throw new System.ArgumentException("n должно быть больше нуля.");
                    }

                    Console.Write("Задание 2:\n");
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 0; j < i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }

                    Console.Write("\nЗадание 3:\n");
                    for (int i = 1, n2 = n; i <= n; i++, n2--)//строки 
                    {
                        for (int j = n2-1; j > 0; j--)//пробелы
                        {
                            Console.Write(" ");
                        }
                        for (int j = 0; j < i+i-1; j++)//звездочки
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }

                    Console.Write("\nЗадание 4:\n");
                    for (int c = 1; c <= n; c++)//"треугольники"
                    {
                        for (int i = 1, n2 = n; i <= c; i++, n2--)//строки
                        {
                            for (int j = n2 - 1; j > 0; j--)//пробелы
                            {
                                Console.Write(" ");
                            }
                            for (int j = 0; j < i + i - 1; j++)//звездочки
                            {
                                Console.Write("*");
                            }
                            Console.Write("\n");
                        }
                    }

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine("Ошибка: {0}", e.Message);
                }
        }
    }
}
