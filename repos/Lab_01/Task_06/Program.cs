using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        bool isInUpperLeft = (x >= -1 && x <= 0) && (y >= 0 && y <= 1);
        bool isInLowerRight = (x >= 0 && x <= 1) && (y >= -1 && y <= 0);

        bool isInShadedArea = isInUpperLeft || isInLowerRight;

        Console.WriteLine(isInShadedArea ? "Точка попадает в область." : "Точка не попадает в область.");
    }
}
