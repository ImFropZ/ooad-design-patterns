namespace factory_method.product;

public class ProductA : IProduct
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string ShipFrom { get; }

    public ProductA(string code, string name)
    {
        Code = code;
        Name = name;
        ShipFrom = "USA";
    }
    
    public string GetInfo()
    {
        return $"Product: {Code} - {Name} - {ShipFrom}";
    }
}