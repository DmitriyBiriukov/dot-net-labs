using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        int m = int.Parse(Console.ReadLine());

        // Создаем зубчатый двумерный массив
        int[][] matrix = new int[n][];

        // Инициализируем каждую строку массива
        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[m];
        }

        int value = 1;

        // Заполняем матрицу числами от 1 до n*m
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row][col] = value;
                value++;
            }
        }

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);

        // Создаем и отображаем матрицу, отраженную относительно главной диагонали
        int[][] reflectedMatrix = ReflectMatrix(matrix);
        Console.WriteLine("\nМатрица, отраженная относительно главной диагонали:");
        PrintMatrix(reflectedMatrix);
    }

    // Функция для отображения зубчатой матрицы
    static void PrintMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                // Цветной вывод для элементов матрицы
                Console.ForegroundColor = GetColor(matrix[row][col]);
                Console.Write(matrix[row][col] + "\t");
                Console.ResetColor(); // Сброс цвета
            }
            Console.WriteLine();
        }
    }

    // Функция для отражения матрицы относительно главной диагонали
    static int[][] ReflectMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int[][] reflectedMatrix = new int[cols][];

        for (int col = 0; col < cols; col++)
        {
            reflectedMatrix[col] = new int[rows];
            for (int row = 0; row < rows; row++)
            {
                reflectedMatrix[col][row] = matrix[row][col];
            }
        }

        return reflectedMatrix;
    }

    // Функция для выбора цвета в зависимости от значения элемента
    static ConsoleColor GetColor(int value)
    {
        // Примеры цветов можно настроить по вашему выбору
        if (value % 2 == 0)
        {
            return ConsoleColor.Blue;
        }
        else
        {
            return ConsoleColor.Red;
        }
    }
}