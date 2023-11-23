using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер списка: ");
        if (!int.TryParse(Console.ReadLine(), out int listSize) || listSize <= 0)
        {
            Console.WriteLine("Некорректный ввод размера списка.");
            return;
        }

        List<int> list = new List<int>(listSize); // создаем список для обработки

        Random random = new Random(); // создаем генератор случайных чисел

        // Заполнение списка случайными числами
        for (int i = 0; i < listSize; i++)
        {
            list.Add(random.Next(-50, 51)); // диапазон значений от -50 до 50
        }

        // Вывод начального списка
        Console.WriteLine("Начальный список:");
        foreach (int item in list)
        {
            Console.Write($"{item,3} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        int nn = 0; // количество элементов в последовательности
        int ib = 0; // индекс начала последовательности
        int av = 0; // среднее значение

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] < 0)
            {
                // Обработка отрицательного элемента
                if (nn == 0)
                {
                    // Начало последовательности
                    ib = i;
                    av = list[i];
                    nn = 1;
                }
                else
                {
                    // Накопление суммы и подсчет количества
                    av += list[i];
                    nn++;
                }
            }
            else
            {
                // Обработка положительного элемента
                if (nn > 0)
                {
                    // Если есть необработанная отрицательная последовательность
                    av /= nn; // Усреднение

                    // Подсчет пар соседних элементов с одинаковыми значениями
                    for (int j = ib; j < i; j++)
                    {
                        if (list[j] > av)
                        {
                            list[j] = av;
                        }
                    }

                    nn = 0; // Последовательность обработана
                }
            }
        }

        if (nn > 0)
        {
            // Если не обработана последняя отрицательная последовательность
            av /= nn;

            for (int j = ib; j < list.Count; j++)
            {
                if (list[j] > av)
                {
                    list[j] = av;
                }
            }
        }

        // Вывод результатов с выделением цветом
        Console.WriteLine("Список-результат:");
        for (int i = 0; i < list.Count; i++)
        {
            if (i > 0 && list[i] == list[i - 1])
            {
                Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для пар
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write($"{list[i],3} ");
        }
        Console.WriteLine();

        // Подсчет количества пар соседних элементов с одинаковыми значениями
        int pairCount = Enumerable.Range(1, list.Count - 1).Count(i => list[i] == list[i - 1]);
        Console.WriteLine($"Количество пар соседних элементов с одинаковыми значениями: {pairCount}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}