// See https://aka.ms/new-console-template for more information

using prototype;

IPrototype sp = new SimplePrototype(20,
    new Data("Price", 300));
IPrototype dp = new DeepPrototype(50,
    new Data("Goods", 450));
IPrototype sc = null, dc = null;

sc = sp.Clone();
dc = dp.Clone();

Console.WriteLine("Simple Prototype: ");
Console.WriteLine($"\t1-Prototype: {sp.Info}");
Console.WriteLine($"\t2-Clone: {sc.Info}");

Console.WriteLine("Update the clone: ");
((SimplePrototype)sc).Number = 45;
((SimplePrototype)sc).Data.Field = "Amount";
((SimplePrototype)sc).Data.Value = 500;

Console.WriteLine($"\t3-Prototype: {sp.Info}");
Console.WriteLine($"\t4-Clone: {sc.Info}");

Console.WriteLine();

Console.WriteLine("Deep Prototype: ");
Console.WriteLine($"\t1-Prototype: {dp.Info}");
Console.WriteLine($"\t2-Clone: {dc.Info}");

Console.WriteLine("Update the clone: ");
((DeepPrototype)dc).Number = 90;
((DeepPrototype)dc).Data.Field = "Crops";
((DeepPrototype)dc).Data.Value = 980;

Console.WriteLine($"\t3-Prototype: {dp.Info}");
Console.WriteLine($"\t4-Clone: {dc.Info}");