using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem6Tests
{
    [TestCase(1, 10, 2640)]
    public void TestProblem(int min, int max, int expected)
    {
        Problem6 problem = new Problem6();
        int result = problem.GetSumSquareDifference(min, max);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem6 problem = new Problem6();
        int result = problem.GetSumSquareDifference(1, 100);

        Assert.That(result, Is.EqualTo(25164150));
    }
}