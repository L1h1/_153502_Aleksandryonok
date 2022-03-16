using NUnit.Framework;

namespace Task2_test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Border_1()
    {
        Assert.AreEqual(Calc.InArea(-3,0),1);
    }
    [Test]
    public void Border_2()
    {
        Assert.AreEqual(Calc.InArea(0,3),1);
    }
    [Test]
    public void Border_3()
    {
        Assert.AreEqual(Calc.InArea(0,0),1);
    }
    [Test]
    public void Border_4()
    {
        Assert.AreEqual(Calc.InArea(0,3),1);
    }
    [Test]
    public void Outside()
    {
        Assert.AreEqual(Calc.InArea(0,-1),-1);
    }
    [Test]
    public void Inside()
    {
        Assert.AreEqual(Calc.InArea(2,1),0);
    }
    
}