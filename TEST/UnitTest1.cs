using System;
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
    public void OperatorPlus()
    {
        Rational r1 = new Rational(12,24); 
        Rational r2 = new Rational(12,24);
        Assert.True(new Rational(576,576)== (r1 + r2));
    }
    [Test]
    public void OperatorMinus()
    {
        Rational r1 = new Rational(12,24); 
        Rational r2 = new Rational(11,24);
        Assert.True(new Rational(24,576)== (r1 -r2));
    }
    [Test]
    public void OperatorIncrement()
    {
        Rational r1 = new Rational(12,24);
        r1++;
        Console.WriteLine(r1.toString());
        Assert.True(r1==new Rational(13,25));
    }
    [Test]
    public void OperatorDecrement()
    {
        Rational r1 = new Rational(13,24);
        r1--;
        Console.WriteLine(r1.toString());
        Assert.True(r1==new Rational(12,23));
    }
    [Test]
    public void OperatorMultiply()
    {
        Rational r1 = new Rational(12,24); 
        Rational r2 = new Rational(12,24);
        Assert.True(new Rational(144,576)== (r1 * r2));
    }
    [Test]
    public void OperatorDivide()
    {
        Rational r1 = new Rational(12,24); 
        Rational r2 = new Rational(12,24);
        Assert.True(new Rational(288,288)== (r1 / r2));
    }

    [Test]
    public void Conversion()
    {
        Rational r1 = new Rational(51,24); 
        Assert.AreEqual((int)r1,2);
    }
    [Test]
    public void Gcd()
    {
        Rational r1 = new Rational(625,25); 
        Assert.AreEqual(r1.GetGcd(),25);
    }
    
}