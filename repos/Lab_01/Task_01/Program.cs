using System;

class Program
{
    static void Main()
    {
        // Заголовок таблицы
        string tableTitle = "Фирмы - производители СКБД";
        Console.WriteLine(tableTitle);

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

        // Вывод данных о фирмах с выравниванием
        Console.WriteLine();
        for (int i = 0; i < firmData.GetLength(0); i++)
        {
            for (int j = 0; j < firmData.GetLength(1); j++)
            {
                Console.Write(firmData[i, j].PadRight(columnWidths[j] + 2));
            }
            Console.WriteLine();
        }

        // Примечание
        Console.WriteLine("Примечание: по данным Gartner Group за 1999г");
    }
}