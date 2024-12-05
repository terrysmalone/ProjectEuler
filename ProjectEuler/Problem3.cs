using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem3
{
    internal ulong GetLargestPrimeFactors(ulong num)
    {
        if (num == 0)
        {
            return num;
        }

        bool factored = false;

        List<ulong> primeFactors = new List<ulong>();
        ulong current = num;

        while (!factored)
        {
            if (current % 2 == 0)
            {
                primeFactors.Add(2);
                current /= 2;
                continue;
            } 
            else
            {
                for (ulong i = 3; i < Math.Sqrt(current); i+=2)
                {
                    if (current % i == 0)
                    {
                        primeFactors.Add(i);
                        current /= i;
                        continue;
                    }
                }
            }

            primeFactors.Add(current);

            factored = true;
        }

        return primeFactors.Max();
    }
}