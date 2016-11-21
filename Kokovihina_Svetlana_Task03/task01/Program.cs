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

                    char[] str = Console.ReadLine().ToCharArray();

                    int countWords = 1;
                    int countLetter = 0;
                    bool endword = false;

                    for (int i = 0; i < str.Length; i++)
                    {
                        if(!Char.IsSeparator(str[i]))
                        {
                            if(i + 1 < str.Length && Char.IsSeparator(str[i + 1]))
                            {
                                endword = true;
                            }
                            else
                            {
                                endword = false;
                            }
                            countLetter++;
                        }
                        else
                        {
                            endword = false;
                        }
                        if(endword) countWords++; 
                    }
                    
                    Console.WriteLine("Средняя длина слова = {0}", countLetter / countWords);

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
