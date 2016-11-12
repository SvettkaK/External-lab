using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace queue
{
    public struct MyQueue<T>
    {
        public T[] queue;
        public int began,end;

        public MyQueue(int size): this()
        {
            queue = new T[size];
        }

        public void Enqueue(T x)
        {
            //вставить x в конец очереди
            queue[end++] = x;
        }

        public T Dequeue()
        {
            //извлечь элемент из начала очереди
            ++began;
            if (began == queue.Length)
            {
                throw new System.ArgumentException("Очередь пуста");
            }
            T x = queue[began];
            return x;
        }

        public T Front()
        {
            //прочесть первый элемент очереди не извлекая его
            return queue[began];
        }

    };

    class Program
    {
        static void Main(string[] args)
        {
            char ans = '+';
            while (ans == '+')
                try
                {
                    Console.Write("Введите размер очереди: ");
                    int N = int.Parse(Console.ReadLine());

                    MyQueue<int> qu = new MyQueue<int>(N);

                    int i = 1;
                    Console.WriteLine("Заполните элементами:");
                    while (qu.end < N)
                    {
                        Console.Write("{0}:", i++);
                        qu.Enqueue(int.Parse(Console.ReadLine()));

                    }
                    Console.WriteLine("Первый элемент в очереди: {0}", qu.Front());
                    Console.WriteLine("Количество элементов в очереди: {0}\n", qu.end - qu.began);

                    for(int j = 1; j < N; j++)
                    {
                        Console.WriteLine("Результат метода Dequeue() запуск №{0}: {1}", j, qu.Dequeue());
                        Console.WriteLine("Первый элемент в очереди: {0}",qu.Front());
                        Console.WriteLine("Количество элементов в очереди: {0}\n", qu.end - qu.began);
                    }

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}", ex);//.Message
                }
        }
    }
}
