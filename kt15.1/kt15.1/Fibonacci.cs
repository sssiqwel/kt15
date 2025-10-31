using System.Collections;
using System.Collections.Generic;

public class Fibonacci : IEnumerable<int>
{
    public IEnumerator<int> GetEnumerator()
    {
        int a = 0;
        int b = 1;

        yield return a;
        yield return b;

        while (true)
        {
            int next = a + b;
            yield return next;
            a = b;
            b = next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}