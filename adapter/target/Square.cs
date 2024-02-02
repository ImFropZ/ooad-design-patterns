namespace adapter.target;

public class Square : IShape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public double Area()
    {
        return Width * Height;
    }
}