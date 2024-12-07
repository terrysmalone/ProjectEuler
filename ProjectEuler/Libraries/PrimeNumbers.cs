using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Libraries;
internal sealed class PrimeNumbers
{
    // Get the prime factors of a given number 
    internal List<ulong> GetPrimeFactors(ulong num)
    {
        if (num <= 1)
        {
            throw new ArgumentException("Numbers below 2 have no prime factors");
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
                for (ulong i = 3; i < Math.Sqrt(current); i += 2)
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

        return primeFactors;
    }
}
