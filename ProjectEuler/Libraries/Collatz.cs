using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Libraries;

// A collatz sequence is a sequence of numbers where the next number
// in the sequence is n / 2 if n is even or 3n + 1 if n is odd
internal sealed class Collatz
{
    Hashtable _hashTable = new Hashtable();

    internal List<ulong> GetCollatzChain(ulong num)
    {
        var chain = new List<ulong>();

        chain.Add(num);

        while (num != 1)
        {
            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = num * 3 + 1;
            }

            chain.Add(num);
        }

        return chain;
    }

    internal ulong GetCollatzChainLength(ulong num)
    {
        var startNum = num;
        ulong length = 1;

        while (num != 1)
        {
            if (_hashTable.ContainsKey(num))
            {
                return (ulong)_hashTable[num] + length - 1;
            }

            if (num % 2 == 0)
            {
                num /= 2;
            }
            else
            {
                num = 3 * num + 1;
            }

            length++;

            if (length > 1000)
            {
                throw new Exception($"Collatz chain length exceeded 1000 for {startNum}");
            }
        }

        _hashTable.Add(startNum, length);

        return length;
    }
}
