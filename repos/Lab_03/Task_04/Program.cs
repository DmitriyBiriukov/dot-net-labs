using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текстовую строку:");
        string input = Console.ReadLine();

        // Создаем строку для хранения результата
        string result = "";

        // Проходимся по каждому символу во введенной строке
        foreach (char c in input)
        {
            if (c != '*') // Если символ не является "*", добавляем его дважды к результату
            {
                result += c;
                result += c;
            }
        }

        Console.WriteLine("Результат:");
        Console.WriteLine(result);

        // Завершаем программу
        Console.ReadLine();
    }
}