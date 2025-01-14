using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem11Tests
{
    [Test]
    public void TestSolution()
    {
        var problem = new Problem11();
        int result = problem.GetLargestProduct();

        Assert.That(result, Is.EqualTo(70600674));
    }
}