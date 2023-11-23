using System;

class Program
{
    static void Main()
    {
        // Создаем и заполняем квадратную матрицу 9x9 от 1 до 81
        int[,] matrix = new int[9, 9];
        int value = 1;
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                matrix[row, col] = value;
                value++;
            }
        }

        Console.WriteLine("Исходная матрица:");
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
