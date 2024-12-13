using System;
using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem9Tests
{
    [TestCase(12, 60)]
    public void TestProblem(int num, int expected)
    {
        Problem9 problem = new Problem9();
        int result = problem.GetPythagoreanTripletProduct(12);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem9 problem = new Problem9();
        int result = problem.GetPythagoreanTripletProduct(1000);

        Assert.That(result, Is.EqualTo(31875000));
    }
}