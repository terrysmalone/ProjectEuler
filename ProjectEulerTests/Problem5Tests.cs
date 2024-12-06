using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem5Tests
{
    [TestCase(1, 1, 1)]
    [TestCase(1, 3, 6)]
    [TestCase(1, 10, 2520)]
    public void TestProblem(int min, int max, int expected)
    {
        Problem5 problem = new Problem5();
        int result = problem.GetSmallestMultiple(min, max);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem5 problem = new Problem5();
        int result = problem.GetSmallestMultiple(1, 20);

        Assert.That(result, Is.EqualTo(232792560));
    }
}