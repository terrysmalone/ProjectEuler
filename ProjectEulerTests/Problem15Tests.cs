using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem15Tests
{
    [TestCase(1, 1, 2)]
    [TestCase(2, 2, 6)]
    [TestCase(2, 4, 15)]
    public void TestProblem(int x, int y, int expected)
    {
        var problem = new Problem15();
        BigInteger result = problem.GetLatticePathLength(x, y);

        Assert.That(result, Is.EqualTo(new BigInteger(expected)));
    }

    [Test]
    public void TestSolution()
    {
        var problem = new Problem15();
        BigInteger result = problem.GetLatticePathLength(20, 20);

        Assert.That(result, Is.EqualTo(new BigInteger(137846528820)));
    }
}