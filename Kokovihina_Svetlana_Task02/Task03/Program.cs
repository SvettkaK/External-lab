using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 10, sum=0;
            int[] arr = new int[N];
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(200)-100;
                if (arr[i] > 0) sum += arr[i];
                Console.Write("[{0}] {1}\n", i, arr[i]);
            }
            Console.Write("Сумма неотрицательных элементов = {0}\n", sum);
            Console.ReadKey();
        }
    }
}
