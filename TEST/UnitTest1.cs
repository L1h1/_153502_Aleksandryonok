using NUnit.Framework;
using Task;

namespace TEST;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void ClientTestSummary()
    {
        Client cl = new Client("a", "b", "c");
        cl.ApplyTransaction(new Ticket(100,Station.Rate.First));
        cl.ApplyTransaction(new Ticket(45,Station.Rate.Second));
        cl.ApplyTransaction(new Ticket(37.1,Station.Rate.Third));
        Assert.AreEqual(cl.GetTransactionSummary(),182.1,0.000001);
    }
    [Test]
    public void ClientTestOnRate()
    {
        Client cl = new Client("a", "b", "c");
        cl.ApplyTransaction(new Ticket(100,Station.Rate.First));
        cl.ApplyTransaction(new Ticket(45,Station.Rate.Second));
        Assert.False(cl.IsOnRate(Station.Rate.Third));
        Assert.True(cl.IsOnRate(Station.Rate.First));
        Assert.True(cl.IsOnRate(Station.Rate.Second));
    }
    [Test]
    public void ClientTestData()
    {
        Client cl = new Client("a", "b", "c");
        Assert.AreEqual(cl.GetClientData(),"a\tb\tc");
    }
    [Test]
    public void TicketTestData()
    {
        Ticket ticket = new Ticket(273.324,Station.Rate.Second);
        Assert.AreEqual(ticket.GetData(),"273,324 Second");
    }
    [Test]
    public void StationListings()
    {
        Station saratov = new Station("Saratov",10.5,90.5,99.9);
        saratov.RegisterClient("John","Wick","sbkwegiu4rt4w83");
        saratov.RegisterClient("Victor","Heim","es565453wtgxw43");
        saratov.RegisterClient("David","King","zwekii342i2rk2g");
        saratov.RegisterClient("William","Owerbek","vcxmnn3gjmjkw21");
        saratov.SetActiveClient(0);
        saratov.ProcessTransaction(Station.Rate.First);
        saratov.ProcessTransaction(Station.Rate.Third);
        saratov.SetActiveClient(1);
        saratov.ProcessTransaction(Station.Rate.First);
        saratov.ProcessTransaction(Station.Rate.Second);
        saratov.SetActiveClient(2);
        saratov.ProcessTransaction(Station.Rate.Second);
        saratov.ProcessTransaction(Station.Rate.Third);
        saratov.SetActiveClient(3);
        saratov.ProcessTransaction(Station.Rate.First);
        saratov.ProcessTransaction(Station.Rate.Second);
        saratov.ProcessTransaction(Station.Rate.Third);
        Assert.AreEqual(saratov.ShowClients(),"###################################Client_List###################################\n" +
                                              "[0] John\tWick\tsbkwegiu4rt4w83\n" +
                                              "[1] Victor\tHeim\tes565453wtgxw43\n" +
                                              "[2] David\tKing\tzwekii342i2rk2g\n" +
                                              "[3] William\tOwerbek\tvcxmnn3gjmjkw21\n" +
                                              "#################################################################################");
        Assert.AreEqual(saratov.ShowRateTransactions(Station.Rate.First),"#################################First########################################\n" +
                                                                          "[0] John\tWick\tsbkwegiu4rt4w83\n" +
                                                                          "[1] Victor\tHeim\tes565453wtgxw43\n" +
                                                                          "[3] William\tOwerbek\tvcxmnn3gjmjkw21\n" +
                                                                          "#################################################################################");
    }
}