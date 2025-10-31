using System;
using System.Collections;
using System.Collections.Generic;

public class Matrix
{
    private double[,] data;

    public int Rows { get; private set; }
    public int Columns { get; private set; }

    public Matrix(int rows, int columns)
    {
        Rows = rows;
        Columns = columns;
        data = new double[rows, columns];
    }

    public double this[int row, int column]
    {
        get => data[row, column];
        set => data[row, column] = value;
    }

    public IEnumerable<double> GetRow(int index)
    {
        if (index < 0 || index >= Rows)
            throw new ArgumentOutOfRangeException(nameof(index));

        for (int j = 0; j < Columns; j++)
        {
            yield return data[index, j];
        }
    }

    public IEnumerable<double> GetColumn(int index)
    {
        if (index < 0 || index >= Columns)
            throw new ArgumentOutOfRangeException(nameof(index));

        for (int i = 0; i < Rows; i++)
        {
            yield return data[i, index];
        }
    }

    public void FillRandom(double min = 0, double max = 10)
    {
        Random random = new Random();
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                data[i, j] = random.NextDouble() * (max - min) + min;
            }
        }
    }
}