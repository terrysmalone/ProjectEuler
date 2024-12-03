using ProjectEuler;

namespace ProjectEulerTests;

public class Problem1Tests
{
    [TestCase(1, 0)]
    [TestCase(3, 0)]
    [TestCase(5, 3)]
    [TestCase(6, 8)]
    [TestCase(10, 23)]
    public void TestProblem1(int below, int expected)
    {
        Problem1 problem = new Problem1();

        Assert.That(problem.GetMultiplesOf3or5(below), Is.EqualTo(expected));
    }


    [Test]
    public void TestProblem1Solution()
    {
        Problem1 problem = new Problem1();

        Assert.That(problem.GetMultiplesOf3or5(1000), Is.EqualTo(233168));
    }
}