namespace Task;

public class Rate
{
    private IPrice ip;  //ссылка на интерфейс
    private string _name;
    public string Name
    {
        get
        {
            return _name;
        }
        set
        {
            _name = value;
        }
        
    }
    public Rate(string name,double price, double discount = 0)
    {
        if (discount == 0)
        {
            ip = new NoDiscount(price);             //вызов метода через интерфейсную ссылку
        }
        else
        {
            ip = new AbsDiscount(price, discount);  //вызов метода через интерфейсную ссылку
        }

        _name = name;
    }
    
    public double GetPrice()
    {
        return ip.GetPrice();
    }

}

public class Station
{
    private string _name;
    
    private List<Rate> lstRate = new List<Rate>();
    
    public Station(string name)
    {
        _name = name;
    }

    public void AddWithDiscount(string name,double price, double discount)
    {
        lstRate.Add(new Rate(name,price,discount));
    }
    public void AddWNoDiscount(string name,double price)
    {
       
        lstRate.Insert(0,new Rate(name, price));
    }

    public string GetCheapest()
    {
        var buff = lstRate[0];
        foreach (var rate in lstRate)
        {
            if (buff.GetPrice() > rate.GetPrice())
                buff = rate;
        }

        return buff.Name + " " + buff.GetPrice();
    }
    
    
}