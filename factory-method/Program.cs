using factory_method;

var creator = new Creator();

var productA = creator.FactoryMethod("A", "A001", "Product A");
var productB = creator.FactoryMethod("B", "B001", "Product B");

Console.WriteLine(productA.GetInfo());
Console.WriteLine(productB.GetInfo()); 