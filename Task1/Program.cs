// вар 2


using Task1;

Console.WriteLine("enter 2 integers \n");
int x, y;
x = Convert.ToInt32(Console.ReadLine());
y = Convert.ToInt32(Console.ReadLine());
int result = Calculator.max(x, 2 * y + x) - Calculator.max(7 * x + 2 * y, y);
Console.WriteLine($"{result}");
    