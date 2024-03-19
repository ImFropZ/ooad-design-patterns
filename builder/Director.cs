namespace builder;

public class Director
{
    public void Construct(IBuilder b)
    {
        b.BuildPart();
    }
}