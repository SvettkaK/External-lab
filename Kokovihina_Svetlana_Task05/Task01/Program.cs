using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class User//todo вынести в отдельный файл
{
    public string name;
    public string lastname;
    public string patronymic;
    public DateTime birth;
    public int age;

    public User()
    {
        Name = "";
        LastName = "";
        Patronymic = "";
    }
    public User(string n, string l, string p, DateTime b)
    {
        Name = n;
        LastName = l;
        Patronymic = p;
        Birth = b;
        if (Birth != new DateTime(0001, 01, 01)) Age = GetAge();//todo на новую строку и обрамить скобками
    }

    public string Name
    {
        get
        {
            if (name.Length > 0) return name;//todo длина строки не бывает отрицательной
            else return "<Имя>";
        }
        set { name = value; }
    }

    public string LastName
    {
        get
        {
            if (lastname.Length > 0) return lastname;//todo длина строки не бывает отрицательной
            else return "<Фамилия>";
        }
        set { lastname = value; }
    }

    public string Patronymic
    {
        get
        {
            if (patronymic.Length > 0) return patronymic;//todo длина строки не бывает отрицательной
            else return "<Отчество>";
        }
        set { patronymic = value; }
    }

    public DateTime Birth
    {
        get { return birth; }
        set
        {
            birth = value;
            age = GetAge();
        }
    }

    public int Age
    {
        get { return age; }
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

    public string info()
    {
        return String.Format("{0} {1} {2} {3} ({4} лет)", Name, LastName, Patronymic, Birth.ToString("d"), Age);
    }
}

class Employee : User//todo вынести в отдельный файл
{
    public int Еxperience { get; set; }
    public string Position { get; set; }
    private DateTime worksF;
    public DateTime WorksF
    {
        get { return worksF; }
        set
        {
            worksF = value;
            Еxperience = getЕxperience();
        }
    }

    public Employee()
        : base()
    {

    }

    public Employee(string n, string l, string p, DateTime b, int exp, string pos)
        : base(n, l, p, b)
    {
        Еxperience = exp;
        Position = pos;
    }

    public int getЕxperience()
    {
        DateTime Today = DateTime.Today;

        if (Today.Month < WorksF.Month || (Today.Month == WorksF.Month && Today.Day < WorksF.Day))
        {
            Еxperience = Today.Year - WorksF.Year - 1;
        }
        else
        {
            Еxperience = Today.Year - WorksF.Year;
        }
        return Еxperience;
    }

    public new string info()
    {
        return String.Format("{0} {1} {2} {3} ({4} лет) Должность:{5} ({6} лет)", Name, LastName, Patronymic, Birth.ToString("d"), Age, Position, Еxperience);
    }
}

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                User user1 = new User("Иван", "Иванов", "Иванович", new DateTime(1900, 08, 02));
                Console.WriteLine(user1.info());

                Employee emp1 = new Employee("Акакий", "", "Аркадьевич", new DateTime(1900, 08, 02), 5, "Менеджер");
                emp1.Birth = new DateTime(1950, 08, 02);
                Console.WriteLine(emp1.info());

                Employee emp2 = new Employee();
                emp2.Position = "Дизайнер";
                emp2.Birth = new DateTime(1900, 08, 02);
                emp2.WorksF = new DateTime(1888, 01, 01);//todo нет проверки того, что стаж мб больше возраста
                Console.WriteLine(emp2.info());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: {0}", ex.Message);
            }
            Console.ReadKey();
        }
    }
}
