using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string inputText = Console.ReadLine();

        string reversedText = ReverseString(inputText);

        Console.WriteLine("Результат:");
        Console.WriteLine(reversedText);
    }

    static string ReverseString(string inputText)
    {
        // Проверяем, что входная строка не является null
        if (inputText == null)
            inputText = "";

        // Преобразуем строку в массив символов
        char[] charArray = inputText.ToCharArray();

        // Переворачиваем массив символов
        Array.Reverse(charArray);

        // Преобразуем массив символов обратно в строку
        string reversedText = new string(charArray);

        return reversedText;
    }
}