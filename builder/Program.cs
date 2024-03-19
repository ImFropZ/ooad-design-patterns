// See https://aka.ms/new-console-template for more information

using builder;

var d = new Director();
var ba = new BuilderA();
var bb = new BuilderB();

d.Construct(ba);
d.Construct(bb);
Console.WriteLine(ba.GetResult().GetDisplay());
Console.WriteLine(bb.GetResult().GetDisplay());
