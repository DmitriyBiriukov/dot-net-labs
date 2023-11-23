using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текстовую строку:");
        string input = Console.ReadLine();

        // Создаем строку для хранения результата
        string result = "";

        // Проходимся по каждому символу в введенной строке
        foreach (char c in input)
        {
            if (c != '*') // Если символ не является "*", добавляем его дважды к результату
            {
                result += c;
                result += c;
            }
        }

        // Записываем результат в двоичный файл
        File.WriteAllText("result.bin", result);

        // Выводим содержимое двоичного файла на экран
        byte[] binaryData = File.ReadAllBytes("result.bin");
        Console.WriteLine("Результат:");
        Console.WriteLine(Encoding.UTF8.GetString(binaryData));

        // Завершаем программу
        Console.ReadLine();
    }
}
