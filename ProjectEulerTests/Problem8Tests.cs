using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem8Tests
{
    [TestCase(1, (ulong)9)]
    [TestCase(2, (ulong)81)]
    [TestCase(4, (ulong)5832)]
    public void TestProblem(int num, ulong expected)
    {
        Problem8 problem = new Problem8();
        ulong result = problem.GetHighestAdjacentProduct(num);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem8 problem = new Problem8();
        ulong result = problem.GetHighestAdjacentProduct(13);

        Assert.That(result, Is.EqualTo((ulong)23514624000));
    }
}