using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem13Tests
{
    [Test]
    public void TestSolution()
    {
        var problem = new Problem13();
        ulong result = problem.GetLargeSum(10);

        Assert.That(result, Is.EqualTo(5537376230));
    }
}