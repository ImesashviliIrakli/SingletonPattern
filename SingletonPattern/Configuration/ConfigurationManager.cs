namespace SingletonPattern.Configuration;

public class ConfigurationManager
{
    private static ConfigurationManager instance;
    private static readonly object lockObject = new object();

    private ConfigurationManager()
    {
        Console.WriteLine("Loading configuration settings...");
    }

    public static ConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            lock (lockObject)
            {
                if (instance == null)
                {
                    instance = new ConfigurationManager();
                }
            }
        }

        return instance;
    }

    public void DisplayConfiguration()
    {
        Console.WriteLine("Configuration settings displayed.");
    }
}
