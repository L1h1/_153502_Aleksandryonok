using NUnit.Framework;
using Task2.Services;
namespace Test2;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void IsNaN1()
    {
        Assert.IsNaN(Calculator.ProcessFunction(0,0,0));
    }
    [Test]
    public void IsNaN2()
    {
        Assert.IsNaN(Calculator.ProcessFunction(0,0,-568347));
    }
    [Test]
    public void ZeroOutput()
    {
        Assert.AreEqual(Calculator.ProcessFunction(0,0,58756),0);
    }
    [Test]
    public void FirstBranch()
    {
        Assert.AreEqual(Calculator.ProcessFunction(3,4,1),0.156149557,0.000000001);
    }
    [Test]
    public void SecondBranch()
    {
        Assert.AreEqual(Calculator.ProcessFunction(1,1,1),0.795236905,0.000000001);
    }
}