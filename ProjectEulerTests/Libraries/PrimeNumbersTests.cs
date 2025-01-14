using System.Numerics;
using System.Reflection.Metadata;
using ProjectEuler;
using ProjectEuler.Libraries;
namespace ProjectEulerTests;

public class PrimeNumbersTests
{
    [TestCase((ulong)5, new ulong[] { 2, 3, 5, 7, 11 })]
    [TestCase((ulong)10, new ulong[] { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29 })]
    public void TestGetPrimeNumbers(ulong num, ulong[] expected)
    {
        PrimeNumbers primeNumbers = new PrimeNumbers();
        List<ulong> result = primeNumbers.GetPrimeNumbers(num);

        Assert.That(result, Is.EqualTo(expected.ToList()));
    }

    [TestCase((ulong)9, new ulong[] { 2, 3, 5, 7 })]
    public void TestGetPrimeNumbersTo(ulong num, ulong[] expected)
    {
        PrimeNumbers primeNumbers = new PrimeNumbers();
        List<ulong> result = primeNumbers.GetPrimeNumbersTo(num);

        Assert.That(result, Is.EqualTo(expected.ToList()));
    }

    [TestCase((ulong)5, new ulong[] { 5 })]
    [TestCase((ulong)9, new ulong[] { 3, 3 })]
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
