namespace composite;

public class Component : IComponent
{
    private String text;

    public Component(String text)
    {
        this.text = text;
    }

    public string Operation()
    {
        return text;
    }
}