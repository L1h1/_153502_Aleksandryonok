// вар 2


using Task1;

Console.WriteLine("enter 2 integers \n");
int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
int result = Calculator.Max(x, 2 * y + x) - Calculator.Max(7 * x + 2 * y, y);
Console.WriteLine($"{result}");
    