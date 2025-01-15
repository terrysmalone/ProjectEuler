using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Libraries;
internal static class Factors
{
    // Get factors of a number
    internal static List<ulong> GetFactors(ulong num)
    {
        // 1 and the number itself are always factors
        var factors = new List<ulong>() { 1, num };

        for (ulong i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                factors.Add(i);
                // If the factor is not the square root of the number, add the other factor
                if (i != Math.Sqrt(num))
                {
                    factors.Add(num / i);
                }
            }
        }

        return factors;
    }
}
