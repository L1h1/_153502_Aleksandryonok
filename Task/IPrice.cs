namespace Task;

public interface IPrice
{
    double GetPrice();
}

public class AbsDiscount : IPrice
{
    private double _price;
    private double _discount;

    public AbsDiscount(double price, double discount)
    {
        _price = price;
        _discount = discount;
    }

    public double GetPrice()
    {
        return _price * (1-_discount * 1e-2);
    }
}
public class NoDiscount : IPrice
{
    private double _price;

    public NoDiscount(double price)
    {
        _price = price;
    }

    public double GetPrice()
    {
        return _price;
    }
}