using NUnit.Framework;

namespace Task1_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Even()
    {
        Assert.False(Calc.IsOdd(144));
    }
    [Test]
    public void Odd()
    {
        Assert.True(Calc.IsOdd(169));
    }
    [Test]
    public void Zero()
    {
        Assert.False(Calc.IsOdd(0));
    }
}