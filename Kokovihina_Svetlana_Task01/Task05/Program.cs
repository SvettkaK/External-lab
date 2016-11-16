using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.Write("Сумма чисел меньше 1000, кратных 3,или 5  равна {0} \n", sum);
            Console.ReadKey(); //todo не забываем про то, что консоль автоматически закрывается
        }
    }
}
