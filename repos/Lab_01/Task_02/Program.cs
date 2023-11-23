using System;

class Program
{
    static void Main()
    {
        // Заголовок таблицы
        string tableTitle = "Фирмы - производители СКБД";
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(tableTitle);
        Console.ResetColor();

        // Двумерный массив для хранения данных о фирмах
        string[,] firmData = {
            { "Фирма", "Количество. продуктов", "Годовой объем продажи ($)", "Часть рынка (%)" },
            { "Oracle", "1", "2488000000", "31.1" },
            { "IBM", "3", "2392000000", "29.9" },
            { "Microsoft", "2", "1048000000", "13.1" }
        };

        // Определение ширины столбцов на основе данных
        int[] columnWidths = new int[firmData.GetLength(1)];
        for (int i = 0; i < firmData.GetLength(0); i++)
        {
            for (int j = 0; j < firmData.GetLength(1); j++)
            {
                if (firmData[i, j].Length > columnWidths[j])
                {
                    columnWidths[j] = firmData[i, j].Length;
                }
            }
        }

        // Вывод данных о фирмах с псевдографикой и цветами
        Console.WriteLine();
        for (int i = 0; i < firmData.GetLength(0); i++)
        {
            for (int j = 0; j < firmData.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("┌" + new string('─', columnWidths[j] + 2) + "┐");
                Console.ResetColor();
            }
            Console.WriteLine();

            for (int j = 0; j < firmData.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("│ ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(firmData[i, j].PadRight(columnWidths[j]));
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write(" │");
                Console.ResetColor();
            }
            Console.WriteLine();

            for (int j = 0; j < firmData.GetLength(1); j++)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("└" + new string('─', columnWidths[j] + 2) + "┘");
                Console.ResetColor();
            }
            Console.WriteLine();
        }

        // Примечание
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("Примечание: по данным Gartner Group за 1999г");
        Console.ResetColor();
    }
}
