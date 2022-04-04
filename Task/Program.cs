
using Task;

Console.WriteLine("Hello, World!");
FileProcessor file = FileProcessor.GetInstance();
file.ReadFile("‪C:\\Users\\Ialek\\RiderProjects\\_153502_Aleksandryonok\\Text Document.txt");
Console.WriteLine(file.GetContent());