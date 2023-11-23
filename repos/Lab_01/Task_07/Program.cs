using System;

class Program
{
    static void Main()
    {
        double sum = 0;
        double epsilon = 0.000001;
        int n = 0;

        while (true)
        {
            double term = (-1.0 * Math.Pow(-1, n) * (n + 1)) / (Math.Pow(n, 3) + 2);

            if (Math.Abs(term) < epsilon)
                break;

            sum += term;
            n++;
        }

        Console.WriteLine("Сумма членов ряда с точностью до 0.000001: " + sum);

        // Вычисление суммы первых 10 членов ряда
        double sumFirst10 = 0;
        for (int i = 0; i < 10; i++)
        {
            double term = (-1.0 * Math.Pow(-1, i) * (i + 1)) / (Math.Pow(i, 3) + 2);
            sumFirst10 += term;
        }

        Console.WriteLine("Сумма первых 10 членов ряда: " + sumFirst10);
    }
}
