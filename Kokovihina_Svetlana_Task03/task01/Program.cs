using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task01
{
    class Program
    {
        static void Main(string[] args)
        {
            char ans = '+';
            while (ans == '+')
            {
                try
                {
                    Console.WriteLine("Введите текст:");

                    char[] separators = { ',', '.', '!', '?', ';', ':', ' ', '-', '(', ')', '\n' };

                    string[] words = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

                    int sum = 0;
                    for (int i = 0; i < words.Length; i++)
                    {
                        sum += words[i].Length;
                    }
                    Console.WriteLine("Средняя длина слова = {0}", sum / words.Length);

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}", ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
