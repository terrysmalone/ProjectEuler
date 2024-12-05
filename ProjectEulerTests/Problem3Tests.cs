using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
namespace ProjectEulerTests;

public class Problem3Tests
{
    [TestCase((ulong)0, (ulong)0)]
    [TestCase((ulong)1, (ulong)1)]
    [TestCase((ulong)2, (ulong)2)]
    [TestCase((ulong)3, (ulong)3)]
    [TestCase((ulong)4, (ulong)2)]
    [TestCase((ulong)5, (ulong)5)]
    [TestCase((ulong)10, (ulong)5)]
    [TestCase((ulong)13195, (ulong)29)]
    public void TestProblem(ulong number, ulong expected)
    {
        Problem3 problem = new Problem3();
        ulong result = problem.GetLargestPrimeFactors(number);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem3 problem = new Problem3();
        ulong result = problem.GetLargestPrimeFactors(600851475143);

        Assert.That(result, Is.EqualTo(6857));
    }
}
