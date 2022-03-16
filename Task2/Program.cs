//вар 2
double x, y;

while (true)
{
    Console.WriteLine("Enter x and y coordinates");
    x=Convert.ToDouble(Console.ReadLine());
    y=Convert.ToDouble(Console.ReadLine());
    
    switch (Calc.InArea(x, y))
    {
        case 0:
            Console.WriteLine("within the area");
            break;
        case 1:
            Console.WriteLine("on the broder");
            break;
        case -1:
            Console.WriteLine("out of area");
            break;
    }

    Console.WriteLine("1 - repeat\n2 - end");
    int a = Convert.ToInt32(Console.ReadLine());
    switch (a)
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
    public static int InArea(double x, double y)
    {
        int val;
        if (y >= 0)
        {
            double length = Math.Sqrt(x * x + y * y);
            if (length == 3 || (y==0 && x>=-3 && x<=3))
            {
                return 1; //на границе
            }else if (length < 3)
                return 0; //внутри
            else
            {
                return -1;
            }
        }
        else
        {
            return -1;//вне области
        }

     
    }
}