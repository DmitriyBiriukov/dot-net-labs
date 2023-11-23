using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Запрос имени входного файла у пользователя
        Console.Write("Введите имя входного файла: ");
        string inputFileName = Console.ReadLine();

        // Запрос имени файла для сохранения результата у пользователя
        Console.Write("Введите имя файла для сохранения результата: ");
        string outputFileName = Console.ReadLine();

        try
        {
            // Чтение текста из входного файла
            string inputText = File.ReadAllText(inputFileName);

            // Переворачивание текста
            string reversedText = ReverseString(inputText);

            // Вывод перевернутого текста в консоль
            Console.WriteLine("Результат:");
            Console.WriteLine(reversedText);

            // Сохранение перевернутого текста в указанный файл
            File.WriteAllText(outputFileName, reversedText);
            Console.WriteLine($"Результат сохранен в файле {outputFileName}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Не удалось найти входной файл.");
        }
        catch (IOException)
        {
            Console.WriteLine("Ошибка ввода/вывода при работе с файлами.");
        }
    }

    // Метод для переворачивания строки
    static string ReverseString(string inputText)
    {
        // Проверка на null и замена null пустой строкой
        if (inputText == null)
            inputText = "";

        // Преобразование строки в массив символов
        char[] charArray = inputText.ToCharArray();

        // Реверс массива символов
        Array.Reverse(charArray);

        // Преобразование массива символов обратно в строку
        string reversedText = new string(charArray);

        return reversedText;
    }
}
