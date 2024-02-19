namespace factory_method.product;

public class ProductB : IProduct
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string ShipFrom { get; }

    public ProductB(string code, string name)
    {
        Code = code;
        Name = name;
        ShipFrom = "Cambodia";
    }

    public string GetInfo()
    {
        return $"Product: {Code} - {Name} - {ShipFrom}";
    }
}