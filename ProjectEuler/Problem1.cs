namespace ProjectEuler;

// https://projecteuler.net/problem=1
public class Problem1
{
    public int GetMultiplesOf3or5(int numsBelow)
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
