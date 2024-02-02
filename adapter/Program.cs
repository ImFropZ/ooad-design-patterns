using adapter;
using adapter.adaptee;
using adapter.adapter;
using adapter.target;

var shapes = new Shapes();

shapes.Add(new TriangleAdapter(new Triangle() { Height = 5, Base = 12 }));
shapes.Add(new CircleAdapter() { Radius = 10 });
shapes.Add(new Square() { Width = 10, Height = 5 });

foreach (var shape in shapes)
{
    Console.WriteLine($"Area of {shape.GetType().Name} is {shape.Area()}");
}

// Total area
Console.WriteLine($"Total area is {shapes.TotalArea()}");