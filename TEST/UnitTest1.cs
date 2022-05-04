using System;
using NUnit.Framework;
using Task;


public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void GetPriceWithDiscount()
    {
        Rate rt = new Rate("Suramar", 100, 80);
        Assert.AreEqual(20,rt.GetPrice(),0.0000001);
    }
    [Test]
    public void GetPriceNoDiscount()
    {
        Rate rt = new Rate("Zuldarak", 100);
        Assert.AreEqual(100,rt.GetPrice());
    }
    [Test]
    public void GetCheapest()
    {
        Station st = new Station("Saratov");
        st.AddWithDiscount("Suramar",100,20);
        st.AddWNoDiscount("Zuldarak",70);
        Assert.AreEqual("Zuldarak 70",st.GetCheapest());
    }
    
}