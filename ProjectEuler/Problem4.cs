using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler;
internal sealed class Problem4
{
    internal int GetLargestPalindromeProduct(int min, int max)
    {
        // Lets just brute force it
        int largestPalindrome = 0;
        for (int i = max; i >= min; i--)
        {
            for (int j = max; j >= min; j--)
            {
                int product = i * j;

                if (IsPalindrome(product))
                {
                    if (product > largestPalindrome)
                    {
                        largestPalindrome = product;
                    }
                }
            }
        }

        return largestPalindrome;
    }

    private static bool IsPalindrome(int number)
    {
        string numAsString = number.ToString();

        char[] numArray = numAsString.ToCharArray();
        Array.Reverse(numArray);
        string reversed = new string(numArray);

        if (numAsString == reversed)
        {
            return true;
        }

        return false;
    }
}
