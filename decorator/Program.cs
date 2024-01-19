using decorator.component;
using decorator.decorator;
using decorator.@interface;

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