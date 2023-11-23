using System;
using System.Collections.Generic;

// Класс "Студент"
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"┌─────────────────────────┐");
        Console.WriteLine($"│ Студент: {Name,-15}│");
        Console.WriteLine($"│ Возраст: {Age,-15}│");
        Console.WriteLine($"└─────────────────────────┘");
    }
}

// Класс "Группа" с отношением агрегации
class Group
{
    public string GroupName { get; set; }
    public List<Student> Students { get; set; }

    public Group(string groupName)
    {
        GroupName = groupName;
        Students = new List<Student>();
    }

    public void AddStudent(Student student)
    {
        Students.Add(student);
    }

    public void RemoveStudent(Student student)
    {
        Students.Remove(student);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"┌─────────────────────────┐");
        Console.WriteLine($"│ Группа: {GroupName,-16}│");
        Console.WriteLine($"│ Количество студентов: {Students.Count,-2}│");
        Console.WriteLine($"└─────────────────────────┘");

        Console.WriteLine("┌─────────────────────────┐");
        Console.WriteLine("│ Список студентов        │");
        Console.WriteLine("├─────────────────────────┤");

        foreach (var student in Students)
        {
            student.DisplayInfo();
        }

        Console.WriteLine("└─────────────────────────┘");
    }
}

// Класс "Факультет" с отношением композиции
class Faculty
{
    public string FacultyName { get; set; }
    public List<Group> Groups { get; set; }

    public Faculty(string facultyName)
    {
        FacultyName = facultyName;
        Groups = new List<Group>();
    }

    public void AddGroup(Group group)
    {
        Groups.Add(group);
    }

    public void RemoveGroup(Group group)
    {
        Groups.Remove(group);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"┌─────────────────────────┐");
        Console.WriteLine($"│ Факультет: {FacultyName,-13}│");
        Console.WriteLine($"└─────────────────────────┘");

        Console.WriteLine("┌─────────────────────────┐");
        Console.WriteLine("│ Список групп            │");
        Console.WriteLine("├─────────────────────────┤");

        foreach (var group in Groups)
        {
            group.DisplayInfo();
        }

        Console.WriteLine("└─────────────────────────┘");
    }
}

// Класс "Университет" с отношением композиции
class University
{
    public string UniversityName { get; set; }
    public List<Faculty> Faculties { get; set; }

    public University(string universityName)
    {
        UniversityName = universityName;
        Faculties = new List<Faculty>();
    }

    public void AddFaculty(Faculty faculty)
    {
        Faculties.Add(faculty);
    }

    public void RemoveFaculty(Faculty faculty)
    {
        Faculties.Remove(faculty);
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"┌─────────────────────────┐");
        Console.WriteLine($"│ Университет: {UniversityName,-11}│");
        Console.WriteLine($"└─────────────────────────┘");

        Console.WriteLine("┌─────────────────────────┐");
        Console.WriteLine("│ Список факультетов      │");
        Console.WriteLine("├─────────────────────────┤");

        foreach (var faculty in Faculties)
        {
            faculty.DisplayInfo();
        }

        Console.WriteLine("└─────────────────────────┘");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        // Создание университета
        var university = new University("ХПИ");

        // Создание факультетов
        var faculty1 = new Faculty("Информатики");
        var faculty2 = new Faculty("Инженерии");

        // Создание групп
        var group1 = new Group("Группа 101");
        var group2 = new Group("Группа 102");

        // Создание студентов
        var student1 = new Student("Иванов Иван", 20);
        var student2 = new Student("Петров Петр", 19);
        var student3 = new Student("Сидорова Ольга", 21);
        var student4 = new Student("Козлов Максим", 22);

        // Добавление студентов в группы
        group1.AddStudent(student1);
        group1.AddStudent(student2);
        group2.AddStudent(student3);
        group2.AddStudent(student4);

        // Добавление групп в факультеты
        faculty1.AddGroup(group1);
        faculty2.AddGroup(group2);

        // Добавление факультетов в университет
        university.AddFaculty(faculty1);
        university.AddFaculty(faculty2);

        // Вывод информации о университете (с отношением композиции)
        university.DisplayInfo();

        // Удаление факультета (с удалением всех связанных групп и студентов)
        Console.WriteLine("\nУдаление факультета:");
        university.RemoveFaculty(faculty1);
        Console.WriteLine("Факультет удален.");

        // Вывод информации о факультете после удаления
        faculty1.DisplayInfo(); // Это должно вывести информацию о факультете после удаления

        // Удаление университета (с удалением всех связанных факультетов, групп и студентов)
        Console.WriteLine("\nУдаление университета:");
        university = null;
        Console.WriteLine("Университет удален.");

        try
        {
            // Попытка вывести информацию об университете после удаления
            university.DisplayInfo(); // Ожидается исключение, так как университет удален
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}
