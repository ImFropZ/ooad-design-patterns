namespace builder;

using System.Text;

public class Product
{
    private List<String> _parts = new List<string>();

    public void Add(String part)
    {
        _parts.Add(part);
    }

    public String GetDisplay()
    {
        var b = new StringBuilder();
        b.AppendLine("Products Parts ... ");
        foreach (var part in _parts)
        {
            b.AppendLine(" - " + part);
        }
        return b.ToString();
    }
}