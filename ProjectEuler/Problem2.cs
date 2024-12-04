using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;

internal sealed  class Problem2
{
    internal int GetEvenFibonacciNumbers(int below)
    {
        int previous = 0;
        int current = 1;

        int total = 0;

        while (current < below)
        {
            int saved = current;

            current = current + previous;
            previous = saved;

            if (current < below && current % 2 == 0)
            {
                total += current;
            }
        }

        return total;
    }
}
