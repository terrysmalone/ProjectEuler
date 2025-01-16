using ProjectEuler.Libraries;
using System.Collections;
using System.Numerics;

namespace ProjectEuler;
internal sealed class Problem15
{
    // We can get the lattice path count using the factorials of x and y
    // = (x + y)! / x! . y!
    internal BigInteger GetLatticePathLength(int x, int y)
    {
        return CalculateFactorial(x + y) / (CalculateFactorial(x) * CalculateFactorial(y));
    }

    private BigInteger CalculateFactorial(int num)
    {
        BigInteger result = 1;

        for (var i = num; i >= 1; i--)
        {
            result *= i;
        }

        return result;
    }
}
