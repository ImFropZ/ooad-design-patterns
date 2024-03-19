namespace builder;

public class BuilderA : IBuilder
{
    private Product p = new Product();

    public void BuildPart()
    {
        p.Add("Part A");
        p.Add("Part B");
    }

    public Product GetResult()
    {
        return p;
    }
}