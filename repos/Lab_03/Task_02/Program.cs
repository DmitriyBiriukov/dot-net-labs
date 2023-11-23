using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string inputString = Console.ReadLine();

        Console.Write("Введите количество копий: ");
        if (int.TryParse(Console.ReadLine(), out int numberOfCopies))
        {
            if (numberOfCopies >= 0)
            {
                string result = CopyString(inputString, numberOfCopies);

                Console.WriteLine("Результат:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Количество копий должно быть неотрицательным числом.");
            }
        }
        else
        {
            Console.WriteLine("Некорректное количество копий.");
        }
    }

    static string CopyString(string inputString, int numberOfCopies)
    {
        // Проверяем, что входная строка не является null
        if (inputString == null)
            inputString = "";

        // Создаем новую строку для хранения результата
        char[] result = new char[inputString.Length * numberOfCopies];

        // Копируем входную строку нужное количество раз
        for (int i = 0; i < numberOfCopies; i++)
        {
            for (int j = 0; j < inputString.Length; j++)
            {
                result[i * inputString.Length + j] = inputString[j];
            }
        }

        // Преобразуем результат в строку и возвращаем её
        return new string(result);
    }
}