namespace ProjectEuler;

// https://projecteuler.net/problem=1
internal sealed class Problem1
{
    internal int GetMultiplesOf3or5(int numsBelow)
    {
        int total = 0;

        for (int i = 0; i < numsBelow; i++)
        {
            if (i % 3 == 0)
            {
                total += i;
            }
            else if (i % 5 == 0)
            {
                total += i;
            }
        }

        return total;
    }
}
