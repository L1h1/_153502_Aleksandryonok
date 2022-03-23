namespace Task3;

public class DateService
{
    public static DateTime GetDay(string date)
    {
        return DateTime.Parse(date);
    }

    public static double GetDaysSpan(int day, int month, int year)
    {
        DateTime d = new DateTime(year, month, day);
        
        return (d-DateTime.Today).TotalDays;
    }
    //<0 если прошлое >0 если будущее
}