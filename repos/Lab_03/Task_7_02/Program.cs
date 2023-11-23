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

            // Запрос количества копий, которое нужно создать
            Console.Write("Введите количество копий: ");
            if (int.TryParse(Console.ReadLine(), out int numberOfCopies))
            {
                if (numberOfCopies >= 0)
                {
                    // Создание копий входного текста и получение результата
                    string result = CopyString(inputText, numberOfCopies);

                    // Вывод результата в консоль
                    Console.WriteLine("Результат:");
                    Console.WriteLine(result);

                    // Сохранение результата в указанный файл
                    File.WriteAllText(outputFileName, result);
                    Console.WriteLine($"Результат сохранен в файле {outputFileName}");
                }
                else
                {
                    Console.WriteLine("Количество копий должно быть неотрицательным.");
                }
            }
            else
            {
                Console.WriteLine("Некорректное количество копий.");
            }
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

    static string CopyString(string inputText, int numberOfCopies)
    {
        // Проверка на null и замена null пустой строкой
        if (inputText == null)
            inputText = "";

        // Создание новой строки, содержащей указанное количество копий входного текста
        string result = string.Concat(Enumerable.Repeat(inputText, numberOfCopies));

        return result;
    }
}