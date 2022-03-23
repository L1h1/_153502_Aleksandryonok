using System;
using NUnit.Framework;
using Task3;

namespace Test3;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetDayTest()
    {
        Assert.AreEqual("15.04.2021",DateService.GetDay("15 04 2021").ToShortDateString());
    }
    [Test]
    public void FirstDay()
    {
        Assert.AreEqual("01.01.0001",DateService.GetDay("01 01 0001").ToShortDateString());
    }
    [Test]
    public void ExactDifference()
    {
        Assert.AreEqual(DateService.GetDaysSpan(20,03,2023),(DateService.GetDay("20 03 2023")-DateTime.Today).TotalDays);
    }
    [Test]
    public void SameDay()
    {
        DateTime d=DateTime.Today;
        Assert.AreEqual(0,DateService.GetDaysSpan(d.Day,d.Month,d.Year));
    }
    [Test]
    public void WasBefore()
    {
        
        Assert.Less(DateService.GetDaysSpan(20,03,2000),0);
    }
    [Test]
    public void InFuture()
    {
        
        Assert.Greater(DateService.GetDaysSpan(20,03,2023),0);
    }
    
}