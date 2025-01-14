using ProjectEuler.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal class Problem10
{
    internal static ulong GetSummationOfPrimes(ulong max)
    {
        var primeNumbers = new PrimeNumbers();
        List<ulong> primes = primeNumbers.GetPrimeNumbersTo(max);

        return primes.Aggregate((a, b) => a + b);
    }
}
