using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        int m = int.Parse(Console.ReadLine());

        // Создаем и заполняем динамическую матрицу случайными числами
        int[][] matrix = GenerateRandomMatrix(n, m);

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);

        // Сортируем строки матрицы по сумме положительных четных элементов
        SortMatrixByPositiveEvenSum(matrix);

        Console.WriteLine("\nМатрица, отсортированная по сумме положительных четных элементов:");
        PrintMatrix(matrix);
    }

    // Генерация случайной матрицы
    static int[][] GenerateRandomMatrix(int n, int m)
    {
        Random random = new Random();
        int[][] matrix = new int[n][];

        for (int i = 0; i < n; i++)
        {
            matrix[i] = new int[m];
            for (int j = 0; j < m; j++)
            {
                matrix[i][j] = random.Next(-100, 100); // Задайте диапазон случайных чисел по вашему выбору
            }
        }

        return matrix;
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
                Console.Write(matrix[row][col] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Функция для суммирования положительных четных элементов в строке
    static int SumPositiveEvenElements(int[] row)
    {
        int sum = 0;

        foreach (int element in row)
        {
            if (element > 0 && element % 2 == 0)
            {
                sum += element;
            }
        }

        return sum;
    }

    // Функция для сортировки матрицы по сумме положительных четных элементов
    static void SortMatrixByPositiveEvenSum(int[][] matrix)
    {
        Array.Sort(matrix, (row1, row2) => SumPositiveEvenElements(row1).CompareTo(SumPositiveEvenElements(row2)));
    }
}
