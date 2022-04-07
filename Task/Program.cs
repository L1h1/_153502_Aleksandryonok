
using Task;

FileProcessor file = FileProcessor.GetInstance();

file.SetPath("C:/Users/Ialek/RiderProjects/_153502_Aleksandryonok/text.txt");
file.ReadFile();
string[] data= file.GetContent().Split("\n");

Station s = Station.GetInstance();
s.SetName(data[0]);
Console.WriteLine(s.GetName());

s.InitData(double.Parse(data[1]),int.Parse(data[2]),int.Parse(data[3]));
Console.WriteLine(s.StationGetUnsold());

s.StationIncreasePrice();
file.WriteFile(s.GetName()+"\n"+s.StationGetData());
