using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(int [] multiples, int max)
    {
        return Enumerable.Range(1, max - 1)
             .Where(divides(multiples))
             .Aggregate(0, (a, b) => a + b);
    }

    private static Func<int, bool> divides(int[] multiples)
    {
        return n => multiples.Where(m => n % m == 0).Count() > 0;
    }
}