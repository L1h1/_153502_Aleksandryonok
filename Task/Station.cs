namespace Task;

public class Ticket
{ 
    private double? TicketPrice { get; set; }
    private int? PlaceNum{ get; set; }
    private int? SoldNum{ get; set; }
    public Ticket(){}

    public Ticket(double price, int places, int soldCount)
    {
        TicketPrice = price;
        PlaceNum = places;
        SoldNum = soldCount;
    }
    public void IncreasePrice()
    {
        TicketPrice += 10;
    }
    public void IncreasePrice(double value)
    {
        TicketPrice += value;
    }
    public void DecreasePrice()
    {
        if(TicketPrice.Value-10>=0)
        TicketPrice -= 10;
    }
    public void DecreasePrice(double value)
    {
        if(TicketPrice.Value-value>=0)
        TicketPrice -= value;
    }
    public void SetPrice(double value)
    {
        TicketPrice = value;
    }
    public void SetPlace(int value)
    {
        PlaceNum= value;
    }
    public void SetSold(int value)
    {
        SoldNum = value;
    }
    public double GetUnsold()
    {
        if (TicketPrice != null && SoldNum != null && PlaceNum!=null) 
            return (PlaceNum.Value - SoldNum.Value) * TicketPrice.Value;
        return -1;
    }

    public double GetPrice()
    {
        if (TicketPrice.HasValue)
            return TicketPrice.Value;
        else return -1;
    }

    public int GetPlace()
    {
        if(PlaceNum.HasValue)
        return PlaceNum.Value;
        return -1;
    }
    public string getData()
    {
        return TicketPrice.ToString() + "\n" + PlaceNum.ToString() + "\n" + SoldNum.ToString();
    }
}

public class Station
{
    private static Station? _instance;
    private string? _name=null;
    
    private Ticket _stationTicket;
    private Station()
    {
        _stationTicket = new Ticket();
    }
    public static Station GetInstance()
    {
        if (_instance == null)
            _instance = new Station();
        return _instance;
    }

    public string GetName()
    {
        if(_name!=null)
            return _name;
        return "NO_DATA";
    }

    public void SetName(string name)
    {
        _name = name;
    }
    public void StationSetPrice(double value)
    {
        
        _stationTicket.SetPrice(value);
    }

    public void StationIncreasePrice()
    {
        _stationTicket.IncreasePrice();
    }
    public void StationIncreasePrice(double value)
    {
        _stationTicket.IncreasePrice(value);
    }
    public void StationDecreasePrice()
    {
        _stationTicket.DecreasePrice();
    }
    public void StationDecreasePrice(double value)
    {
        _stationTicket.DecreasePrice(value);
        
    }
    public void StationSetPlace(int value)
    {
        _stationTicket.SetPlace(value);
    }
    public void StationSetSold(int value)
    {
        _stationTicket.SetSold(value);
    }
    public double StationGetUnsold()
    {
        return _stationTicket.GetUnsold();
    }

    public string StationGetData()
    {
        return _stationTicket.getData();
    }

    public double StationGetPrice()
    {
        return _stationTicket.GetPrice();
    }

    public int StationGetPlace()
    {
        return _stationTicket.GetPlace();
    }

    public string StationGetString()
    {
        return _name+"\n" + _stationTicket.getData();
    }

    public void StringToStation(string str)
    {
        string[] data= str.Split("\n");
        _name = data[0];
        _stationTicket = new Ticket(double.Parse(data[1]), int.Parse(data[2]), int.Parse(data[3]));
    }
}