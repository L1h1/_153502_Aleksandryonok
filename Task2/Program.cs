using Task2.Services;

Console.WriteLine("Enter integer a,b,z");

int a=Convert.ToInt32(Console.ReadLine());
int b=Convert.ToInt32(Console.ReadLine());
int z=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Function result:{Calculator.ProcessFunction(a,b,z)}");