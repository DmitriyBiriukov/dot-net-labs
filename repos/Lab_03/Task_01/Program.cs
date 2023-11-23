using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine();

        Console.WriteLine("Введите вторую строку:");
        string str2 = Console.ReadLine();

        string result = ConcatenateStrings(str1, str2);

        Console.WriteLine("Результат:");
        Console.WriteLine(result);
    }

    static string ConcatenateStrings(string str1, string str2)
    {
        // Проверка на некорректные параметры
        if (str1 == null)
        {
            throw new ArgumentNullException(nameof(str1), "Первая строка не может быть null");
        }

        if (str2 == null)
        {
            throw new ArgumentNullException(nameof(str2), "Вторая строка не может быть null");
        }

        // Дописываем вторую строку в конец первой строки
        char[] resultChars = new char[str1.Length + str2.Length];
        for (int i = 0; i < str1.Length; i++)
        {
            resultChars[i] = str1[i];
        }

        for (int i = 0; i < str2.Length; i++)
        {
            resultChars[i + str1.Length] = str2[i];
        }

        return new string(resultChars);
    }
}