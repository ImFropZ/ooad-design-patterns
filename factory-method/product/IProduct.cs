namespace factory_method.product;

public interface IProduct
{
    string Code { get; set; }
    string Name { get; set; }
    string ShipFrom { get; }
    
    string GetInfo();
}