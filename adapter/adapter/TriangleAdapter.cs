using adapter.adaptee;
using adapter.target;

namespace adapter.adapter;

public class TriangleAdapter : IShape
{
    private Triangle Triangle { get; set; }

    public TriangleAdapter(Triangle triangle)
    {
        Triangle = triangle;
    }

    public double Area()
    {
        return Triangle.GetArea();
    }
}