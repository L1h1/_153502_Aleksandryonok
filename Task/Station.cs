using System.Numerics;

namespace Task;
public class Client
{
    private string firstName_,lastName_,docNumber_;
    private Ticket[] tickets_;
    private double wholePrice = 0;
    public Client(string firstName,string lastName,string docNumber){
        firstName_ = firstName;
        lastName_ = lastName;
        docNumber_ = docNumber;
        tickets_ = new Ticket[0];
    }
    public string GetClientData()                   //aka toString
    {
        string c=firstName_+"\t"+lastName_+"\t"+docNumber_;
        return c;
    }
    public void ApplyTransaction(Ticket ticket)     //запись билета в профиле клиента
    {
        Array.Resize(ref tickets_, tickets_.Length + 1);
        tickets_.SetValue(ticket,tickets_.Length-1);
        wholePrice += ticket.GetPrice();
    }
    public double GetTransactionSummary()
    {
        return wholePrice;
    }
    public bool IsOnRate(Station.Rate rate)
    {
        for (int i = 0; i < tickets_.Length; i++)
        {
            if (tickets_[i].GetRate() == rate)
                return true;
        }

        return false;
    }
}
public class Ticket
{
    private double price_;
    private Station.Rate rate_;
    public Ticket(double price, Station.Rate rate)
    {
        price_ = price;
        rate_ = rate;
    }
    public string GetData()
    {
        return price_.ToString() +" "+ rate_.ToString();
    }

    public Station.Rate GetRate()
    {
        return rate_;
    }
    public double GetPrice()
    {
        return price_;
    }
}
public class Station
{
    private Client activeClient_;
    private double forwardPrice_, backwardPrice_, bothPrice_;
    public enum Rate
     {
         First,
         Second,
         Third
     }
    private Client[] clients_;
    private string name_;
    public Station(string name,double forwardPrice,double backwardPrice,double bothPrice)
    {
        name_ = name;
        forwardPrice_ = forwardPrice;
        backwardPrice_ = backwardPrice;
        bothPrice_ = bothPrice;
        clients_ = new Client[0];
    }
    public void RegisterClient(string firstName,string lastName,string docNumber)
    {
        Array.Resize(ref clients_,clients_.Length+1);
        Client c = new Client(firstName,lastName,docNumber);
        clients_.SetValue(c,clients_.Length-1);
    }
    public string ShowClients()
    {
        string str=new string("");
        str+="###################################Client_List###################################\n";
        for (int i = 0; i < clients_.Length; i++)
        {
            str+="[" + i.ToString() + "] " + clients_[i].GetClientData()+"\n";
        }
        str+="#################################################################################";
        return str;
    }
    public void SetActiveClient(uint index)     //выбор клиента перед транзакцией
    {
        if (index < clients_.Length)
            activeClient_ = clients_[index];
    }

    public double GetClientSummary()
    {
        return activeClient_.GetTransactionSummary();
    }
    public void ProcessTransaction(Rate rate)
    {
        Ticket ticket;
        switch (rate)
        {
            case Rate.First:
                ticket = new Ticket(forwardPrice_, Rate.First);
                break;
            case Rate.Second:
                ticket = new Ticket(backwardPrice_, Rate.Second);
                break;
            case Rate.Third:
                ticket = new Ticket(bothPrice_, Rate.Third);
                break;
            default:
                ticket = new Ticket(-1, Rate.Second);
                break;
        }
        activeClient_.ApplyTransaction(ticket);
    }

    public string ShowRateTransactions(Rate rate)
    {
        string str = new string("");
        str+="#################################"+rate.ToString()+"########################################\n";
        for (int i = 0; i < clients_.Length; i++)
        {
            if(clients_[i].IsOnRate(rate))
                str+="[" + i.ToString() + "] " + clients_[i].GetClientData()+"\n";
        }
        str+="#################################################################################";
        return str;
    }
    
}