namespace adapter.adaptee;

public class Triangle
{
    public double Base { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Base * Height / 2;
    }
}