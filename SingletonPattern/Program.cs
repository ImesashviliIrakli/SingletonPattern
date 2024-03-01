using SingletonPattern.Configuration;

Console.WriteLine("Press Enter to call ConfigurationManager.GetInstance()...");

// Wait for user input
Console.ReadLine();

// Getting an instance of the ConfigurationManager class
ConfigurationManager configManager1 = ConfigurationManager.GetInstance();

// Performing some action using the ConfigurationManager instance
configManager1.DisplayConfiguration();

Console.WriteLine("Press Enter to call ConfigurationManager.GetInstance() again...");

// Wait for user input
Console.ReadLine();

// Getting another instance (will be the same instance as before)
ConfigurationManager configManager2 = ConfigurationManager.GetInstance();

// They are the same instance
Console.WriteLine(configManager1 == configManager2);  // Output: True

// Prevent the console application from closing immediately
Console.ReadLine();

VoteMachine vm1 = VoteMachine.Instance();
VoteMachine vm2 = VoteMachine.Instance();
VoteMachine vm3 = VoteMachine.Instance();

vm1.RegisterVote();
vm2.RegisterVote();
vm3.RegisterVote();

Console.WriteLine(vm1.TotalVotes);