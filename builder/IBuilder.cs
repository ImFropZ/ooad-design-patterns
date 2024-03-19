namespace builder;

public interface IBuilder
{
    void BuildPart();
    Product GetResult();
}