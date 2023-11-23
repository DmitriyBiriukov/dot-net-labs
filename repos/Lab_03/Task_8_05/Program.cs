using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        // Разделяем текст на слова
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        int totalWords = words.Length; // Общее количество слов
        int wordsStartingWithK = 0; // Количество слов, начинающихся с буквы "к" или "К"

        foreach (string word in words)
        {
            char firstChar = char.ToLower(word[0]); // Получаем первую букву слова в нижнем регистре

            // Проверяем, начинается ли слово с буквы "к" (или "К")
            if (firstChar == 'к')
            {
                wordsStartingWithK++;
            }
        }

        // Вычисляем процент слов, начинающихся с буквы "к" (или "К")
        double percentage = (double)wordsStartingWithK / totalWords * 100;

        // Записываем результат в двоичный файл
        File.WriteAllText("result.bin", percentage.ToString("F2") + "%");

        // Выводим содержимое двоичного файла на экран
        byte[] binaryData = File.ReadAllBytes("result.bin");
        Console.WriteLine("Результат:");
        Console.WriteLine(Encoding.UTF8.GetString(binaryData));

        // Завершаем программу
        Console.ReadLine();
    }
}