namespace _153502_Aleksandryonok;

public static class MainModule
{
    public static void Main(string[] args)
    {
        Console.WriteLine("enter 2 int values");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        double result = (double)a / b;
        Console.WriteLine($"Result: {result}");
    }
}