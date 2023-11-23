using System;
using System.Collections.Generic;
using System.Linq;

// Абстрактный класс Person
abstract class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }

    public Person(string firstName, string lastName, string address)
    {
        FirstName = firstName;
        LastName = lastName;
        Address = address;
    }

    public abstract void ShowInfo();
}

// Класс Student, наследующийся от Person
class Student : Person
{
    public int StudentId { get; set; }
    public List<int> Grades { get; set; }

    public Student(string firstName, string lastName, string address, int studentId, List<int> grades)
        : base(firstName, lastName, address)
    {
        StudentId = studentId;
        Grades = grades;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║                Студент                      ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.WriteLine($"║ Фамилия: \u001b[32m{FirstName}\u001b[0m");
        Console.WriteLine($"║ Имя: \u001b[32m{LastName}\u001b[0m");
        Console.WriteLine($"║ Адрес: \u001b[32m{Address}\u001b[0m");
        Console.WriteLine($"║ Студенческий ID: \u001b[32m{StudentId}\u001b[0m");
        Console.WriteLine("║ Оценки: ");
        foreach (var grade in Grades)
        {
            if (grade >= 4)
            {
                Console.Write($"\u001b[32m{grade} \u001b[0m");
            }
            else if (grade == 3)
            {
                Console.Write($"\u001b[33m{grade} \u001b[0m");
            }
            else
            {
                Console.Write($"\u001b[31m{grade} \u001b[0m");
            }
        }
        Console.WriteLine();
        Console.WriteLine("╚════════════════════════════════════════════╝");
    }
}

// Класс SchoolStudent, наследующийся от Person
class SchoolStudent : Person
{
    public int SchoolGrade { get; set; }

    public SchoolStudent(string firstName, string lastName, string address, int schoolGrade)
        : base(firstName, lastName, address)
    {
        SchoolGrade = schoolGrade;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║                Школьник                    ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.WriteLine($"║ Фамилия: \u001b[32m{FirstName}\u001b[0m");
        Console.WriteLine($"║ Имя: \u001b[32m{LastName}\u001b[0m");
        Console.WriteLine($"║ Адрес: \u001b[32m{Address}\u001b[0m");
        Console.WriteLine($"║ Класс: \u001b[32m{SchoolGrade}\u001b[0m");
        Console.WriteLine("╚════════════════════════════════════════════╝");
    }
}

// Класс UndergraduateStudent, наследующийся от Student
class UndergraduateStudent : Student
{
    public string Major { get; set; }

    public UndergraduateStudent(string firstName, string lastName, string address, int studentId, List<int> grades, string major)
        : base(firstName, lastName, address, studentId, grades)
    {
        Major = major;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║           Бакалавр                         ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.WriteLine($"║ Фамилия: \u001b[32m{FirstName}\u001b[0m");
        Console.WriteLine($"║ Имя: \u001b[32m{LastName}\u001b[0m");
        Console.WriteLine($"║ Адрес: \u001b[32m{Address}\u001b[0m");
        Console.WriteLine($"║ Студенческий ID: \u001b[32m{StudentId}\u001b[0m");
        Console.WriteLine($"║ Оценки: ");
        foreach (var grade in Grades)
        {
            if (grade >= 4)
            {
                Console.Write($"\u001b[32m{grade} \u001b[0m");
            }
            else if (grade == 3)
            {
                Console.Write($"\u001b[33m{grade} \u001b[0m");
            }
            else
            {
                Console.Write($"\u001b[31m{grade} \u001b[0m");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"║ Специальность: \u001b[32m{Major}\u001b[0m");
        Console.WriteLine("╚════════════════════════════════════════════╝");
    }
}

// Класс GraduateStudent, наследующийся от Student
class GraduateStudent : Student
{
    public string ResearchTopic { get; set; }

    public GraduateStudent(string firstName, string lastName, string address, int studentId, List<int> grades, string researchTopic)
        : base(firstName, lastName, address, studentId, grades)
    {
        ResearchTopic = researchTopic;
    }

    public override void ShowInfo()
    {
        Console.WriteLine("╔════════════════════════════════════════════╗");
        Console.WriteLine("║          Аспирант                          ║");
        Console.WriteLine("╠════════════════════════════════════════════╣");
        Console.WriteLine($"║ Фамилия: \u001b[32m{FirstName}\u001b[0m");
        Console.WriteLine($"║ Имя: \u001b[32m{LastName}\u001b[0m");
        Console.WriteLine($"║ Адрес: \u001b[32m{Address}\u001b[0m");
        Console.WriteLine($"║ Студенческий ID: \u001b[32m{StudentId}\u001b[0m");
        Console.WriteLine($"║ Оценки: ");
        foreach (var grade in Grades)
        {
            if (grade >= 4)
            {
                Console.Write($"\u001b[32m{grade} \u001b[0m");
            }
            else if (grade == 3)
            {
                Console.Write($"\u001b[33m{grade} \u001b[0m");
            }
            else
            {
                Console.Write($"\u001b[31m{grade} \u001b[0m");
            }
        }
        Console.WriteLine();
        Console.WriteLine($"║ Тема исследования: \u001b[32m{ResearchTopic}\u001b[0m");
        Console.WriteLine("╚════════════════════════════════════════════╝");
    }
}

class Program
{
    static void Main()
    {
        List<Person> people = new List<Person>();

        // Создаем объекты разных типов
        var schoolStudent = new SchoolStudent("Иван", "Иванов", "ул. Школьная 1", 9);
        var undergraduateStudent = new UndergraduateStudent("Петр", "Петров", "ул. Университетская 10", 12345, new List<int> { 4, 5, 5, 4, 3 }, "Информатика");
        var graduateStudent = new GraduateStudent("Анна", "Сидорова", "ул. Аспирантская 5", 54321, new List<int> { 5, 4, 4, 5, 5 }, ".Net");

        // Добавляем их в коллекцию
        people.Add(schoolStudent);
        people.Add(undergraduateStudent);
        people.Add(graduateStudent);

        // Выводим информацию о каждом объекте
        foreach (var person in people)
        {
            person.ShowInfo();
            Console.WriteLine();
        }
    }
}
