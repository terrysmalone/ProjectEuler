using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
using ProjectEuler.Libraries;
namespace ProjectEulerTests;

public class CollatzTests
{
    [TestCase((ulong)13, new ulong[] { 13, 40, 20, 10, 5, 16, 8, 4, 2, 1 })]
    public void TestGetCollatzChain(ulong startNum, ulong[] expected)
    {
        var collatz = new Collatz();
        List<ulong> result = collatz.GetCollatzChain(startNum);

        Assert.That(result, Is.EqualTo(expected.ToList()));
    }

    [TestCase((ulong)13, (ulong)10)]
    [TestCase((ulong)999999, (ulong)259)]
    public void TestGetCollatzChainLength(ulong startNum, ulong expected)
    {
        var collatz = new Collatz();
        ulong result = collatz.GetCollatzChainLength(startNum);

        Assert.That(result, Is.EqualTo(expected));
    }
}
