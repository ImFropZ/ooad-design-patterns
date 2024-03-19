namespace builder;

public class BuilderB : IBuilder
{
    private Product p = new Product();

    public void BuildPart()
    {
        p.Add("Part X");
        p.Add("Part Y");
    }

    public Product GetResult()
    {
        return p;
    }
}