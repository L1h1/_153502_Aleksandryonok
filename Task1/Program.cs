// вар 2


while (true)
{
    Console.WriteLine("enter integer number");
int a = Convert.ToInt32(Console.ReadLine());

if(Calc.IsOdd(a))
    Console.WriteLine("is odd");
else
    Console.WriteLine("is even");


Console.WriteLine("1 - repeat\n2 - end");
int b = Convert.ToInt32(Console.ReadLine());
switch (b)
{
    case 1:
        break;
    case 2:
        return;
    default:
        Console.WriteLine("wrong input, finishing the work");
        return;
}
}


public class Calc
{
    public static bool IsOdd(int value)
    {
        if (value%2==1)
            return true;
        else
            return false;
    }
}