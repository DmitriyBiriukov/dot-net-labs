using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите количество строк матрицы: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введите количество столбцов матрицы: ");
        int m = int.Parse(Console.ReadLine());

        // Создаем динамическую матрицу
        int[,] matrix = new int[n, m];
        int value = 1;

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = value;
                value++;
            }
        }

        Console.WriteLine("\nИсходная матрица:");
        PrintMatrix(matrix);

        // Создаем и отображаем матрицу, отраженную относительно главной диагонали
        int[,] reflectedMatrix = ReflectMatrix(matrix);
        Console.WriteLine("\nМатрица, отраженная относительно главной диагонали:");
        PrintMatrix(reflectedMatrix);
    }

    // Функция для отображения матрицы
    static void PrintMatrix(int[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }
    }

    // Функция для отражения матрицы относительно главной диагонали
    static int[,] ReflectMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] reflectedMatrix = new int[cols, rows];

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                reflectedMatrix[col, row] = matrix[row, col];
            }
        }

        return reflectedMatrix;
    }
}
