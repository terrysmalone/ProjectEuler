using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem4Tests
{
    [TestCase(0, 10, 0)]
    [TestCase(0, 11, 121)]
    [TestCase(10, 99, 9009)]
    public void TestProblem(int min, int max, int expected)
    {
        Problem4 problem = new Problem4();
        int result = problem.GetLargestPalindromeProduct(min, max);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem4 problem = new Problem4();
        int result = problem.GetLargestPalindromeProduct(100, 999);

        Assert.That(result, Is.EqualTo(906609));
    }
}
