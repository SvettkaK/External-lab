using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3;
            int[,,] arr = new int[N,N,N];
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            Console.Write("Исходный массив:\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        arr[i,j,k] = rand.Next(200) - 100;
                        Console.Write("[{0},{1},{2}] {3}\n", i, j, k, arr[i, j, k]);
                    }
                }
                
            }

            Console.Write("Обработанный массив:\n");
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    for (int k = 0; k < N; k++)
                    {
                        if (arr[i, j, k] > 0) arr[i, j, k] = 0;
                        Console.Write("[{0},{1},{2}] {3}\n", i, j, k, arr[i, j, k]);
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
