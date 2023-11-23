using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите погрешность: ");
        double epsilon = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите максимальное количество членов ряда: ");
        int maxTerms = Convert.ToInt32(Console.ReadLine());

        double sum = 0;

        for (int n = 1; n <= maxTerms; n++)
        {
            double term = Math.Pow(-1, n) * (n + 1) / (Math.Pow(n, 3) + 2);

            sum += term;

            if (Math.Abs(term) < epsilon)
            {
                Console.WriteLine($"Сумма членов ряда с достигнутой погрешностью {epsilon}: " + sum);
                break;
            }

            if (n == maxTerms)
            {
                Console.WriteLine($"Достигнуто максимальное количество членов ряда ({maxTerms}). Сумма членов ряда: " + sum);
                break;
            }
        }
    }
}
