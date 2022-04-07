using NUnit.Framework;
using Task;

namespace TEST;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestName()
    {
        Station s = Station.GetInstance();
        s.SetName("TEST");
        Assert.AreEqual(s.GetName(),"TEST");
    }
    [Test]
    public void TestPriceIncrease1()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(10);
        s.StationSetSold(10);
        s.StationSetPlace(30);
        Assert.AreEqual(s.StationGetUnsold(),200);
    }
    [Test]
    public void TestPriceIncrease2()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(10);
        s.StationIncreasePrice(); //+10
        s.StationSetSold(10);
        s.StationSetPlace(30);
        Assert.AreEqual(s.StationGetUnsold(),400);
    }
    [Test]
    public void TestPriceIncrease3()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(10);
        s.StationIncreasePrice(1); 
        s.StationSetSold(10);
        s.StationSetPlace(30);
        Assert.AreEqual(s.StationGetUnsold(),220);
    }
    [Test]
    public void TestSetPrice()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(54678);
        Assert.AreEqual(s.StationGetPrice(),54678);
    }
    [Test]
    public void TestSetPlace()
    {
        Station s = Station.GetInstance();
        s.StationSetPlace(54678);
        Assert.AreEqual(s.StationGetPlace(),54678);
    }
    [Test]
    public void TestDecreasePrice()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(54678);
        s.StationDecreasePrice(10000);
        Assert.AreEqual(s.StationGetPrice(),44678);
    }
    [Test]
    public void TestDecreaseInNegative()
    {
        Station s = Station.GetInstance();
        s.StationSetPrice(10000);
        s.StationDecreasePrice(20000);
        Assert.AreEqual(s.StationGetPrice(),10000);
    }
}