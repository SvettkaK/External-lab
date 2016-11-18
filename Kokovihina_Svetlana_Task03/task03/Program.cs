using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            StringBuilder sb = new StringBuilder();
            int N = 100;
            
            var sw = new Stopwatch();

            sw.Start();
            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
            sw.Stop();
            Console.WriteLine("string:");
            Console.WriteLine("Затрачено милисекунд: {0}", sw.Elapsed.TotalMilliseconds);

            sw.Restart();
            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
            sw.Stop();
            Console.WriteLine("\nStringBuilder:");
            Console.WriteLine("Затрачено милисекунд: {0}", sw.Elapsed.TotalMilliseconds);

            Console.ReadKey();
        }
    }
}
