using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива: ");
        if (!int.TryParse(Console.ReadLine(), out int arraySize) || arraySize <= 0)
        {
            Console.WriteLine("Некорректный ввод размера массива.");
            return;
        }

        int[] Ar = new int[arraySize]; // динамический массив, который обрабатывается

        Random random = new Random(); // создаем генератор случайных чисел

        // Заполнение массива случайными числами
        for (int i = 0; i < arraySize; i++)
        {
            Ar[i] = random.Next(-50, 51); // диапазон значений от -50 до 50
        }

        // Вывод начального массива с цветом
        Console.WriteLine("Начальный массив:");
        for (int i = 0; i < arraySize; i++)
        {
            Console.Write($"{Ar[i],3} ");
        }
        Console.WriteLine();
        Console.WriteLine();

        int nn = 0; // количество элементов в последовательности
        int ib = 0; // индекс начала последовательности
        int av = 0; // среднее значение

        for (int i = 0; i < arraySize; i++)
        {
            if (Ar[i] < 0)
            {
                // Обработка отрицательного элемента
                if (nn == 0)
                {
                    // Начало последовательности
                    ib = i;
                    av = Ar[i];
                    nn = 1;
                }
                else
                {
                    // Накопление суммы и подсчет количества
                    av += Ar[i];
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
                        if (Ar[j] > av)
                        {
                            Ar[j] = av;
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

            for (int j = ib; j < arraySize; j++)
            {
                if (Ar[j] > av)
                {
                    Ar[j] = av;
                }
            }
        }

        // Вывод результатов с выделением цветом
        Console.WriteLine("Массив-результат:");
        for (int i = 0; i < arraySize; i++)
        {
            if (i > 0 && Ar[i] == Ar[i - 1])
            {
                Console.ForegroundColor = ConsoleColor.Green; // Зеленый цвет для пар
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }

            Console.Write($"{Ar[i],3} ");
        }
        Console.WriteLine();

        // Подсчет количества пар соседних элементов с одинаковыми значениями
        int pairCount = Enumerable.Range(1, arraySize - 1).Count(i => Ar[i] == Ar[i - 1]);
        Console.WriteLine($"Количество пар соседних элементов с одинаковыми значениями: {pairCount}");
        Console.ForegroundColor = ConsoleColor.White;
    }
}
