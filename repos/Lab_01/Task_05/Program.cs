using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите координаты точки (x, y):");
        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());

        if ((x >= -1 && x <= 0 && y >= 0 && y <= 1) ||
            (x >= 0 && x <= 1 && y >= -1 && y <= 0))
        {
            Console.WriteLine("Точка попадает в область.");
        }
        else
        {
            Console.WriteLine("Точка не попадает в область.");
        }
    }
}
