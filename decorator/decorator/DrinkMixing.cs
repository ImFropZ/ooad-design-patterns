using decorator.@interface;

namespace decorator.decorator;

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