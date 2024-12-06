using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem6
{
    internal int GetSumSquareDifference(int min, int max)
    {
        // To calculate the difference between the sum of squares
        // and the square of sums of a range of numbers we could just
        // brute force it with for loops. But.....
        //
        // (a + b)^2 = a^2 + b^2 + 2ab
        // so the difference between the two is 2ab
        // or the difference is equal to the sum of all double products
        // So....
        int total = 0;

        for (int a = min; a < max; a++)
        {
            for (int b = a+1; b <= max; b++)
            {
                if (a != b)
                {
                    total += 2 * a * b;
                }
            }
        }

        return total;
    }
}
