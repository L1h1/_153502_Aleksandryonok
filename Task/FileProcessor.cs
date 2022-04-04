namespace Task;

public class FileProcessor
{
    private static FileProcessor instance=null;
    private static FileStream file;
    private static string content="NO_DATA_";
    private FileProcessor()
    {
        
    }

    public static FileProcessor GetInstance()
    {
        if (instance == null)
            instance = new FileProcessor();
        return instance;
    }

    
    public void ReadFile(string path)
    {
        file = new FileStream(path, FileMode.Open, FileAccess.Read);
        content = "";
        StreamReader reader = new StreamReader(file);
        content = reader.ReadToEnd();
        reader.Close();
        file.Close();
    }

    public string GetContent()
    {
        return content;
    }
}