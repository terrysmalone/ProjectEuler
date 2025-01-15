using ProjectEuler.Libraries;
using System.Collections;

namespace ProjectEuler;
internal sealed class Problem14
{
    // Get the number under max that produces the longest collatz chain
    internal ulong GetLongestCollatzChain(ulong max)
    {
        ulong maxLength = ulong.MinValue;
        ulong maxIndex = ulong.MinValue;

        var collatz = new Collatz();

        for (ulong i = 1; i <= max; i++)
        {
            var length = collatz.GetCollatzChainLength(i);

            if (length > maxLength)
            {
                maxLength = length;
                maxIndex = i;
            }
        }

        return maxIndex;
    } 
}
