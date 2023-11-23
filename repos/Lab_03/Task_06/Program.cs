using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите текстовую строку:");
        string input = Console.ReadLine();

        // Пункт (а): Проверка совпадения количества скобок
        bool balancedBrackets = CheckBalancedBrackets(input);
        if (balancedBrackets)
        {
            Console.WriteLine("Количество открытых и закрытых скобок совпадает.");
        }
        else
        {
            Console.WriteLine("Количество открытых и закрытых скобок не совпадает.");
        }

        // Пункт (б): Поиск самого длинного слова
        string longestWord = FindLongestWord(input);
        Console.WriteLine($"Самое длинное слово: {longestWord}");

        // Пункт (в): Удаление слов, состоящих только из латинских букв
        string textWithoutLatinWords = RemoveLatinWords(input);
        Console.WriteLine($"Текст без слов, состоящих только из латинских букв: {textWithoutLatinWords}");
    }

    // Метод для проверки совпадения количества скобок
    static bool CheckBalancedBrackets(string input)
    {
        int roundOpen = 0;
        int roundClose = 0;
        int squareOpen = 0;
        int squareClose = 0;

        foreach (char c in input)
        {
            if (c == '(')
                roundOpen++;
            else if (c == ')')
                roundClose++;
            else if (c == '[')
                squareOpen++;
            else if (c == ']')
                squareClose++;
        }

        return roundOpen == roundClose && squareOpen == squareClose;
    }

    // Метод для поиска самого длинного слова
    static string FindLongestWord(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        return longestWord;
    }

    // Метод для удаления слов, состоящих только из латинских букв
    static string RemoveLatinWords(string input)
    {
        string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
        string result = "";

        foreach (string word in words)
        {
            bool isLatin = true;

            foreach (char c in word)
            {
                if (!(c >= 'a' && c <= 'z') && !(c >= 'A' && c <= 'Z'))
                {
                    isLatin = false;
                    break;
                }
            }

            if (!isLatin)
            {
                result += word + " ";
            }
        }

        return result.Trim();
    }
}
