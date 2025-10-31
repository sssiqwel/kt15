using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        using (PrimeNumbers primeEnumerator = new PrimeNumbers())
        {
            Console.WriteLine("Первые 10 простых чисел:");
            int count = 0;

            while (primeEnumerator.MoveNext() && count < 10)
            {
                Console.WriteLine(primeEnumerator.Current);
                count++;
            }
        }
    }
}