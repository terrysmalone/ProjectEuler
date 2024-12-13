using ProjectEuler.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem9
{
    internal int GetPythagoreanTripletProduct(int num)
    {
        // Lets start by brute forcing it. We can get 
        // more elegant as needed.

        // Assumption:
        // There is only one pythagorean triplet of num.
        // It'll just return the first match

        // Rules:
        // a < b < c
        // a^2 + b^2 = c^2
        // a + b + c = num 
        for (int c = num - 3; c >= 3; c--)
        {
            for (int b = c - 1; b >= 2; b--)
            {
                if (c + b >= num)
                {
                    continue;
                }

                for (int a = b - 1; a >= 1; a--)
                {
                    if (a + b + c != num)
                    {
                        continue;
                    }

                    if ((a * a) + (b * b) == c * c)
                    {
                        return a * b * c;
                    }
                }
            }
        }

        return -1;
    }
}