namespace prototype;

public interface IPrototype
{
    string Info { get; }
    IPrototype Clone();
}