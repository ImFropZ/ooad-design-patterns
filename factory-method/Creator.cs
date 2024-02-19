using factory_method.product;

namespace factory_method;

public class Creator
{
    public IProduct FactoryMethod(string type, string code, string name) => type switch
    {
        "A" => new ProductA(code, name),
        "B" => new ProductB(code, name),
        _ => new ProductA(code, name)
    };
}