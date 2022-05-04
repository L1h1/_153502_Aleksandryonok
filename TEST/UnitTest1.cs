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
    public void printNameNoOverload()
    {
        School sc = new School("abauba", 15, 15);
        Assert.AreEqual(sc.PrintName(),"учреждение образования abauba");
    }
    [Test]
    public void printNameOverload()
    {
        University sc = new University("abauba", 15);
        Assert.AreEqual(sc.PrintName(),"Добро пожаловать в университет abauba!");
    }
    [Test]
    public void Dynamics()
    {
        University sc = new University("abauba", 15);
        sc.FailCount = 100;
        Assert.AreEqual(sc.GetFailDynamic(),85);
    }
    [Test]
    public void PrintInf()
    {
        University sc = new University("abauba", 15);
        sc.FailCount = 100;
        Assert.AreEqual(sc.PrintInfo(),"число несдавших лабы: 100");
    }
    
}