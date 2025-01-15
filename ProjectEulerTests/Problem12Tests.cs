using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem12Tests
{
    [TestCase(0, (ulong)1)]
    [TestCase(3, (ulong)6)]
    [TestCase(4, (ulong)28)]
    [TestCase(5, (ulong)28)]
    public void TestProblem(int num, ulong expected)
    {
        var problem = new Problem12();
        ulong result = problem.GetDivisibleTriangleNumber(num);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        var problem = new Problem12();
        ulong result = problem.GetDivisibleTriangleNumber(500);

        Assert.That(result, Is.EqualTo(76576500));
    }
}