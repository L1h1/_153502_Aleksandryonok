
using Task;

FileProcessor file = FileProcessor.GetInstance();

file.SetPath("C:/Users/Ialek/RiderProjects/_153502_Aleksandryonok/text.txt");
file.ReadFile();
Station s = Station.GetInstance();
s.StringToStation(file.GetContent());

Console.WriteLine(s.GetName());
Console.WriteLine(s.StationGetUnsold());

s.StationIncreasePrice();
file.WriteFile(s.StationGetString());
