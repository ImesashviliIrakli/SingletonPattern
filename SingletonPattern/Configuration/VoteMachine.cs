namespace SingletonPattern.Configuration;

public class VoteMachine
{
    private static VoteMachine _instance = null;
    private static readonly object lockObject = new object();
    private int _totalVotes = 0;

    private VoteMachine()
    {
    }

    public static VoteMachine Instance()
    {
        if (_instance == null)
        {
            lock (lockObject)
            {
                if (_instance == null)
                    _instance = new VoteMachine();
            }
        }

        return _instance;
    }

    public void RegisterVote()
    {
        _totalVotes += 1;
        Console.WriteLine("Registered Vote #" + _totalVotes);
    }

    public int TotalVotes
    {
        get
        {
            return _totalVotes;
        }
    }
}

