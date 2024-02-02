using adapter.target;

namespace adapter;

public class Shapes : List<IShape>
{
    public double TotalArea()
    {
        return this.Sum(shape => shape.Area());
    }
}