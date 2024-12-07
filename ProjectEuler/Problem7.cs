using ProjectEuler.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem7
{
    internal ulong GetPrimeNumber(ulong num)
    {
        PrimeNumbers primes = new PrimeNumbers();
        List<ulong> primeNumbers = primes.GetPrimeNumbers(num);

        return primeNumbers.Last();

    }
}
