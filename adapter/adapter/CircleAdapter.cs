using adapter.adaptee;
using adapter.target;

namespace adapter.adapter;

public class CircleAdapter : Circle, IShape
{
    public double Area()
    {
        return CalculateArea();
    }
}