using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem7Tests
{
    [TestCase((ulong)1, (ulong)2)]
    [TestCase((ulong)2, (ulong)3)]
    [TestCase((ulong)6, (ulong)13)]
    public void TestProblem(ulong num, ulong expected)
    {
        Problem7 problem = new Problem7();
        ulong result = problem.GetPrimeNumber(num);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem7 problem = new Problem7();
        ulong result = problem.GetPrimeNumber(10001);

        Assert.That(result, Is.EqualTo(104743));
    }
}