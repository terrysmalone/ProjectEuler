using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem5
{
    internal int GetSmallestMultiple(int min, int max)
    {
        int current = 0;
        bool found = false;

        while (!found)
        {
            current += max;
            found = true;

            for (int i = min; i < max; i++)
            {
                if (current % i != 0)
                {
                    found = false;
                    break;
                }
            }
        }

        return current;
    }
}
