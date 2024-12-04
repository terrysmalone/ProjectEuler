using System.Reflection.Metadata;
using ProjectEuler;
    
namespace ProjectEulerTests;

public class Problem2Tests
{
    [TestCase(0, 0)]
    [TestCase(1, 0)]
    [TestCase(2, 0)]
    [TestCase(3, 2)]
    [TestCase(10, 10)]
    [TestCase(100, 44)]
    public void TestProblem2(int below, int expected)
    {
        Problem2 problem = new Problem2();
        int result = problem.GetEvenFibonacciNumbers(below);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void TestSolution()
    {
        Problem2 problem = new Problem2();
        int result = problem.GetEvenFibonacciNumbers(4000000);

        Assert.That(result, Is.EqualTo(4613732));
    }
}