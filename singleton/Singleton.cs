namespace singleton;

public class Singleton
{
    // Unique instance for the Singleton class
    // If the instance is null, create a new instance
    // If the instance is not null, return the instance
    private static Singleton? _unique = null;

    // Example field
    private string _message = "Singleton is doing something";

    // CreateInstance method
    public static Singleton CreateInstance()
    {
        if (_unique == null)
            _unique = new Singleton();
        return _unique;
    }

    // Example methods
    public void ModifyMessage(string message)
    {
        _message = message;
    }

    public void ShowMessage()
    {
        Console.WriteLine(_message);
    }
}