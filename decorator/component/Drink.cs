using decorator.@interface;

namespace decorator.component;

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