using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace task02
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
                    Console.Write("Введите первую строку: ");
                    string str1 = Console.ReadLine();
                    Console.Write("Введите вторую строку: ");
                    string str2 = Console.ReadLine();

                    StringBuilder sb = new StringBuilder();

                    for (int i = 0; i < str1.Length; i++)
                    {
                        if (str2.Contains(str1[i]))
                        {
                            sb.Append(str1[i]).Append(str1[i]);
                        }
                        else
                        {
                            sb.Append(str1[i]);
                        }
                    }
                    Console.WriteLine("Результирующая строка: {0}", sb);

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
