namespace Task;

public class FileProcessor
{
    private static FileProcessor? _instance;
    private static FileStream? _file;
    private static string? _content;
    private static string? _path;
    private FileProcessor()
    {
    }
    public static FileProcessor GetInstance()
    {
        if (_instance == null)
            _instance = new FileProcessor();
        return _instance;
    }
    public void ReadFile()
    {
        if (_path == null)
            return;
        _file = new FileStream(_path, FileMode.Open, FileAccess.Read);
        _content = "";
        StreamReader reader = new StreamReader(_file);
        _content = reader.ReadToEnd();
        reader.Close();
        _file.Close();
    }

    public void SetPath(string path)
    {
        _path = path;
    }
    public string GetContent()
    {
        if (_content != null)
            return _content; return "NO_DATA_";
    }

    public void WriteFile(string str)
    {
        if (_path == null)
            return;
        _content = "";
        StreamWriter reader = new StreamWriter(_path,false);
        reader.WriteAsync(str);
        reader.Close();
        
    }
}