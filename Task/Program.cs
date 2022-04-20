
    using Task;

    Station saratov = new Station("Saratov",10.5,90.5,99.9);
    //регистрация клиентов по паспартным данным
    saratov.RegisterClient("John","Wick","sbkwegiu4rt4w83");
    saratov.RegisterClient("Victor","Heim","es565453wtgxw43");
    saratov.RegisterClient("David","King","zwekii342i2rk2g");
    saratov.RegisterClient("William","Owerbek","vcxmnn3gjmjkw21");
    Console.WriteLine(saratov.ShowClients());
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
    
    saratov.SetActiveClient(0);
    Console.WriteLine(saratov.GetClientSummary());
    saratov.SetActiveClient(1);
    Console.WriteLine(saratov.GetClientSummary());
    saratov.SetActiveClient(2);
    Console.WriteLine(saratov.GetClientSummary());
    saratov.SetActiveClient(3);
    Console.WriteLine(saratov.GetClientSummary());
    
    Console.WriteLine(saratov.ShowRateTransactions(Station.Rate.First));
    Console.WriteLine(saratov.ShowRateTransactions(Station.Rate.Second));
    Console.WriteLine(saratov.ShowRateTransactions(Station.Rate.Third));