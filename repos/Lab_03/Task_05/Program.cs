using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текст:");
        string input = Console.ReadLine();

        // Разделяем текст на слова, используя пробел как разделитель
        string[] words = input.Split(' ');

        int totalWords = words.Length; // Общее количество слов
        int wordsStartingWithK = 0; // Количество слов, начинающихся с буквы "к"

        foreach (string word in words)
        {
            if (!string.IsNullOrWhiteSpace(word)) // Игнорируем пустые слова
            {
                char firstChar = word[0]; // Получаем первую букву слова

                // Проверяем, начинается ли слово с буквы "к" (или "К")
                if (firstChar == 'к' || firstChar == 'К')
                {
                    wordsStartingWithK++;
                }
            }
        }

        // Вычисляем процент слов, начинающихся с буквы "к" (или "К")
        double percentage = (double)wordsStartingWithK / totalWords * 100;

        Console.WriteLine($"Процент слов, начинающихся с буквы 'к' (или 'К'): {percentage}%");

        // Завершаем программу
        Console.ReadLine();
    }
}