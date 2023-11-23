using System;

class Fraction
{
    private int numerator;   // числитель
    private int denominator; // знаменатель

    public int Numerator
    {
        get { return numerator; }
    }

    public int Denominator
    {
        get { return denominator; }
    }

    // Конструктор для создания объекта Fraction с заданным числителем и знаменателем
    public Fraction(int numerator, int denominator)
    {
        if (denominator == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю.");
        }

        this.numerator = numerator;
        this.denominator = denominator;
    }

    // Конструктор для создания объекта Fraction с целым числом (знаменатель по умолчанию 1)
    public Fraction(int wholeNumber)
    {
        this.numerator = wholeNumber;
        this.denominator = 1;
    }

    // Метод для нахождения наибольшего общего делителя (НОД)
    private static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }

    // Перегрузка оператора сложения
    public static Fraction operator +(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.denominator * fraction2.denominator;
        int newNumerator1 = fraction1.numerator * fraction2.denominator;
        int newNumerator2 = fraction2.numerator * fraction1.denominator;
        int sumNumerator = newNumerator1 + newNumerator2;
        int gcd = FindGCD(sumNumerator, commonDenominator);

        return new Fraction(sumNumerator / gcd, commonDenominator / gcd);
    }

    // Перегрузка оператора вычитания
    public static Fraction operator -(Fraction fraction1, Fraction fraction2)
    {
        int commonDenominator = fraction1.denominator * fraction2.denominator;
        int newNumerator1 = fraction1.numerator * fraction2.denominator;
        int newNumerator2 = fraction2.numerator * fraction1.denominator;
        int diffNumerator = newNumerator1 - newNumerator2;
        int gcd = FindGCD(diffNumerator, commonDenominator);

        return new Fraction(diffNumerator / gcd, commonDenominator / gcd);
    }

    // Перегрузка оператора умножения
    public static Fraction operator *(Fraction fraction1, Fraction fraction2)
    {
        int newNumerator = fraction1.numerator * fraction2.numerator;
        int newDenominator = fraction1.denominator * fraction2.denominator;
        int gcd = FindGCD(newNumerator, newDenominator);

        return new Fraction(newNumerator / gcd, newDenominator / gcd);
    }

    // Перегрузка оператора деления
    public static Fraction operator /(Fraction fraction1, Fraction fraction2)
    {
        if (fraction2.numerator == 0)
        {
            throw new DivideByZeroException("Деление на ноль.");
        }

        int newNumerator = fraction1.numerator * fraction2.denominator;
        int newDenominator = fraction1.denominator * fraction2.numerator;
        int gcd = FindGCD(newNumerator, newDenominator);

        return new Fraction(newNumerator / gcd, newDenominator / gcd);
    }

    // Перегрузка оператора присвоения (клонирование объекта)
    public static Fraction operator +(Fraction fraction)
    {
        return new Fraction(fraction.numerator, fraction.denominator);
    }

    // Перегрузка оператора отношения (сравнение)
    public static bool operator ==(Fraction fraction1, Fraction fraction2)
    {
        return fraction1.Equals(fraction2);
    }

    public static bool operator !=(Fraction fraction1, Fraction fraction2)
    {
        return !fraction1.Equals(fraction2);
    }

    // Переопределение метода Equals для сравнения объектов Fraction
    public override bool Equals(object obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }

        Fraction otherFraction = (Fraction)obj;
        return this.numerator == otherFraction.numerator && this.denominator == otherFraction.denominator;
    }

    // Переопределение метода GetHashCode для корректной работы с коллекциями
    public override int GetHashCode()
    {
        return HashCode.Combine(numerator, denominator);
    }

    // Переопределение метода ToString для вывода дроби в виде строки
    public override string ToString()
    {
        return numerator + "/" + denominator;
    }
}

class Program
{
    static void Main()
    {
        // Создание исходных дробей
        Fraction fraction1 = new Fraction(1, 2);
        Fraction fraction2 = new Fraction(3, 4);
        Fraction fraction3 = new Fraction(2);

        // Сохранение копий исходных дробей
        Fraction originalFraction1 = new Fraction(fraction1.Numerator, fraction1.Denominator); // Копия fraction1
        Fraction originalFraction2 = new Fraction(fraction2.Numerator, fraction2.Denominator); // Копия fraction2
        Fraction originalFraction3 = new Fraction(fraction3.Numerator, fraction3.Denominator); // Копия fraction3

        // Тестирование операторов
        Fraction sum = fraction1 + fraction2;
        Fraction difference = fraction1 - fraction2;
        Fraction product = fraction1 * fraction2;
        Fraction quotient = fraction1 / fraction2;

        Console.WriteLine("Исходные дроби:");
        Console.WriteLine("fraction1: " + originalFraction1);
        Console.WriteLine("fraction2: " + originalFraction2);
        Console.WriteLine("fraction3: " + originalFraction3);

        Console.WriteLine("\nСумма: " + sum);
        Console.WriteLine("Разность: " + difference);
        Console.WriteLine("Произведение: " + product);
        Console.WriteLine("Частное: " + quotient);

        // Тестирование операторов сравнения
        Console.WriteLine("\nСравнение fraction1 и fraction2: " + (fraction1 == fraction2));
        Console.WriteLine("Сравнение fraction1 и fraction3: " + (fraction1 == fraction3));

        // Создание массива дробей и изменение каждого элемента с парным индексом
        Fraction[] fractionsArray = new Fraction[]
        {
            new Fraction(1, 1),
            new Fraction(2, 3),
            new Fraction(3, 4),
            new Fraction(4, 5),
            new Fraction(5, 6)
        };

        for (int i = 0; i < fractionsArray.Length; i += 2)
        {
            if (i + 1 < fractionsArray.Length)
            {
                fractionsArray[i] += fractionsArray[i + 1];
            }
        }

        // Вывод массива после изменения
        Console.WriteLine("\nМассив после изменения:");
        foreach (Fraction fraction in fractionsArray)
        {
            Console.WriteLine(fraction);
        }
    }
}