using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] properties = new string[4] { "None", "Bold", "Italic", "Underline" };
            int[] param = new int[4];

            int p = -1;
            while (p != 0)
                try
                {
                    string result = properties[param[0]];
                    for (int i = 0; i < param.Length; i++)
                    {
                        if (param[i] != 0)
                        {
                            if (result == properties[param[0]]) result = "";

                            result += String.Format("{0}{1}", properties[param[i]], ((i < param.Length - 1 && param[i + 1] != 0) ? ", " : ""));
                        }
                    }

                    Console.Write("Параметры надписи: {0}\nВведите:\n", result);
                    Console.WriteLine("0: Выход");
                    for (int i = 1; i < 4; i++)
                    {
                        Console.WriteLine("{0}: {1}", i, properties[i]);
                    }

                    p = int.Parse(Console.ReadLine());
                    if (p < 0 || p > 3)
                    {
                        throw new System.ArgumentException("Не верно выбрано из списка. Введите номер параметра.");
                    }

                    param[p] = (param[p] == 0) ? p : 0; 

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}\n", ex.Message);
                }
        }
    }
}
