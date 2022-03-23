
using Task3;

Console.WriteLine("Enter date in format dd mm yyyy");

string? str=Console.ReadLine();
DateTime d = DateService.GetDay(str);
Console.WriteLine($"{d.Day} {d.Month} {d.DayOfWeek} {d.Year}");

Console.WriteLine("Enter day month year in integer format");

int day=Convert.ToInt32(Console.ReadLine());
int month=Convert.ToInt32(Console.ReadLine());
int year=Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Difference between dates: {DateService.GetDaysSpan(day,month,year)}");