using ProjectEuler.Libraries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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

        for (int a = 1; a <= (num-3)/3; a++)
        {
            for(int b = a+1; b <= (num-a-1)/2; b++)
            {
                int c = num - a - b;
                if ((a*a) + (b*b) == c*c)
                {
                    return a * b * c;
                }
            }
        }

        Quaternion q = new Quaternion(new Vector3(1, 2, 3), 4);

        return -1;
    }
}