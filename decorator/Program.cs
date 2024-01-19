public abstract class AbstractDrink
{
    protected string _name;
    public abstract double TotalWeight { get; }
    public abstract string GetDescription(double weight);
    public string Description => GetDescription(TotalWeight);
}

public class Drink : AbstractDrink
{
    protected string _name = "Unknown Drink";

    public Drink(string? name)
    {
        if (name != null)
        {
            name = name.Trim();
            if (!string.IsNullOrEmpty(name)) _name = name;
        }
    }

    public override double TotalWeight => 0.0;

    public override string GetDescription(double weight)
    {
        return $"{_name}: {weight:N2}gs";
    }
}

public class DrinkMixing : AbstractDrink
{
    protected AbstractDrink _drink = default!;

    protected double _weight = 0.0;

    public DrinkMixing(AbstractDrink drink)
    {
        _drink = drink;
    }

    public override double TotalWeight => _drink.TotalWeight + _weight;

    public override string GetDescription(double weight)
    {
        if (_drink == null) return "";
        return _drink.GetDescription(weight);
    }
}

public class CoffeeMixing : DrinkMixing
{
    public CoffeeMixing(string name, double weight, AbstractDrink drink) : base(drink)
    {
        _name = name.Trim();
        if (string.IsNullOrEmpty(_name)) _name = "Unknown Drink";
        _weight = weight;
    }

    public override string GetDescription(double weight)
    {
        var per = 0.0;
        if (weight != 0) per = _weight / weight;
        var temp = base.GetDescription(weight).Trim();
        if (!string.IsNullOrEmpty(temp)) temp += Environment.NewLine;
        return $"{temp}+Coffee: ({_name}, {_weight:N2}gs, {per:P2})";
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        AbstractDrink drink = new Drink("MyDrink");
        Console.WriteLine(drink.Description);
        Console.WriteLine("\n>Then Coffee decorated");
        drink = new CoffeeMixing("Arabica", 2, drink);
        Console.WriteLine(drink.Description);
    }
}