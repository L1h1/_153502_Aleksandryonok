using NUnit.Framework;
using Task1;

namespace Test1;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void EqualXandY()
    {
        Assert.AreEqual(Calculator.max(1, 1), 1);
    }
    [Test]
    public void XbiggerThanY()
    {
        Assert.AreEqual(Calculator.max(534, 1), 534);
    }
    [Test]
    public void XlesserThanY()
    {
        Assert.AreEqual(Calculator.max(1, 534), 534);
    }
    [Test]
    public void OutputComparison()
    {
        Assert.AreEqual(Calculator.max(354, 1), Calculator.max(1,354));
    }
}