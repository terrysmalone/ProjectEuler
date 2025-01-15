using ProjectEuler.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem12
{
    // Get the first triangle number with more than the specified number of factors
    internal ulong GetDivisibleTriangleNumber(int numberOfFactors)
    {
        ulong total = 1;
        ulong latest = 2;

        while (true)
        {
            // Calculate factors
            List<ulong> factors = Factors.GetFactors(total);

            if (factors.Count > numberOfFactors)
            {
                return total;
            }

            total += latest;

            latest++;
        }
    } 
}
