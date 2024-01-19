namespace decorator.@interface;

public abstract class AbstractDrink
{
    protected string _name;
    public abstract double TotalWeight { get; }
    public abstract string GetDescription(double weight);
    public string Description => GetDescription(TotalWeight);
}