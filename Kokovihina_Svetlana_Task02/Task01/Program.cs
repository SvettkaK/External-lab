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
            int N = 10;
            int[] arr = new int[N];
            Random rand = new Random((int)DateTime.Now.Ticks & 0x0000FFFF);

            for (int i = 0; i < N; i++)
            {
                arr[i] = rand.Next(100);
                Console.Write("[{0}] {1}\n",i,arr[i]);
            }

        }
    }
}
