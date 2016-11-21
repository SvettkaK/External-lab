using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User
{
    public string name;
    public string lastname;
    public string patronymic;
    public DateTime birth;
    public int age;

    public User()
    {

    }
    public User(string n, string l, string p, DateTime b, int a)
    {
        Name = n;
        LastName = l;
        Patronymic = p;
        Birth = b;
        if (Age == 0 && Birth != new DateTime(0001, 01, 01)) Age = GetAge();
        else Age = a;
    }

    public string Name
    {
        get
        {
            if (name.Length > 0) return name;
            else return "<Имя>";
        }
        set { name = value; }
    }

    public string LastName
    {
        get
        {
            if (lastname.Length > 0) return lastname;
            else return "<Фамили>";
        }
        set { lastname = value; }
    }

    public string Patronymic
    {
        get
        {
            if (patronymic.Length > 0) return patronymic;
            else return "<Отчество>";
        }
        set { patronymic = value; }
    }

    public DateTime Birth
    {
        get { return birth; }
        set { birth = value; }
    }

    public int Age
    {
        get 
        {
            if (age == 0 && birth != new DateTime(0001, 01, 01))
            {
                return GetAge();
            }
            else
            {
                return age;
            }
        }
        set { age = value; }
    }

    public int GetAge()
    {
        DateTime Today = DateTime.Today;
        
        if (Today.Month < Birth.Month || (Today.Month == Birth.Month && Today.Day < Birth.Day))
        {
            Age = Today.Year - Birth.Year - 1;
        }
        else
        {
            Age = Today.Year - Birth.Year;
        }

        return Age;
    }

    public string info ()
    {
        return String.Format("{0} {1} {2} {3} ({4} лет)", Name, LastName, Patronymic, Birth.ToString("d"), Age);
    }
}

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("Иванов","Иван","Иванович", new DateTime(1900, 08, 02), 0);
                Console.WriteLine(user1.info());

                User user = new User();
                Console.Write("Новый пользователь:\nИмя:");
                user.Name = Console.ReadLine();
                Console.Write("Фамилия:");
                user.LastName = Console.ReadLine();
                Console.Write("Отчество:");
                user.Patronymic = Console.ReadLine();
                Console.WriteLine("Дата рождения (год месяц день):", user.Birth);
                user.Birth = new DateTime(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                user.GetAge();
                Console.WriteLine(user.info());

                if(user.Age < user1.Age)
                {
                    Console.WriteLine("{0} {1} старше {2} {3} на {4} лет", user1.Name, user1.LastName, user.Name, user.LastName, (user1.Age - user.Age));
                }
                else
                {
                    Console.WriteLine("{0} {1} старше {2} {3} на {4} лет", user.Name, user.LastName, user1.Name, user1.LastName, (user.Age - user1.Age));
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
