namespace adapter.adaptee;

public class Circle
{
    public double Radius { get; set; }
    
    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}