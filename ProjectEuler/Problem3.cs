using ProjectEuler.Libraries;
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

        PrimeNumbers primes = new PrimeNumbers();
        List<ulong> primeFactors = primes.GetPrimeFactors(num);

        return primeFactors.Max();
    }
}