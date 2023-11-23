using System;

class Program
{
    static void Main(string[] args)
    {
        short n;        // параметр внешнего цикла
        double x, y;    // абсцисса и ордината графика

        // внешний цикл - для 5 периодов
        for (n = 0; n < 5; n++)
        {
            // вывод заголовка таблицы
            Console.WriteLine("|   x   |      y     |");
            Console.WriteLine("|-------|------------|");

            // внутренний цикл для одного периода
            for (x = 0; x < 4; x += 0.25)
            {
                // 1-й отрезок
                if (x < 1) y = 2 * x - 1;
                // 2-й отрезок
                else if (x < 3)
                {
                    y = 1;
                }
                // 3-й отрезок
                else y = 7 - 2 * x;

                // вывод координат (x, y)
                Console.WriteLine($"| {x + n * 4,5:F2} | {y,10:F7} |");
            }  // конец внутреннего цикла

            // пауза до команды оператора
            Console.WriteLine("Нажмите клавишу Enter...");
            Console.ReadLine();
        }  // конец внешнего цикла

        return;
    }  // конец метода Main
}  // конец класса Program
