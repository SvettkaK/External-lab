using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace stack
{
    public struct MyStack<T>
    {
        public T[] stack;
        public int Count;

        public MyStack(int size):this()
        {
            stack = new T[size];
        }

        public void Push(T x)
        {
            //поместить элемент x на вершину стека
            stack[Count++] = x;
        }

        public T Pop()
        {
            //вытолкнуть элемент из вершины стека
            if (this.Empty())
            {
                stack[Count] = default(T);
                throw new System.ArgumentException("Стек пуст");
            }
            T x = stack[--Count];
            return x;
        }

        public T Get()
        {
            //получить вершину стека без выталкивания
            T n;
            if (this.Empty() == false)
            {
                n = stack[Count - 1];
            }
            else
            {
                n = stack[Count];
            }
            return n;
        }

        public bool Empty()
        {
            //возвращает True, если стек пуст
            return (Count == 0) ? true : false;
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
                    Console.Write("Введите размер стека: ");
                    int N = int.Parse(Console.ReadLine());

                    MyStack<int> st = new MyStack<int>(N);
                    
                    int i = 1;
                    Console.WriteLine("Заполните элементами:\n");
                    while (st.Count < N)
                    {
                        Console.Write("{0}:", i++);
                        st.Push(int.Parse(Console.ReadLine()));
                        
                    }
                    Console.WriteLine("Последний: {0}",st.Get());
                    Console.WriteLine("Count: {0}", st.Count);
                    Console.WriteLine("Стек Пуст?: {0}\n", st.Empty());

                    i = N;
                    while (st.Count > 0)
                    {
                        Console.WriteLine("{0}: {1}",i--,st.Pop());
                    }
                    Console.WriteLine("Последний: {0}", st.Get());
                    Console.WriteLine("Count: {0}", st.Count);
                    Console.WriteLine("Стек Пуст?: {0}\n", st.Empty());

                    Console.WriteLine("\nПовторить(+/-)?");
                    ans = char.Parse(Console.ReadLine());
                    Console.WriteLine("\n\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка: {0}", ex.Message);
                }
        }
    }
}
