using Task;

Rational r0 = new Rational(13, 0);
Rational r1 = new Rational(12,24);
Rational r2 = new Rational(12,24); 
Console.WriteLine(r0.toString());
Console.WriteLine(r1.toString());
Console.WriteLine("-------------*------------");
var r3 = r1+r2;
var r5 = r1 - r2;
var r4 = r1 / r2;
var r6 = r1 * r2;

Console.WriteLine(r3.toString());
Console.WriteLine(r5.toString());
Console.WriteLine(r4.toString());
Console.WriteLine(r6.toString());

Console.WriteLine("-------------*------------");
r3.Normalize();
r4.Normalize();
r5.Normalize();
r6.Normalize();


Console.WriteLine(r3.toString());
Console.WriteLine(r5.toString());
Console.WriteLine(r4.toString());
Console.WriteLine(r6.toString());
Console.WriteLine("-------------*------------");

Rational r7 = new Rational(1,2);
Rational r8 = new Rational(2,5);
Console.WriteLine(r7>r8);
Console.WriteLine(r3==r4);
Console.WriteLine("-------------*------------");
Rational r9 = new Rational(25,625);
Console.WriteLine(r9.GetGcd());
Console.WriteLine("-------------*------------");

Rational r10 = new Rational(50, 25);
Console.WriteLine((int)r10);

