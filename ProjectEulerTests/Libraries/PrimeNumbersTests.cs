using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
using ProjectEuler.Libraries;
namespace ProjectEulerTests;

public class PrimeNumbersTests
{
    [TestCase((ulong)10, new ulong[]{ 2, 5 })]
    [TestCase((ulong)13195, new ulong[] { 5, 7, 13, 29 })]
    public void TestGetPrimeFactors(ulong num, ulong[] expected)
    {
       PrimeNumbers primeNumbers = new PrimeNumbers();
       List<ulong> result = primeNumbers.GetPrimeFactors(num);

        Assert.That(result, Is.EqualTo(expected.ToList()));
    }

    [TestCase((ulong)0)]
    [TestCase((ulong)1)]
    public void TestGetPrimeFactorsErrors(ulong num)
    {
        PrimeNumbers primeNumbers = new PrimeNumbers();
        Assert.Throws<ArgumentException>(() => primeNumbers.GetPrimeFactors(num));
    }
}
