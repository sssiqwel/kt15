using System;
using System.Collections;
using System.Collections.Generic;

public class PrimeNumbers : IEnumerator<int>
{
    private int current = 1;
    private bool disposed = false;

    public int Current
    {
        get
        {
            if (current < 2)
                throw new InvalidOperationException("Перечислитель не установлен на элемент");
            return current;
        }
    }

    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        if (current < 2)
        {
            current = 2;
            return true;
        }

        do
        {
            current++;
        }
        while (!IsPrime(current));

        return true;
    }

    public void Reset()
    {
        current = 1;
    }

    public void Dispose()
    {
        disposed = true;
    }

    private bool IsPrime(int number)
    {
        if (number < 2) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        for (int i = 3; i * i <= number; i += 2)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }
}