namespace Task;

public class Station
{
    private static Station instance = null;

    private Station()
    {
    }

    public static Station GetInstance()
    {
        if (instance == null)
            instance = new Station();
        return instance;
    }

}