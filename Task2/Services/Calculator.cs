namespace Task2.Services;

public class Calculator
{
    public static double ProcessFunction(int a, int b, int z)
    {
        double x;
        if (z < a * b)
        {
            x = Math.Sqrt(a * a + b * b * z);
            Console.WriteLine("...calculating 1st branch...");
        }
        else
        {
            x = Math.Pow(Math.Sin(z), 2) + Math.Abs(a * b * z);
            Console.WriteLine("...calculating 2nd branch...");
        }

      
        return (a * x + b * x * Math.Cos(Math.Sqrt(x))) / (x + a * b);  
    }
}