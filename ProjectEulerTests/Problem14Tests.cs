using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem14Tests
{
    [TestCase((ulong)11, (ulong)9)]
    public void TestProblem(ulong num, ulong expected)
    {
        var problem = new Problem14();
        ulong result = problem.GetLongestCollatzChain(num);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        var problem = new Problem14();
        ulong result = problem.GetLongestCollatzChain(999999);

        Assert.That(result, Is.EqualTo(837799));
    }
}