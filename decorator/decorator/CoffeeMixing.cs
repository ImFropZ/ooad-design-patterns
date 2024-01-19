using decorator.@interface;

namespace decorator.decorator;

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