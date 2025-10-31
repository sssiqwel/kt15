using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Fibonacci fibonacci = new Fibonacci();

        Console.WriteLine("Первые 10 чисел Фибоначчи:");
        int count = 0;
        foreach (int number in fibonacci)
        {
            if (count >= 10) break;
            Console.WriteLine(number);
            count++;
        }
    }
}