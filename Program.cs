// See https://aka.ms/new-console-template for more information
public class Logger
{
    private Logger()
    {
    }
    // private constructor to prevent direct instantiation

    private static Logger instance;
    //A single instance of the Logger is created

    public static Logger GetInstance()
    //static method that controls access to the singleton instance
    {
        if (instance == null)
        {
            instance = new Logger();
        }
        return instance;
    }

    public void LogMessage(string text)
    {
        Console.WriteLine(text);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Logger logger = Logger.GetInstance();
        logger.LogMessage("This is a test message");
    }
}
