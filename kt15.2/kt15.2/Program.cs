using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Matrix matrix = new Matrix(3, 4);
        matrix.FillRandom(1, 10);

        Console.WriteLine("Матрица 3x4:");
        for (int i = 0; i < matrix.Rows; i++)
        {
            Console.Write($"Строка {i}: ");
            foreach (double element in matrix.GetRow(i))
            {
                Console.Write($"{element:F2} ");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nВывод по столбцам:");
        for (int j = 0; j < matrix.Columns; j++)
        {
            Console.Write($"Столбец {j}: ");
            foreach (double element in matrix.GetColumn(j))
            {
                Console.Write($"{element:F2} ");
            }
            Console.WriteLine();
        }
    }
}