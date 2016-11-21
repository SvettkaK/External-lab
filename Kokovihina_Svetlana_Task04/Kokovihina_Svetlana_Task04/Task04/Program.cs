using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MyString
{
    private char[] str;

    public MyString()
    {

    }
    public MyString (char[] s)
    {
        StrVal = s;
    }

    public char[] StrVal
    {
        get { return str; }
        set { str = value; }
    }

    public static MyString operator +(MyString str1, MyString str2)//todo ты строки только складываешь? а как же сравнение строк (==, !=)? Поиск подстроки в строке? Замена подстроки в строке? Напиши хотя бы эти методы, но я тебя не ограничиваю :)
    {
        char[] s1 = str1.StrVal;
        char[] s2 = str2.StrVal;
        char[] s = new char[(s1.Length + s2.Length)];
        
        for (int i = 0; i < s1.Length; i++)
        {
            s[i] = s1[i];
        }

        for (int i = 0; i < s2.Length; i++)
        {
            s[s1.Length + i] = s2[i];
        }

        MyString newstr = new MyString(s);
        return newstr;
    }
    
    public int Length()
    {
        return str.Length;
    }

    public void Write()
    {
        for (int i = 0; i < str.Length; i++)
        {
            Console.Write("{0}", Convert.ToChar(str[i]));
        }
    }
    
    public void Insert(int pos, char[] s)
    {
        char[] newstr = new char[str.Length + s.Length];
        int j = 0;
        for (int i = 0; i < newstr.Length; i++)
        {
            if (i < pos)
            {
                newstr[i] = str[j++];
            }
            else 
            if (i == pos)
            {
                for (int k = 0; k < s.Length; k++)
                {
                    newstr[i++] = s[k];
                }
            }
            else
            {
                newstr[i-1] = str[j++];
            }
        }
        MyString n = new MyString(newstr);
        StrVal = n.StrVal;
    }
}
namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Введите строку 1: ");
                char[] str1 = Console.ReadLine().ToCharArray();
                Console.Write("Введите строку 2: ");
                char[] str2 = Console.ReadLine().ToCharArray();

                MyString mystr1 = new MyString(str1);
                MyString mystr2 = new MyString(str2);
                MyString mystr3 = new MyString();

                mystr3 = mystr1 + mystr2;

                Console.Write("\nОператор +: ");
                mystr3.Write();

                mystr1.Insert(3, mystr2.StrVal);
                Console.Write("\nInsert: " );
                mystr1.Write();


            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: {0}",ex);
            }
            Console.ReadKey();
        }
    }
}
