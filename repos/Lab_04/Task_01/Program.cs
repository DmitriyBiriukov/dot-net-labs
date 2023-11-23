using System;
using System.Collections.Generic;
using System.Linq;

class Abiturient
{
    // Определение класса Abiturient с полями и методами

    // Свойства для хранения информации об абитуриенте
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MiddleName { get; set; }
    public string Address { get; set; }
    public List<int> Grades { get; set; }

    // Конструктор класса Abiturient
    public Abiturient(string firstName, string lastName, string middleName, string address, List<int> grades)
    {
        FirstName = firstName;
        LastName = lastName;
        MiddleName = middleName;
        Address = address;
        Grades = grades;
    }

    // Метод для расчета средней оценки
    public double CalculateAverageGrade()
    {
        if (Grades.Count == 0)
        {
            return 0.0;
        }
        double sum = 0;
        foreach (int grade in Grades)
        {
            sum += grade;
        }
        return sum / Grades.Count;
    }

   
    // Метод для отображения информации об абитуриенте
    public void ShowInfo(bool showTotalGrade = false)
    {
        Console.WriteLine($"┌───────────────┬──────────────┬───────────────┬─────────────────┬───────────────────────────────┐");
        Console.WriteLine($"│ Фамилия       │ Имя          │ Отчество      │ Адрес           │ Оценки        │ Средний балл  │");
        Console.WriteLine($"├───────────────┼──────────────┼───────────────┼─────────────────┼───────────────┼───────────────┤");
        Console.WriteLine($"│ {LastName,-13} │{FirstName,-14}│ {MiddleName,-13} │ {Address,-15} │ {string.Join(" ", Grades.Select(GradeColor)),-13} │{Grades.Sum()} │ {CalculateAverageGrade(),-13:F2} │");
        Console.WriteLine($"└───────────────┴──────────────┴───────────────┴─────────────────┴───────────────┴───────────────┘");
        Console.WriteLine();
    }


    // Вспомогательный метод для добавления цветов оценкам
    private string GradeColor(int grade)
    {
        if (grade == 5)
            return "\u001b[32m" + grade + "\u001b[0m"; // Зеленый
        else if (grade == 2)
            return "\u001b[31m" + grade + "\u001b[0m"; // Красный
        else if (grade == 3 || grade == 4)
            return "\u001b[33m" + grade + "\u001b[0m"; // Желтый
        else
            return grade.ToString();
    }
}

class Program
{
    static void Main()
    {
        // Основной метод программы

        // Создаем список абитуриентов
        List<Abiturient> abiturients = new List<Abiturient>();

        // Создаем генератор случайных чисел
        Random random = new Random();

        // Генерируем 10 случайных абитуриентов с оценками
        for (int i = 0; i < 10; i++)
        {
            string[] firstNames = { "Иван", "Петр", "Анна", "Ольга", "Максим", "Екатерина" };
            string[] lastNames = { "Иванов", "Петров", "Сидоров", "Смирнов", "Козлов", "Морозов" };
            string[] middleNames = { "Иванович", "Петрович", "Андреевна", "Олеговна", "Максимович", "Егоровна" };
            string[] addresses = { "ул. Ленина 1", "пр. Гагарина 5", "ул. Пушкина 10", "пр. Ленина 25", "ул. Гагарина 8", "пр. Пушкина 15" };

            string firstName = firstNames[random.Next(firstNames.Length)];
            string lastName = lastNames[random.Next(lastNames.Length)];
            string middleName = middleNames[random.Next(middleNames.Length)];
            string address = addresses[random.Next(addresses.Length)];

            List<int> grades = new List<int>();
            for (int j = 0; j < 5; j++)
            {
                grades.Add(random.Next(2, 6)); // Генерируем случайные оценки от 2 до 5
            }
            Abiturient abiturient = new Abiturient(firstName, lastName, middleName, address, grades);
            abiturients.Add(abiturient);
        }

        // Выводим всех абитуриентов
        Console.WriteLine("Все абитуриенты:");
        foreach (var abiturient in abiturients)
        {
            abiturient.ShowInfo();
        }

        // Выводим абитуриентов с неудовлетворительными оценками (меньше 3)
        Console.WriteLine("Список абитуриентов с неудовлетворительными оценками:");
        var unsatisfactoryAbiturients = abiturients.Where(a => a.Grades.Any(g => g < 3));
        foreach (var abiturient in unsatisfactoryAbiturients)
        {
            abiturient.ShowInfo();
        }

        // Задаем минимальную сумму баллов
        int minimumTotalGrade = 15;

        // Выводим абитуриентов с суммой баллов не меньше заданной
        Console.WriteLine($"Список абитуриентов с суммой баллов не меньше {minimumTotalGrade}:");
        var abiturientsWithMinimumTotalGrade = abiturients.Where(a => a.Grades.Sum() >= minimumTotalGrade);
        foreach (var abiturient in abiturientsWithMinimumTotalGrade)
        {
            abiturient.ShowInfo();
        }

        // Задаем количество абитуриентов в топе
        int topNAbiturients = 3;

        // Выводим топ абитуриентов с наивысшей суммой баллов
        Console.WriteLine($"Топ {topNAbiturients} абитуриентов с наивысшей суммой баллов:");
        var topAbiturients = abiturients.OrderByDescending(a => a.Grades.Sum()).Take(topNAbiturients);
        foreach (var abiturient in topAbiturients)
        {
            abiturient.ShowInfo();
        }

        // Задаем полпроходной балл
        double passGrade = 3.5;

        // Выводим абитуриентов с полпроходным баллом
        Console.WriteLine($"Список абитуриентов с полпроходным баллом ({passGrade}):");
        var passAbiturients = abiturients.Where(a => a.CalculateAverageGrade() >= passGrade && a.CalculateAverageGrade() < 4.0);
        foreach (var abiturient in passAbiturients)
        {
            abiturient.ShowInfo();
        }
    }
}