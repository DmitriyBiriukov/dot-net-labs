using System;

class Program
{
    static void Main()
    {
        // Ввод значений x и y с клавиатуры
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Введите значение y: ");
        double y = double.Parse(Console.ReadLine());

        // Задание начальных значений для параметров
        double a = 2.0;
        double b = 3.0;
        double c = 1.0;
        double d = 4.0;
        int n = 3;
        int m = 5;

        // Вычисление t1 и t2
        double t1 = CalculateT1(x, y, a, b, c, d);
        double t2 = CalculateT2(x, a, c, n);

        // Вывод результатов
        Console.WriteLine($"Значение t1: {t1:f2}");
        Console.WriteLine($"Значение t2: {t2:f2}");

        Console.ReadLine();
    }

    // Функция для вычисления t1
    static double CalculateT1(double x, double y, double a, double b, double c, double d)
    {
        double term1 = (b / a) * Math.Log(a * x + b);
        double term2 = (d / y) * Math.Log(y * x + d);
        return 1.0 / c * Math.Abs(term1 + term2);
    }

    // Функция для вычисления t2
    static double CalculateT2(double x, double a, double c, int n)
    {
        return 1.0 / (a * (n - 1)) * Math.Sin(a * x) / Math.Pow(Math.Cos(a * x), n - 1);
    }
}
