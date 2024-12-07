using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Libraries;
internal sealed class PrimeNumbers
{
    // Get the first num prime numbers
    internal List<ulong> GetPrimeNumbers(ulong num)
    {
        if (num == 0)
        {
            throw new ArgumentException();
        }

        ulong current = 2;
        List<ulong> primeNumbers = new List<ulong>() {  current };
        ulong count = 1;

        current = 3;
        
        while (count < num)
        {
            // Even numbers past 2 aren't prime
            if (current % 2 != 0)
            {
                if (GetPrimeFactors(current).Count() == 1)
                {
                    primeNumbers.Add(current);
                    count++;
                }
            }

            current++;
        }

        return primeNumbers;
    }

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
                for (ulong i = 3; i <= Math.Sqrt(current); i += 2)
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
