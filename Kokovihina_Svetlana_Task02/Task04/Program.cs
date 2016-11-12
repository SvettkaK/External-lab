using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 3, sum = 0;
            int[,] arr = new int[N,N];
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    arr[i,j] = rand.Next(200) - 100;
                    if((i+j)%2==0)sum += arr[i,j];
                    Console.Write("[{0},{1}] {2}\n", i, j, arr[i, j]);
                }
            }
            Console.Write("Сумма элементов = {0}\n", sum);
        }
    }
}
