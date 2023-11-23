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
        foreach (int[] row in matrix)
        {
            foreach (int element in row)
            {
                Console.Write(element + "\t");
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
}
