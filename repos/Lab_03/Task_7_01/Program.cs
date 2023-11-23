using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Запрос у пользователя имени входного файла
        Console.Write("Введите имя входного файла: ");
        string inputFileName = Console.ReadLine();

        // Запрос у пользователя имени файла для сохранения результата
        Console.Write("Введите имя файла для сохранения результата: ");
        string outputFileName = Console.ReadLine();

        try
        {
            // Чтение содержимого входного файла
            string inputText = File.ReadAllText(inputFileName);

            // Вывод сообщения о начале обработки
            Console.WriteLine("Результат:");

            // Вызов функции для обработки текста
            string result = ConcatenateStrings(inputText);

            // Вывод обработанного текста на консоль
            Console.WriteLine(result);

            // Запись обработанного текста в выходной файл
            File.WriteAllText(outputFileName, result);

            // Вывод сообщения об успешном завершении с указанием имени выходного файла
            Console.WriteLine($"Результат сохранен в файле {outputFileName}");
        }
        catch (FileNotFoundException)
        {
            // Обработка ошибки, если файл не найден
            Console.WriteLine("Не удалось найти входной файл.");
        }
        catch (IOException)
        {
            // Обработка ошибки ввода/вывода при работе с файлами
            Console.WriteLine("Ошибка ввода/вывода при работе с файлами.");
        }
    }

    static string ConcatenateStrings(string inputText)
    {
        // Проверка на null
        if (inputText == null)
            inputText = "";

        // Добавление строки " World!" в конец входного текста
        string result = inputText + " World!";

        return result;
    }
}