using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem10Tests
{
    [TestCase((ulong)9, (ulong)17)]
    public void TestProblem(ulong num, ulong expected)
    {
        ulong result = Problem10.GetSummationOfPrimes(num);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem10 problem = new Problem10();
        ulong result = Problem10.GetSummationOfPrimes(1999999);

        Assert.That(result, Is.EqualTo(142913828922));
    }
}